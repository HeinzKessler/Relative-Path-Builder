// MIT License

// Copyright (c) 2018 Heinz Kessler

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
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
