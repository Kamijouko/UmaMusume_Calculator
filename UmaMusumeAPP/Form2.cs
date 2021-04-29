using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmaMusumeAPP
{
    public partial class Form2 : Form
    {
        public Form1 parent;

        public Form2()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = 50;
            int.TryParse(this.textBox1.Text, out a);
            this.parent.TABC = a;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int b = 25;
            int.TryParse(this.textBox2.Text, out b);
            this.parent.TAALLAmax = b;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int c = 20;
            int.TryParse(this.textBox3.Text, out c);
            this.parent.TAALLAmin = c;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int d = 45;
            int.TryParse(this.textBox4.Text, out d);
            this.parent.TBCmax = d;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int f = 40;
            int.TryParse(this.textBox5.Text, out f);
            this.parent.TBCmin = f;
        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "50";
            
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "25";
            
        }

        private void Reset3_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "20";
            
        }

        private void Reset4_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "45";
            
        }

        private void Reset5_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = "40";
        }
    }
}
