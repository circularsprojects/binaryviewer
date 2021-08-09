using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaryviewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void update()
        {
            int number = 0;
            if (checkBox8.Checked) { number += 1; }
            if (checkBox7.Checked) { number += 2; }
            if (checkBox6.Checked) { number += 4; }
            if (checkBox5.Checked) { number += 8; }
            if (checkBox4.Checked) { number += 16; }
            if (checkBox3.Checked) { number += 32; }
            if (checkBox2.Checked) { number += 64; }
            if (checkBox1.Checked) { number += 128; }
            label9.Text = "Integer: " + number + "\nASCII: " + (char)number;
        }

        #region redirects
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        #endregion
    }
}
