using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace GrafikaPs1
{
    public static class ScalingMethods
    {
        public static void QuadrangleScale(Rectangle Rectangle, Canvas Canvas, Direction Direction)
        {
            double x = 0, y = 0;
            switch (Direction)
            {
                case Direction.Top:
                    y = Canvas.GetTop(Rectangle) - 1;
                    Rectangle.Height++;
                    Canvas.SetTop(Rectangle, y);
                    break;

                case Direction.Right:
                    Rectangle.Width++;
                    break;

                case Direction.Bottom:
                    Rectangle.Height++;
                    break;

                case Direction.Left:
                    x = Canvas.GetLeft(Rectangle) - 1;
                    Rectangle.Width++;
                    Canvas.SetLeft(Rectangle, x);
                    break;

                default:
                    break;
            }
        }
        public static void TriangleScale(Polygon Triangle, Canvas Canvas, Direction Direction)
        {

        }
        public static void ElipseScale()
        {

        }
    }
}
