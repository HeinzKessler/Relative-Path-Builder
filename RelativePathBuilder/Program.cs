using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelativePathBuilder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( string[] args )
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            // if the "Upgraded" flag is not set, then these settings are newly created
            // This happens at the very first program start, but also after a program update
            // In this case we run a settings upgrade and set "Upgraded" to true.
            if( !Properties.Settings.Default.Upgraded )
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Upgraded = true;
                Properties.Settings.Default.Save();
            }

            Application.Run( new Form1( args ) );
        }
    }
}
