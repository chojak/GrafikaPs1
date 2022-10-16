using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;

namespace GrafikaPs1
{
    public static class MovingMethods
    {
        public static void QuadrangleMove(Rectangle Rectangle, Canvas Canvas, Direction Direction)
        {
            double x = 0, y = 0;
            switch (Direction)
            {
                case Direction.Top:
                    y = Canvas.GetTop(Rectangle) - 1;
                    Canvas.SetTop(Rectangle, y);
                    break;

                case Direction.Right:
                    x = Canvas.GetLeft(Rectangle) + 1;
                    Canvas.SetLeft(Rectangle, x);
                    break;

                case Direction.Bottom:
                    y = Canvas.GetTop(Rectangle) + 1;
                    Canvas.SetTop(Rectangle, y);
                    break;

                case Direction.Left:
                    x = Canvas.GetLeft(Rectangle) - 1;
                    Canvas.SetLeft(Rectangle, x);
                    break;

                default:
                    break;
            }
        }
        public static void TriangleMove(Polygon Triangle, Canvas Canvas, Direction Direction)
        {
            PointCollection Points = new PointCollection();

            switch (Direction)
            {
                case Direction.Top:
                    Triangle.Points.ToList().ForEach(point =>
                    {
                        point.Y += -1;
                        Points.Add(point);
                    });
                    break;

                case Direction.Right:
                    Triangle.Points.ToList().ForEach(point =>
                    {
                        point.X += 1;
                        Points.Add(point);
                    });
                    break;

                case Direction.Bottom:
                    Triangle.Points.ToList().ForEach(point =>
                    {
                        point.Y += 1;
                        Points.Add(point);
                    });
                    break;

                case Direction.Left:
                    Triangle.Points.ToList().ForEach(point =>
                    {
                        point.X += -1;
                        Points.Add(point);
                    });
                    break;

                default:
                    break;
            }

            Triangle.Points = Points;
        }
        public static void EllipseMove(Ellipse Ellipse, Canvas Canvas, Direction Direction)
        {
            double x = 0, y = 0;
            switch (Direction)
            {
                case Direction.Top:
                    y = Canvas.GetTop(Ellipse) - 1;
                    Canvas.SetTop(Ellipse, y);
                    break;

                case Direction.Right:
                    x = Canvas.GetLeft(Ellipse) + 1;
                    Canvas.SetLeft(Ellipse, x);
                    break;

                case Direction.Bottom:
                    y = Canvas.GetTop(Ellipse) + 1;
                    Canvas.SetTop(Ellipse, y);
                    break;

                case Direction.Left:
                    x = Canvas.GetLeft(Ellipse) - 1;
                    Canvas.SetLeft(Ellipse, x);
                    break;

                default:
                    break;
            }
        }
    }
}
