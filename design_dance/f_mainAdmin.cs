﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_dance
{
    public partial class f_mainAdmin : Form
    {
        public f_mainAdmin()
        {
            InitializeComponent();
        }       

        private void b_regist_Click(object sender, EventArgs e)
        {
            f_signup frm = new f_signup();
            frm.Show();
            this.Visible = false;
        }

        private void b_exit_Click_1(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
