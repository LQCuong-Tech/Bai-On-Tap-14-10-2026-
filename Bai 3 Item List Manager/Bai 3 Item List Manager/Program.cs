using System;
using System.Windows.Forms;

namespace Bai_3_Item_List_Manager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Khởi chạy Form1
            Application.Run(new Form1());
        }
    }
}