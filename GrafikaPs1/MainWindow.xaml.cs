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
    }
}
