using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormUI
{
    public static class Program
    {
        public static UserLoginForm mainForm = new UserLoginForm();
        internal static bool lockBlockchains;
        internal static int updateTimeout = 1000;
        internal static List<Seed> seeds;

        public static List<string> BLOCKCHAINS { get; internal set; }
        public static long CHECK_START { get; internal set; }
        public static bool CAN_EDIT_FOUND { get; internal set; }
        public static long CHECK_SCORE = 1;
        public static int SPEED_PER_ROW = 80;
        public static int WORDS_COUNT_IN_ROW = 6;
        public static int IMMEDIATELY_FIND_SEED_SCORE { get; internal set; }
        public static string SAVE_FILE = @"E:\results.txt";
        public static string MNEMONIC_TEXT = "Wallet Check: ";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(mainForm);
            Application.Run(mainForm);
        }
    }
}
