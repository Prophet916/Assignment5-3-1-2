using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_3_1_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and display Form2 first
            var form2 = new Form2();
            Application.Run(form2);


            // Display Form1 when button to enter store is clicked
            if (form2.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
