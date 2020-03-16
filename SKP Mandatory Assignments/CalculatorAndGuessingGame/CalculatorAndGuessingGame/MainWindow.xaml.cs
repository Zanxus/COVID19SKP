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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Launches the GuessingGame Window
        private void Button_Guessing_Game (object sender, RoutedEventArgs e)
        {
            GuessingGameWindow guessingGameWindow = new GuessingGameWindow();
            guessingGameWindow.Show();
            this.Close();

        }
        //Launches The Calculator Window
        private void Button_Calculator(object sender, RoutedEventArgs e)
        {
            CalculatorWindow guessingGame = new CalculatorWindow();
            guessingGame.Show();
            this.Close();
        }

    }
}
