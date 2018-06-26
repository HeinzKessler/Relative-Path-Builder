﻿// Copyright (c) 2013-2014 Heinz Kessler, All Rights Reserved
// These sources must not be used without written consent by the author
using System;
using System.Windows.Forms;
using System.Reflection;

// ------------------------------------------------------------------
// Wraps System.Windows.Forms.OpenFileDialog to make it present
// a vista-style dialog.
// ------------------------------------------------------------------

#pragma warning disable 1591

namespace FolderSelect
{
    /// <summary>
    /// Wraps System.Windows.Forms.OpenFileDialog to make it present
    /// a vista-style dialog.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable" )]
    public class FolderSelectDialog
    {
        // Wrapped dialog
        System.Windows.Forms.OpenFileDialog ofd = null;

        /// <summary>
        /// Default constructor
        /// </summary>
        public FolderSelectDialog()
        {
            ofd = new System.Windows.Forms.OpenFileDialog();

            ofd.Filter = "Folders|\n";
            ofd.AddExtension = false;
            ofd.CheckFileExists = false;
            ofd.DereferenceLinks = true;
            ofd.Multiselect = false;
        }

        #region Properties

        /// <summary>
        /// Gets/Sets the initial folder to be selected. A null value selects the current directory.
        /// </summary>
        public string InitialDirectory
        {
            get { return ofd.InitialDirectory; }
            set { ofd.InitialDirectory = value == null || value.Length == 0 ? Environment.CurrentDirectory : value; }
        }

        /// <summary>
        /// Gets/Sets the title to show in the dialog
        /// </summary>
        public string Title
        {
            get { return ofd.Title; }
            set { ofd.Title = value == null ? "Select a folder" : value; }
        }

        /// <summary>
        /// Gets the selected folder
        /// </summary>
        public string FileName
        {
            get { return ofd.FileName; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the dialog
        /// </summary>
        /// <returns>True if the user presses OK else false</returns>
        public bool ShowDialog()
        {
            return ShowDialog( IntPtr.Zero );
        }

        /// <summary>
        /// Shows the dialog
        /// </summary>
        /// <param name="hWndOwner">Handle of the control to be parent</param>
        /// <returns>True if the user presses OK else false</returns>
        public bool ShowDialog( IntPtr hWndOwner )
        {
            bool flag = false;

            if( Environment.OSVersion.Version.Major >= 6 )
            {
                var r = new Reflector( "System.Windows.Forms" );

                uint num = 0;
                Type typeIFileDialog = r.GetType( "FileDialogNative.IFileDialog" );
                object dialog = r.Call( ofd, "CreateVistaDialog" );
                r.Call( ofd, "OnBeforeVistaDialog", dialog );

                uint options = (uint) r.CallAs( typeof( System.Windows.Forms.FileDialog ), ofd, "GetOptions" );
                options |= (uint) r.GetEnum( "FileDialogNative.FOS", "FOS_PICKFOLDERS" );
                r.CallAs( typeIFileDialog, dialog, "SetOptions", options );

                object pfde = r.New( "FileDialog.VistaDialogEvents", ofd );
                object[] parameters = new object[] { pfde, num };
                r.CallAs2( typeIFileDialog, dialog, "Advise", parameters );
                num = (uint) parameters[1];
                try
                {
                    int num2 = (int) r.CallAs( typeIFileDialog, dialog, "Show", hWndOwner );
                    flag = 0 == num2;
                }
                finally
                {
                    r.CallAs( typeIFileDialog, dialog, "Unadvise", num );
                    GC.KeepAlive( pfde );
                }
            }
            else
            {
                var fbd = new FolderBrowserDialog();
                fbd.Description = this.Title;
                fbd.SelectedPath = this.InitialDirectory;
                fbd.ShowNewFolderButton = false;
                if( fbd.ShowDialog( new WindowWrapper( hWndOwner ) ) != DialogResult.OK ) return false;
                ofd.FileName = fbd.SelectedPath;
                flag = true;
            }

            return flag;
        }

        #endregion
    }

    /// <summary>
    /// Creates IWin32Window around an IntPtr
    /// </summary>
    public class WindowWrapper : System.Windows.Forms.IWin32Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="handle">Handle to wrap</param>
        public WindowWrapper( IntPtr handle )
        {
            _hwnd = handle;
        }

        /// <summary>
        /// Original ptr
        /// </summary>
        public IntPtr Handle
        {
            get { return _hwnd; }
        }

        private IntPtr _hwnd;
    }


    public class Reflector
    {
        #region variables

