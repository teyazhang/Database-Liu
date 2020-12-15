﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liu_library
{
    public partial class Head : Form
    {
        public Head()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm1 = new Form2();
            newForm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
