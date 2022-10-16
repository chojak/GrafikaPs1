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
            switch (Direction)
            {
                case Direction.Top:
                    Rectangle.Height++;
                    break;

                case Direction.Right:
                    if(Rectangle.Width > 2)
                        Rectangle.Width--;
                    break;

                case Direction.Bottom:
                    
                    if (Rectangle.Height > 2)
                        Rectangle.Height--;
                    break;

                case Direction.Left:
                    Rectangle.Width++;
                    break;

                default:
                    break;
            }
        }
        public static void TriangleScale(Polygon Triangle, Canvas Canvas, Direction Direction)
        {

        }
        public static void EllipseScale(Ellipse Ellipse, Canvas Canvas, Direction Direction)
        {
            switch (Direction)
            {
                case Direction.Top:
                    Ellipse.Height++;
                    break;

                case Direction.Right:
                    if (Ellipse.Width > 2)
                        Ellipse.Width--;
                    break;

                case Direction.Bottom:
                    if (Ellipse.Height > 2) 
                        Ellipse.Height--;
                    break;

                case Direction.Left:
                    Ellipse.Width++;
                    break;

                default:
                    break;
            }
        }
    }
}
