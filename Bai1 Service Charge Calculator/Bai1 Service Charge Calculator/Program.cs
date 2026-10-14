using System;
using System.Windows.Forms;

namespace Bai1_Service_Charge_Calculator
{    
        internal static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }