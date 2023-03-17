using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW11_GDI_
{
    public partial class CreateLine : Form
    {
       public Pen pen;
        public Point Point;
        public Point Point2;
        public CreateLine()
        {
            InitializeComponent();
        }
        public CreateLine(GraphicsCreate g)
        {
            InitializeComponent();
            numericUpDown1.Value = g.point.X;
            numericUpDown2.Value = g.point.Y;
            numericUpDown3.Value = g.point2.X;
            numericUpDown4.Value = g.point2.Y;
            g.pen = pen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            pen = new Pen(colorDialog.Color);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point=new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Point2=new Point((int)numericUpDown3.Value, (int)numericUpDown4.Value);
            this.Close();
        }
    }
}
