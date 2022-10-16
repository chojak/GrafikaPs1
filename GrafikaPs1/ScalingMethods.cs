using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

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
            List<Point> Points = Triangle.Points.ToList();
            Point tmp = new Point();
            Point tmp2 = new Point();

            switch (Direction)
            {
                case Direction.Top:
                    tmp = Triangle.Points[1];
                    Triangle.Points[1] = new Point(tmp.X, tmp.Y - 1);
                    break;

                case Direction.Right:
                    tmp = Triangle.Points[2];
                    Triangle.Points[2] = new Point(tmp.X + 1, tmp.Y);
                    break;

                case Direction.Bottom:
                    tmp = Triangle.Points[0];
                    tmp2 = Triangle.Points[2];

                    Triangle.Points[0] = new Point(tmp.X, tmp.Y + 1);
                    Triangle.Points[2] = new Point(tmp2.X, tmp2.Y + 1);
                    break;
                case Direction.Left:
                    tmp = Triangle.Points[0];
                    Triangle.Points[0] = new Point(tmp.X - 1, tmp.Y);
                    break;

                default:
                    break;
            }
        }
        public static void ElipseScale(Ellipse Ellipse, Canvas Canvas, Direction Direction)
        {
            switch (Direction)
            {
                case Direction.Top:
                    break;

                case Direction.Right:
                    break;

                case Direction.Bottom:
                    break;

                case Direction.Left:
                    break;

                default:
                    break;
            }
        }
    }
}
