﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1810
{
    public partial class Form2 : Form
    {
        Form3 form3;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Owner = this;
            form3.Show();
            form3.label3.Text= textBox1.Text;
            form3.label4.Text = textBox2.Text;
            form3.label7.Text = textBox3.Text;
            form3.label8.Text = textBox4.Text;
            
        }
    }
}
