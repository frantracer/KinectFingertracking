using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace FingerTracking
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create a console to debug
            Win32.AllocConsole();

            // Start the Kinect test Application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
