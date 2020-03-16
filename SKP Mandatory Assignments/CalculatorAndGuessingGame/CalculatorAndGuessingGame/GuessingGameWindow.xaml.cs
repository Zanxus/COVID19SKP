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
using System.Windows.Shapes;

namespace CalculatorAndGuessingGame
{
    /// <summary>
    /// Interaction logic for GuessingGameWindow.xaml
    /// </summary>
    public partial class GuessingGameWindow : Window
    {

        int numberToGuess;
        public int Guesses { get; set; }
        public GuessingGameWindow()
        {
            //Initializes the number needed to be guessed aswell as number of tries
            Guesses = 3;
            Random random = new Random();
            numberToGuess = random.Next(0, 10);
            InitializeComponent();
        }

        //Adds Return fuctionality to the GuessingGameWindow
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        //Handels the Guess logic
        private void Button_Guess(object sender, RoutedEventArgs e)
        {
            if(Guesses == 0)
            {
                
            }
            if(int.TryParse(GuessInput.Text,out int input) && Guesses > 0)
            {
                Guesses--;
                OutputText.Content = (numberToGuess > input) ? "Higher" : (numberToGuess < input) ? "Lower" : "Correct";
            }
        }
    }
}
