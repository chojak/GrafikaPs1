using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GrafikaPs1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public enum DrawingMode
    {
        Line,
        Freehand,
        Triangle,
        Quatrangle,
        Elipse
    }
    public partial class MainWindow : Window
    {
        public static DrawingMode DrawingMode;
        public static Color Color;
        public static Point CurrentPoint;

        public static Point CurrentQuatrangleBasePoint;
        public static Rectangle CurrentQuatrangle;

        public static Point CurrentLineBasePoint;
        public static Line CurrentLine;

        public static Point CurrentEllipseBasePoint;
        public static Ellipse CurrentEllipse;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("click");
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                CurrentPoint.X = e.GetPosition(this).X;
                CurrentPoint.Y = e.GetPosition(this).Y - MainGrid.RowDefinitions[0].ActualHeight;

                if (DrawingMode == DrawingMode.Line)
                {
                    CurrentLine = new Line();
                    CurrentLineBasePoint = CurrentPoint;

                    CurrentLine.Stroke = new SolidColorBrush(Color);
                    CurrentLine.StrokeThickness = 2;
                    Canvas.Children.Add(CurrentLine);
                   
                }
                
                if (DrawingMode == DrawingMode.Quatrangle)
                {
                    CurrentQuatrangle = new Rectangle();
                    CurrentQuatrangleBasePoint = CurrentPoint;

                    CurrentQuatrangle.Stroke = CurrentQuatrangle.Fill = new SolidColorBrush(Color);
                    CurrentQuatrangle.Height = CurrentQuatrangle.Width = 1;
                    
                    Canvas.Children.Add(CurrentQuatrangle);
                    Canvas.SetTop(CurrentQuatrangle, CurrentPoint.Y);
                    Canvas.SetLeft(CurrentQuatrangle, CurrentPoint.X);
                }

                if(DrawingMode == DrawingMode.Elipse)
                {
                    CurrentEllipse = new Ellipse();
                    CurrentEllipseBasePoint = CurrentPoint;

                    CurrentEllipse.Stroke = CurrentEllipse.Fill = new SolidColorBrush(Color);
                    CurrentEllipse.Height = CurrentEllipse.Width = 1;

                    Canvas.Children.Add(CurrentEllipse);
                    Canvas.SetTop(CurrentEllipse, CurrentPoint.Y);
                    Canvas.SetLeft(CurrentEllipse, CurrentPoint.X);
                }
            }
        }

        protected void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("move");
            Point LastPoint;

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                LastPoint = CurrentPoint;
                CurrentPoint.X = e.GetPosition(this).X;
                CurrentPoint.Y = e.GetPosition(this).Y - MainGrid.RowDefinitions[0].ActualHeight;
                
                if (DrawingMode == DrawingMode.Freehand)
                {
                    DrawingMethods.FreehandDraw(LastPoint, CurrentPoint, Color, Canvas);
                }

                if (DrawingMode == DrawingMode.Line)
                {
                    DrawingMethods.LineDraw(CurrentLineBasePoint, CurrentPoint, Color, CurrentLine, Canvas);
                }

                if (DrawingMode == DrawingMode.Quatrangle)
                {
                    DrawingMethods.QuadrangleDraw(CurrentQuatrangleBasePoint, CurrentPoint, Color, CurrentQuatrangle, Canvas);
                }

                if (DrawingMode == DrawingMode.Elipse)
                {
                    DrawingMethods.EllipseDraw(CurrentEllipseBasePoint, CurrentPoint, Color, CurrentEllipse, Canvas);
                }
            }
        }

        protected void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            Color = (Color)ColorPicker.SelectedColor;
        }

        private void LineToggle_Checked(object sender, RoutedEventArgs e)
        {
            DrawingMode = DrawingMode.Line;
        }

        private void FreehandToggle_Checked(object sender, RoutedEventArgs e)
        {
            DrawingMode = DrawingMode.Freehand;
        }

        private void TriangleToggle_Checked(object sender, RoutedEventArgs e)
        {
            DrawingMode = DrawingMode.Triangle;
        }

        private void QuadrangleToggle_Checked(object sender, RoutedEventArgs e)
        {
            DrawingMode = DrawingMode.Quatrangle;
        }

        private void ElipseToggle_Checked(object sender, RoutedEventArgs e)
        {
            DrawingMode = DrawingMode.Elipse;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextToggle_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
