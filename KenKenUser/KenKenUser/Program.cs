using System;
using System.Windows.Forms;

namespace KenKenUser
{
    static class Program
    {
        static public int[] tabl_leader = new int[10];
        static public string filename = "problems.pken";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
}
