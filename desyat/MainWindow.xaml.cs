using System;
using System.Runtime.InteropServices.Marshalling;
using System.Windows;

namespace GeometryApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SquareArea(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(SquareSideInput.Text, out double side))
            {
                double area = side * side;
                string areaa = Convert.ToString(area);
                ResultOutput.Text = areaa;
            }
            else
            {
                ResultOutput.Text = "не написали данные";
            }
        }

        private void SquarePerimeter(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(SquareSideInput.Text, out double side))
            {
                double perimeter = 4 * side;
                string perimeterr = Convert.ToString(perimeter);
                ResultOutput.Text = perimeterr;
            }
            else
            {
                ResultOutput.Text = "не написали данные";
            }
        }

        private void CircleArea(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(CircleRadiusInput.Text, out double radius))
            {
                double area = Math.PI * radius * radius;
                string areaa = Convert.ToString(area);
                ResultOutput.Text = areaa;
            }
            else
            {
                ResultOutput.Text = "не написали данные";
            }
        }

        private void CirclePerimeter(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(CircleRadiusInput.Text, out double radius))
            {
                double perimeter = 2 * Math.PI * radius;
                string perimeterr = Convert.ToString(perimeter);
                ResultOutput.Text = perimeterr;
            }
            else
            {
                ResultOutput.Text = "не написали данные";
            }
        }
    }
}
