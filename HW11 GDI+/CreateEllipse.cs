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
    public partial class CreateEllipseOrRectangle : Form
    {
       public Pen? pen;
        public int x = 0;
        public int y = 0;
        public int width = 0;
        public int height = 0;
        ColorDialog colorDialog = new ColorDialog();
        public CreateEllipseOrRectangle()
        {
            InitializeComponent();
        }
        public CreateEllipseOrRectangle(GraphicsCreate g)
        {
            InitializeComponent();
            numericUpDown1.Value = g.x;
            numericUpDown2.Value = g.y;
            numericUpDown3.Value = g.width;
            numericUpDown4.Value= g.height;
            pen = g.pen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = (int)numericUpDown1.Value;
            y = (int)numericUpDown2.Value;
            width = (int)numericUpDown3.Value;
            height = (int)numericUpDown4.Value;
            pen = new Pen(colorDialog.Color);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }
    }
}
