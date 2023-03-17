using System.Drawing;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace HW11_GDI_
{
    public partial class Form1 : Form
    {
        List<GraphicsCreate> graphicsInfos = new List<GraphicsCreate>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            foreach (GraphicsCreate graphics in graphicsInfos)
            {
                graphics.Draw();
            }

            //else if (radioButton3.Checked)
            //{
            //    Pen pen = new Pen(Color.Black);
            //    Point[] points = new Point[]
            //    {
            //     new Point(50, 50),
            //     new Point(100, 100),
            //     new Point(0, 100)
            //    };

            //    g.DrawPolygon(pen, points);
            //}
            //else if (radioButton4.Checked)
            //{
            //    Font myFont = new Font("Arial", 12, FontStyle.Bold);
            //    SolidBrush myBrush = new SolidBrush(Color.Black);
            //    g.DrawString("Hello, World!", myFont, myBrush, new PointF(10, 10));

            //}
            //else if (radioButton5.Checked)
            //{
            //    Pen myPen = new Pen(Color.Black, 2);

            //    g.DrawLine(myPen, new Point(10, 10), new Point(50, 50));
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton1.Checked)
            {
                GraphicsCreate info = new GraphicsCreate(1, pictureBox1.CreateGraphics(), "Ellipse");
                graphicsInfos.Add(info);
            }
            else if (radioButton2.Checked)
            {
                GraphicsCreate info = new GraphicsCreate(2, pictureBox1.CreateGraphics(), "Rectangle");
                graphicsInfos.Add(info);
            }
            else if (radioButton3.Checked)
            {
                GraphicsCreate info = new GraphicsCreate(3, pictureBox1.CreateGraphics(), "Polygon");
                graphicsInfos.Add(info);
            }
            else if (radioButton4.Checked)
            {
                GraphicsCreate info = new GraphicsCreate(4, pictureBox1.CreateGraphics(), "String");
                graphicsInfos.Add(info);
            }
            else if (radioButton5.Checked)
            {
                GraphicsCreate info = new GraphicsCreate(5, pictureBox1.CreateGraphics(), "Line");
                graphicsInfos.Add(info);
            }

            foreach (GraphicsCreate graphics in graphicsInfos)
            {
                listBox1.Items.Add(graphics);
            }




            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            GraphicsCreate graphics=(GraphicsCreate)listBox1.SelectedItem;
            if(graphics.index ==1)
            {
                CreateEllipseOrRectangle g = new CreateEllipseOrRectangle(graphics);
                g.ShowDialog();
                graphics.pen = g.pen; graphics.x = g.x; graphics.y = g.y; graphics.width = g.width; graphics.width = g.height;
                graphicsInfos[listBox1.SelectedIndex] = graphics;
            }
            else if(graphics.index ==2)
            {
                CreateEllipseOrRectangle g = new CreateEllipseOrRectangle(graphics);
                g.ShowDialog();
                graphics.pen = g.pen; graphics.x = g.x; graphics.y = g.y; graphics.width = g.width; graphics.width = g.height;
                graphicsInfos[listBox1.SelectedIndex] = graphics;
            }
            else if (graphics.index == 3)
            {
                CreatePolygon create = new CreatePolygon(graphics);
                create.ShowDialog();
                graphics.pen = create.pen; graphics.points = create.points;
                graphicsInfos[listBox1.SelectedIndex] = graphics;
            }
            else if (graphics.index == 4)
            {
                CreateString create = new CreateString(graphics);
                create.ShowDialog();
                graphics.myFont = create.myFont; graphics.myBrush = create.myBrush; graphics.text = create.text; graphics.point = create.point;
                graphicsInfos[listBox1.SelectedIndex] = graphics;
            }
            else if (graphics.index == 5)
            {
                CreateLine create = new CreateLine();
                create.ShowDialog();
                graphics.pen = create.pen; graphics.point = create.Point; graphics.point2 = create.Point2;
                graphicsInfos[listBox1.SelectedIndex] = graphics;
            }
            pictureBox1.Refresh();
            this.Invalidate();
        }
    }
}