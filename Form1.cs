using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jerime
{
    public partial class Form1 : Form
    {
        int jemi = 0;
                public Form1() {
            InitializeComponent(); }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int setir=comboBox1.SelectedIndex;

            if (setir==0) textBox3.Text="21";
            if (setir==1) textBox3.Text="10";
            if (setir==2)  textBox3.Text="20";
            if (setir==3)  textBox3.Text="15";
            if (setir==4)  textBox3.Text="30";
        }
                private void button1_Click(object sender, EventArgs e)
        {
            string fa = textBox1.Text;
            string pb = textBox2.Text;
            string jg = comboBox1.SelectedItem.ToString();
            int pm = int.Parse(textBox3.Text);
            dataGridView1.Rows.Add(fa, pb, jg, pm);
            jemi = jemi + pm;
            label6.Text = "Jemi:" + jemi;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
