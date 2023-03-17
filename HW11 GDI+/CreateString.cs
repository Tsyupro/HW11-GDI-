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
    public partial class CreateString : Form
    {
       public Font myFont;
        public SolidBrush myBrush;
        public Point point;
        public string text;
        public CreateString()
        {
            InitializeComponent();
        }
        public CreateString(GraphicsCreate g)
        {
            InitializeComponent();
            numericUpDown1.Value=g.point.X;
            numericUpDown2.Value=g.point.Y;
            textBox1.Text = g.text;
            myFont= g.myFont;
            myBrush= g.myBrush;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowDialog();
            myFont = fontDialog1.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            myBrush = new SolidBrush(colorDialog.Color);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            point=new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            text = textBox1.Text;
            this.Close();
        }
    }
}
