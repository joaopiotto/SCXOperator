using System;
using System.Windows.Forms;

namespace SCXOperator
{

    static class Program
    {

        public static Random random = new Random(int.Parse(DateTime.Now.ToString("ss")));

        public static Random getRandom { get { return random; } }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }

    }

}
