using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.@in;

namespace Warehouse.@in
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
<<<<<<< HEAD
            Application.Run(new formLogin());
=======
            Application.Run(new FormSignup());
>>>>>>> 788d37970c2d8bd2f8aa7b9e667db3de7f0ee6a9
        }
    }
}