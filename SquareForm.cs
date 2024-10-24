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
    public partial class frmSquare : Form
    {
        public frmSquare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtLength.Text);

            Square s = new Square("Square: All sides are equal." +
                "\n\nArea = length", length);

            lblDescription.Text = s.getDescription();

            lblArea.Text = "Area = " + length +
                "cm x " + length + "cm = " +
                s.calculateArea() + "cm";
        }
    }
}
