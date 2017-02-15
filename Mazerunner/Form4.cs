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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Movetostart();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void Movetostart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void Finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Well Done.!     Keep Moving forward");
            Program.ct = 3;
        }

        private void Wall_mouseEnter(object sender, EventArgs e)
        {
            Movetostart();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
