﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace coursework
{
    class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        
        }
}
