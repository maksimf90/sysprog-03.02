﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysprog_03._02
{
    public partial class Form2 : Form
    {
        private string login;

        public Form2(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_login.Text = login;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(login);
            form3.Show();
        }
    }
}
