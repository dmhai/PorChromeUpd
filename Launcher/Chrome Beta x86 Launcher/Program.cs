﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace Chrome_Beta_x86_Launcher
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo culture1 = CultureInfo.CurrentUICulture;
            if (File.Exists(@"Chrome Beta x86\Chrome.exe"))
            {
                if (!File.Exists(@"Chrome Beta x86\Profile.txt"))
                {
                    if (culture1.Name == "de-DE")
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                        String Arguments = File.ReadAllText(@"Chrome Beta x86\Profile.txt");
                        _ = Process.Start(@"Chrome Beta x86\Chrome.exe", Arguments);
                    }
                    else
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form2());
                        String Arguments = File.ReadAllText(@"Chrome Beta x86\Profile.txt");
                        _ = Process.Start(@"Chrome Beta x86\Chrome.exe", Arguments);
                    }
                    }
                else
                {
                    String Arguments = File.ReadAllText(@"Chrome Beta x86\Profile.txt");
                    _ = Process.Start(@"Chrome Beta x86\Chrome.exe", Arguments);
                }
            }
            else if (culture1.Name == "de-DE")
            {
                string message = "Chrome Beta x86 ist nicht installiert";
                _ = MessageBox.Show(message, "Chrome Beta x86 Launcher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string message = "Chrome Beta x86 is not installed";
                _ = MessageBox.Show(message, "Chrome Beta x86 Launcher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
