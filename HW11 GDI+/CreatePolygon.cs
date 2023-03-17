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
    public partial class CreatePolygon : Form
    {
       public Pen pen;
       public Point[] points;

        public CreatePolygon()
        {
            InitializeComponent();
        }
        public CreatePolygon(GraphicsCreate g)
        {
            InitializeComponent();
            numericUpDown1.Value = g.points[0].X;
            numericUpDown2.Value = g.points[0].Y;
            numericUpDown3.Value = g.points[1].X;
            numericUpDown4.Value = g.points[1].Y;
            numericUpDown5.Value = g.points[2].X;
            numericUpDown6.Value = g.points[2].Y;
            pen = g.pen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            pen = new Pen(colorDialog.Color);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            points = new Point[] {
                new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value),
                new Point((int)numericUpDown3.Value, (int)numericUpDown4.Value),
                new Point((int)numericUpDown5.Value, (int) numericUpDown6.Value)
            };
            this.Close();
        }
    }
}
