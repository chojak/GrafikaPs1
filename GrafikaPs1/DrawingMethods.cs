﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GrafikaPs1
{
    public static class DrawingMethods
    {
        public static void FreehandDraw(System.Windows.Point LastPoint, System.Windows.Point CurrentPoint, System.Windows.Media.Color Color, Canvas Canvas)
        {
            Line line = new Line();

            line.Stroke = new SolidColorBrush(Color);
            line.X1 = CurrentPoint.X;
            line.Y1 = CurrentPoint.Y;
            line.X2 = LastPoint.X;
            line.Y2 = LastPoint.Y;

            Canvas.Children.Add(line);
        }
        public static void LineDraw(System.Windows.Point BasePoint, System.Windows.Point CurrentPoint, System.Windows.Media.Color Color, System.Windows.Shapes.Line Line, Canvas Canvas)
        {
            Line.X1= BasePoint.X;
            Line.Y1= BasePoint.Y;
            Line.X2= CurrentPoint.X;
            Line.Y2= CurrentPoint.Y;
        }
        public static void QuadrangleDraw(System.Windows.Point BasePoint, System.Windows.Point CurrentPoint, System.Windows.Media.Color Color, System.Windows.Shapes.Rectangle Rectangle, Canvas Canvas)
        {
            if (CurrentPoint.X - BasePoint.X >= 0)
            {
                Rectangle.Width = CurrentPoint.X - BasePoint.X;
            }
            else
            {
                Canvas.SetLeft(Rectangle, CurrentPoint.X);
                Rectangle.Width = BasePoint.X - CurrentPoint.X;
            }

            if (CurrentPoint.Y - BasePoint.Y >= 0)
            {
                Rectangle.Height = CurrentPoint.Y - BasePoint.Y;
            }
            else
            {
                Canvas.SetTop(Rectangle, CurrentPoint.Y);
                Rectangle.Height = BasePoint.Y - CurrentPoint.Y;
            }
        }

        public static void EllipseDraw(System.Windows.Point BasePoint, System.Windows.Point CurrentPoint, System.Windows.Media.Color Color, System.Windows.Shapes.Ellipse Ellipse
            , Canvas Canvas)
        {
            if (CurrentPoint.X - BasePoint.X >= 0)
            {
                Ellipse.Width = CurrentPoint.X - BasePoint.X;
            }
            else
            {
                Canvas.SetLeft(Ellipse, CurrentPoint.X);
                Ellipse.Width = BasePoint.X - CurrentPoint.X;
            }

            if (CurrentPoint.Y - BasePoint.Y >= 0)
            {
                Ellipse.Height = CurrentPoint.Y - BasePoint.Y;
            }
            else
            {
                Canvas.SetTop(Ellipse, CurrentPoint.Y);
                Ellipse.Height = BasePoint.Y - CurrentPoint.Y;
            }
        }
    }
}
