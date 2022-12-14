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
            switch (Direction)
            {
                case Direction.Top:
                    Rectangle.Height++;
                    break;

                case Direction.Right:
                    if (Rectangle.Width > 2)
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
            List<Point> Points = Triangle.Points.ToList();
            Point tmp = new Point();
            Point tmp2 = new Point();
            Point tmp3 = new Point();

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
                    tmp3 = Triangle.Points[1];
                    Triangle.Points[0] = new Point(tmp.X + 1, tmp.Y - 1);
                    Triangle.Points[1] = new Point(tmp3.X, tmp3.Y + 1);
                    Triangle.Points[2] = new Point(tmp2.X - 1, tmp2.Y - 1);
                    break;
                case Direction.Left:
                    tmp = Triangle.Points[0];
                    Triangle.Points[0] = new Point(tmp.X - 1, tmp.Y);
                    break;

            }
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

