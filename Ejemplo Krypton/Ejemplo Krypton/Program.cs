﻿using System;
using System.Windows.Forms;

namespace Ejemplo_Krypton
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PISYS());
            //Application.Run(new PISYS());
        }
    }
}
