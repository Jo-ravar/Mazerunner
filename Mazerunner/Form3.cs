using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mazerunner
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reach to finish without touching the walls....");
            this.Hide();
            
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { if (Program.ct > 1)
            {
                MessageBox.Show("Reach to finish without touching the walls....");
                this.Hide();

                Form4 frm = new Form4();
                frm.Show();
            }
            else {
                MessageBox.Show("Level 2 is locked...!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.ct > 2)
            {
                MessageBox.Show("Reach to finish without touching the walls....");
                this.Hide();

                Form5 frm = new Form5();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Level 3 is locked...!");
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.ct > 3)
            {
                MessageBox.Show("Reach to finish without touching the walls....");
                this.Hide();

                Form6 frm = new Form6();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Level 4 is locked...!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.ct > 4)
            {
                MessageBox.Show("Reach to finish without touching the walls....");
                this.Hide();

                Form6 frm = new Form6();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Level 5 is locked...!");
            }
        }
    }
}
