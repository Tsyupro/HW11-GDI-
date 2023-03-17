using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_GDI_
{
    public class GraphicsCreate
    {
      public int index=0;
       public string name;
        public Pen? pen;
        public int x = 0;
        public int y = 0;
        public int width = 0;
        public int height = 0;
        public Rectangle rect;
        public Point[] points;
        public Point point;
        public Point point2;
        public Font myFont;
        public SolidBrush myBrush;
        public Graphics g;
        public string text;
        CreateEllipseOrRectangle create = new CreateEllipseOrRectangle();

        public GraphicsCreate(int index, Graphics _g, string _name)
        {
            g = _g;
            name = _name;
            this.index= index;
            if (index == 1)
            {             
                create.ShowDialog();
                pen = create.pen; x = create.x; y = create.y; width = create.width; height = create.height;
            }
           else if(index == 2)
            {
                create.ShowDialog();
                pen = create.pen; x = create.x; y = create.y; width = create.width; height = create.height;
                rect = new Rectangle(x, y, width, height);

            }
            else if(index==3)
            {
                CreatePolygon create = new CreatePolygon();
                create.ShowDialog();
                pen = create.pen; points= create.points;
            }
            else if( index == 4)
            {
                CreateString create = new CreateString();
                create.ShowDialog();
                myFont=create.myFont; myBrush=create.myBrush; text=create.text; point=create.point;
            }
            else if (index == 5)
            {
                CreateLine create = new CreateLine();
                create.ShowDialog();
                pen = create.pen; point = create.Point; point2 = create.Point2;
            }

            
        }
        public void Draw()
        {
            if (index == 1)
            {
                g.DrawEllipse(pen, x, y, width, height);
            }
            else if(index == 2)
            {
                g.DrawRectangle(pen, rect);
            }
            else if(index == 3)
            {
                g.DrawPolygon(pen,points);
            }
            else if (index == 4)
            {
                g.DrawString(text,myFont,myBrush,point);
            }
            else if (index == 5)
            {
                g.DrawLine(pen, point, point2);
            }

        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