        string m_ns;
        Assembly m_asmb;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ns">The namespace containing types to be used</param>
        public Reflector( string ns )
            : this( ns, ns )
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="an">A specific assembly name (used if the assembly name does not tie exactly with the namespace)</param>
        /// <param name="ns">The namespace containing types to be used</param>
        public Reflector( string an, string ns )
        {
            m_ns = ns;
            m_asmb = null;
            foreach( AssemblyName aN in Assembly.GetExecutingAssembly().GetReferencedAssemblies() )
            {
                if( aN.FullName.StartsWith( an ) )
                {
                    m_asmb = Assembly.Load( aN );
                    break;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Return a Type instance for a type 'typeName'
        /// </summary>
        /// <param name="typeName">The name of the type</param>
        /// <returns>A type instance</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0" )]
        public Type GetType( string typeName )
        {
            Type type = null;
            string[] names = typeName.Split( '.' );

            if( names.Length > 0 )
                type = m_asmb.GetType( m_ns + "." + names[0] );

            for( int i = 1; i < names.Length; ++i )
            {
                type = type.GetNestedType( names[i], BindingFlags.NonPublic );
            }
            return type;
        }

        /// <summary>
        /// Create a new object of a named type passing along any params
        /// </summary>
        /// <param name="name">The name of the type to create</param>
        /// <param name="parameters"></param>
        /// <returns>An instantiated type</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes" )]
        public object New( string name, params object[] parameters )
        {
            Type type = GetType( name );

            ConstructorInfo[] ctorInfos = type.GetConstructors();
            foreach( ConstructorInfo ci in ctorInfos )
            {
                try
                {
                    return ci.Invoke( parameters );
                }
                catch { }
            }

            return null;
        }

        /// <summary>
        /// Calls method 'func' on object 'obj' passing parameters 'parameters'
        /// </summary>
        /// <param name="obj">The object on which to excute function 'func'</param>
        /// <param name="func">The function to execute</param>
        /// <param name="parameters">The parameters to pass to function 'func'</param>
        /// <returns>The result of the function invocation</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj" )]
        public object Call( object obj, string func, params object[] parameters )
        {
            return Call2( obj, func, parameters );
        }

        /// <summary>
        /// Calls method 'func' on object 'obj' passing parameters 'parameters'
        /// </summary>
        /// <param name="obj">The object on which to excute function 'func'</param>
        /// <param name="func">The function to execute</param>
        /// <param name="parameters">The parameters to pass to function 'func'</param>
        /// <returns>The result of the function invocation</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj" )]
        public object Call2( object obj, string func, object[] parameters )
        {
            return CallAs2( obj.GetType(), obj, func, parameters );
        }

        /// <summary>
        /// Calls method 'func' on object 'obj' which is of type 'type' passing parameters 'parameters'
        /// </summary>
        /// <param name="type">The type of 'obj'</param>
        /// <param name="obj">The object on which to excute function 'func'</param>
        /// <param name="func">The function to execute</param>
        /// <param name="parameters">The parameters to pass to function 'func'</param>
        /// <returns>The result of the function invocation</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "CallAs" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj" )]
        public object CallAs( Type type, object obj, string func, params object[] parameters )
        {
            return CallAs2( type, obj, func, parameters );
        }

        /// <summary>
        /// Calls method 'func' on object 'obj' which is of type 'type' passing parameters 'parameters'
        /// </summary>
        /// <param name="type">The type of 'obj'</param>
        /// <param name="obj">The object on which to excute function 'func'</param>
        /// <param name="func">The function to execute</param>
        /// <param name="parameters">The parameters to pass to function 'func'</param>
        /// <returns>The result of the function invocation</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "CallAs" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Performance", "CA1822:MarkMembersAsStatic" )]
        public object CallAs2( Type type, object obj, string func, object[] parameters )
        {
            MethodInfo methInfo = type.GetMethod( func, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic );
            return methInfo.Invoke( obj, parameters );
        }

        /// <summary>
        /// Returns the value of property 'prop' of object 'obj'
        /// </summary>
        /// <param name="obj">The object containing 'prop'</param>
        /// <param name="prop">The property name</param>
        /// <returns>The property value</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj" )]
        public object Get( object obj, string prop )
        {
            return GetAs( obj.GetType(), obj, prop );
        }

        /// <summary>
        /// Returns the value of property 'prop' of object 'obj' which has type 'type'
        /// </summary>
        /// <param name="type">The type of 'obj'</param>
        /// <param name="obj">The object containing 'prop'</param>
        /// <param name="prop">The property name</param>
        /// <returns>The property value</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj" ), System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Performance", "CA1822:MarkMembersAsStatic" )]
        public object GetAs( Type type, object obj, string prop )
        {
            PropertyInfo propInfo = type.GetProperty( prop, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic );
            return propInfo.GetValue( obj, null );
        }

        /// <summary>
        /// Returns an enum value
        /// </summary>
        /// <param name="typeName">The name of enum type</param>
        /// <param name="name">The name of the value</param>
        /// <returns>The enum value</returns>
        public object GetEnum( string typeName, string name )
        {
            Type type = GetType( typeName );
            FieldInfo fieldInfo = type.GetField( name );
            return fieldInfo.GetValue( null );
        }

        #endregion

    }

}

#pragma warning restore 1591
