﻿using System;
using System.Windows.Forms;

namespace Chrome_Canary_x86_Launcher
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked)
            {
                System.IO.File.WriteAllText(@"Chrome Canary x86\Profile.txt", "--user-data-dir=\"profile\"");
                this.Close();
            }
            if (radioButton2.Checked)
            {
                System.IO.File.WriteAllText(@"Chrome Canary x86\Profile.txt", "--user-data-dir=\"Chrome Canary x86\\profile\"");
                this.Close();
            }
            if (radioButton3.Checked)
            {
                System.IO.File.WriteAllText(@"Chrome Canary x86\Profile.txt", "");
                this.Close();
            }
        }
    }
}
