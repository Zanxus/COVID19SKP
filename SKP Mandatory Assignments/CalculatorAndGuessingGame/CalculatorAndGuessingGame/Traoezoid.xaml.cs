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
    /// Interaction logic for Traoezoid.xaml
    /// </summary>
    public partial class Traoezoid : Page
    {
        public Traoezoid()
        {
            InitializeComponent();
        }


        //Method to check the area and input check
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(BottomBox.Text, out double buttom) && double.TryParse(HeightBox.Text, out double height) && double.TryParse(TopLength.Text, out double topLength))
            {
                if (BottomBox.Text != "" || HeightBox.Text != "" || TopLength.Text != "")
                {
                    AreaBox.Text = (((buttom + topLength) / 2) * height).ToString();
                }
            }
        }
    }
}
