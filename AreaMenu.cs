using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsTutor
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Form squareForm = new frmSquare();
            squareForm.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Form circleForm = new frmCircle();
            circleForm.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit2Main_Click(object sender, EventArgs e)
        {

        }
    }
}
