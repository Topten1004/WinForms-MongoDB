using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LoginFormUI
{
    public static class Program
    {
        public static UserLoginForm mainForm = new UserLoginForm();
        internal static int updateTimeout = 500;
        public static long CHECK_SCORE = 3;
        public static int SPEED_PER_ROW = 15;
        public static int WORDS_COUNT_IN_ROW = 12;
        public static string SAVE_FILE = @"results.txt";
        public static string MNEMONIC_TEXT = "Wallet Check: ";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool instanceCountOne = false;

            using (Mutex mtex = new Mutex(true, "MyRunningApp", out instanceCountOne))
            {
                if (instanceCountOne)
                {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(mainForm);
                    mtex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("An application instance is already running");
                }
            }

        }
    }
}
