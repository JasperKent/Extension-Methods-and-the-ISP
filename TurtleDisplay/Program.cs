using System;
using System.Windows.Forms;
using TurtleLogic;

namespace TurtleDisplay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TurtleForm(new Turtle()));
        }
    }
}
