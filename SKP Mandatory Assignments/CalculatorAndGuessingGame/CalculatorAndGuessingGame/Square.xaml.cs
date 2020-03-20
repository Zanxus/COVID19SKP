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
    /// Interaction logic for Square.xaml
    /// </summary>
    public partial class Square : Page
    {
        public Square()
        {
            InitializeComponent();
        }

        //calculates the Area and checks the input
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(LengthBox.Text, out double length) && double.TryParse(WidthBox.Text, out double width)) {
                if (LengthBox.Text != "" || WidthBox.Text != "")
                {
                    AreaBox.Text = (length*width).ToString();
                }
            } 
        }
    }
}
