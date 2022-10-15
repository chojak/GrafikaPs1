using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
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
    }
}
