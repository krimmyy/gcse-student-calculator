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
    public partial class frmCircle : Form
    {
        public frmCircle()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);

            Circle c = new Circle("Circle: Area = A = πr2");

            c.setDimension1(radius);

            lblDescription.Text = c.getDescription();

            lblArea.Text = "Area = 3.14 x " + radius + "cm x " + radius + "cm = " + c.calculateArea() + "cm";

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
