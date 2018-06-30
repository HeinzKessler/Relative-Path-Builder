using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolderSelect;

namespace RelativePathBuilder
{
    public partial class Form1 : Form
    {
        public Form1( string[] args ) : this()
        {
            switch( args.Length )
            {
            case 0:
                break;
            case 1:
                comboSetTextFromCommandLine( comboBoxPath1, args[0] );
                CombosAddTextToMRUs();
                break;
            default:
                comboSetTextFromCommandLine( comboBoxPath1, args[0] );
                comboSetTextFromCommandLine( comboBoxPath2, args[1] );
                CombosAddTextToMRUs();
                break;
            }

            labelResult12.Text = "1\u25ba2";    // "1 > 2"
            labelResult21.Text = "2\u25ba1";    // "2 > 1"
        }

        private void comboSetTextFromCommandLine( ComboBox combo, string text )
        {
            combo.SelectedIndex = -1;
            combo.Text = text.Replace( "\"", "" );
        }

        public Form1()
        {
            InitializeComponent();

            // There seems to be a bug in TextBox ForeColor, if they are set to read only:
            // https://www.codeproject.com/Questions/359467/Change-forecolor-of-text-when-textbox-is-readonly
            // BackColor must be set once, only then it works
            textBoxResult21.BackColor = textBoxResult12.BackColor = this.BackColor;

            labelVersion.Text = string.Format( labelVersion.Text, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version );

            // Strange location issue with this with High DPI settings, therefore...
            labelVersion.Location = new Point( buttonBrowse2.Right - labelVersion.Width, labelVersion.Top );
            labelVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            comboBoxPath1.LoadMRUListFromSettings( Properties.Settings.Default.combo1MRU );
            comboBoxPath2.LoadMRUListFromSettings( Properties.Settings.Default.combo2MRU );

            this.FormClosing += ( s, e ) => comboSaveMRULists();
        }

        private void textBoxPath_TextChanged( object sender, EventArgs e )
        {
            CreateAndShowRelativePath();
        }

        private void CheckboxCheckChanged( object sender, EventArgs e )
        {
            CreateAndShowRelativePath();
            CombosAddTextToMRUs();
        }

        private void textBoxResult12_TextChanged( object sender, EventArgs e )
        {
            buttonCopy21.Enabled = buttonCopy12.Enabled = textBoxResult12.Text.Length > 0;
        }


        private void buttonCopy12_Click( object sender, EventArgs e )
        {
            Clipboard.SetText( textBoxResult12.Text );
            CombosAddTextToMRUs();
        }

        private void buttonCopy21_Click( object sender, EventArgs e )
        {
            Clipboard.SetText( textBoxResult21.Text );
            CombosAddTextToMRUs();
        }


        private void comboSaveMRULists()
        {
            var newStringColl = new StringCollection();
            newStringColl.AddRange( comboBoxPath1.GetMRUList().ToArray() );
            Properties.Settings.Default.combo1MRU = newStringColl;

            newStringColl = new StringCollection();
            newStringColl.AddRange( comboBoxPath2.GetMRUList().ToArray() );
            Properties.Settings.Default.combo2MRU = newStringColl;

            Properties.Settings.Default.Save();
        }

        const int MAX_PATH = 256;
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x10;

        void CreateAndShowRelativePath()
        {
            var path1 = comboBoxPath1.Text.Replace( "\"", "" ).Trim();
            var path2 = comboBoxPath2.Text.Replace( "\"", "" ).Trim();

            if( path1 == "" || path2 == "" )
            {
                textBoxResult21.Text = textBoxResult12.Text = "";
                return;
            }

            var sb12 = new StringBuilder( MAX_PATH + 1 );
            var success = NativeMethods.PathRelativePathTo( sb12,
                                         path1,
                                         checkBoxIsFilename1.Checked ? 0u : FILE_ATTRIBUTE_DIRECTORY,
                                         path2,
                                         checkBoxIsFilename2.Checked ? 0u : FILE_ATTRIBUTE_DIRECTORY
                                        );

            var sb21 = new StringBuilder( MAX_PATH + 1 );
            NativeMethods.PathRelativePathTo( sb21,
                                              path2,
                                              checkBoxIsFilename2.Checked ? 0u : FILE_ATTRIBUTE_DIRECTORY,
                                              path1,
                                              checkBoxIsFilename1.Checked ? 0u : FILE_ATTRIBUTE_DIRECTORY
                                            );

            if( success )
            {
                textBoxResult21.ForeColor = textBoxResult12.ForeColor = this.ForeColor;
                textBoxResult12.Text = sb12.ToString();
                textBoxResult21.Text = sb21.ToString();
                buttonCopy21.Enabled = buttonCopy12.Enabled = textBoxResult12.Text != "";
            }
            else
            {
                textBoxResult21.ForeColor = textBoxResult12.ForeColor = Color.Red;
                textBoxResult21.Text = textBoxResult12.Text = "** Cannot create relative path **";
                buttonCopy21.Enabled = buttonCopy12.Enabled = false;
            }

        }

        private void buttonBrowse1_Click( object sender, EventArgs e ) => BrowseForFolder( comboBoxPath1 );
        private void buttonBrowse2_Click( object sender, EventArgs e ) => BrowseForFolder( comboBoxPath2 );

        private void BrowseForFolder( Control textControlPath )
        {
            var dlg = new FolderSelectDialog();
            if( dlg.ShowDialog() )
            {
                textControlPath.Text = dlg.FileName;
                CombosAddTextToMRUs();
            }
        }

        private void CombosAddTextToMRUs()
        {
            comboBoxPath1.AddCurrentComboTextToMRU();
            comboBoxPath2.AddCurrentComboTextToMRU();
        }

        private void linkLabel2_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) =>
            System.Diagnostics.Process.Start( "http://icons8.com" );

    }

    static class NativeMethods
    {
        [DllImport( "shlwapi.dll", CharSet = CharSet.Unicode )]
        internal static extern bool PathRelativePathTo(
             [Out] StringBuilder pszPath,
             [In] string pszFrom,
             [In] uint dwAttrFrom,
             [In] string pszTo,
             [In] uint dwAttrTo
        );
    }
}
