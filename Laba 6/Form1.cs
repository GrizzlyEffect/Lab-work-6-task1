using static Laba_6.Class1;
using System.Windows.Forms;
using System;

namespace Laba_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcParal_Click(object sender, EventArgs e)
        {
            double baseA = double.Parse(ParalBase.Text);
            double heightH = double.Parse(ParalHeight.Text);

            Shape shape = new Parallelogram(baseA, heightH);
            DisplayArea(shape, lbResultParal);
        }

        private void btnCalcTrapez_Click(object sender, EventArgs e)
        {
            double base1 = double.Parse(TrapBase1.Text);
            double base2 = double.Parse(TrapBase2.Text);
            double height = double.Parse(TrapHeight.Text);

            Shape shape = new Trapezium(base1, base2, height);
            DisplayArea(shape, lbResultTrapez);
        }

        private void DisplayArea(Shape shape, Label label)
        {
            label.Text = shape.GetArea().ToString();
        }
    }
}
