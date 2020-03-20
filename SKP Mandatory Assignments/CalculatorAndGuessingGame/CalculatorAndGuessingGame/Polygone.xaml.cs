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

namespace CalculatorAndGuessingGame
{
    /// <summary>
    /// Interaction logic for Polygone.xaml
    /// </summary>
    public partial class Polygone : Page
    {
        List<Vector> points = new List<Vector>();
        public Polygone()
        {
            InitializeComponent();
        }

        //prints out Area calculation
        private void Calc_Button_Click(object sender, RoutedEventArgs e)
        {
            if (points.Count > 0)
            {
               AreaBox.Text = CalculateArea().ToString();
            }
        }

        //adds a 2D point to a list
        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(YBox.Text, out double Y) && double.TryParse(XBox.Text, out double X))
            {
                if (YBox.Text != "" && XBox.Text != "")
                {
                    points.Add(new Vector(X, Y));
                }
            }
        }
        //calculates the area of a given polygone
        private double CalculateArea()
        {
            double area = 0;

            int j = points.Count - 1;
            for (int i = 0; i < points.Count; i++)
            {
                area += (points[j].X + points[i].X) * (points[j].Y - points[i].Y);
                j = i;
            }

            return area/2;
        }

        //Clears the points List
        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            points.RemoveAll(x => x == x);
        }
        //Removes that latest input incase of user input error
        private void Undo_Button_Click(object sender, RoutedEventArgs e)
        {
            points.Remove(points.FindLast(x => x == x));
        }
    }
}
