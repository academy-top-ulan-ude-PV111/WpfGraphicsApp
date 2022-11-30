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

namespace WpfGraphicsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Rectangle manual

            //Rectangle rect1 = new();
            //rect1.Width = 300;
            //rect1.Height = 200;
            //rect1.Fill = Brushes.Coral;
            //rect1.Stroke = Brushes.Red;
            //rect1.StrokeThickness = 5;
            //stackPanel.Children.Add(rect1);

            // Path
            //Path path = new();
            //path.Fill = Brushes.LightGreen;
            //path.Stroke = Brushes.DarkGreen;
            //path.StrokeThickness = 5;

            //PathGeometry pathGeometry = new();
            //PathFigure pathFigure = new();
            //pathFigure.StartPoint = new Point(50, 50);
            //pathFigure.IsFilled = true;
            //pathFigure.IsClosed = false;

            //LineSegment line1 = new();
            //line1.Point = new Point(500, 50);
            //LineSegment line2 = new();
            //line2.Point = new Point(350, 200);
            //BezierSegment bezier = new();
            //bezier.Point1 = new Point(350, 350);
            //bezier.Point2 = new Point(200, 100);
            //bezier.Point3 = new Point(150, 200);

            //pathFigure.Segments.Add(line1);
            //pathFigure.Segments.Add(line2);
            //pathFigure.Segments.Add(bezier);

            //pathGeometry.Figures.Add(pathFigure);

            //path.Data = pathGeometry;

            //stackPanel.Children.Add(path);
        }
    }
}
