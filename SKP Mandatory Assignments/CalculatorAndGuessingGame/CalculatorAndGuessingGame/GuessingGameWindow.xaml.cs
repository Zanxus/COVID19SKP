using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    
    //Uses INotifyPropertyChanged fire and event when a propertychanges
    public partial class GuessingGameWindow : Window, INotifyPropertyChanged
    {
        Random random = new Random();

        int numberToGuess;
        //The Event that gets fired
        private int guesses;
        //Uses OnPropertyChanged() to change data with the 
        public int Guesses
        {
            get { return guesses; }
            set { guesses = value;
                OnPropertyChanged();
            }
        }
        public int Wins { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public List<int> HighscoreTableContent { get; set; }

        public GuessingGameWindow()
        {
            //Initializes the number needed to be guessed aswell as number of tries
            Wins = 0;
            Guesses = 3;
            numberToGuess = random.Next(0, 10);

            InitializeComponent();
            GuessAmountLabel.DataContext = this;
        }

        //Adds Return fuctionality to the GuessingGameWindow
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            OpenWindow(new MainWindow());
        }

        //Handels the Guess logic
        private void Button_Guess(object sender, RoutedEventArgs e)
        {
            GameLogic();
        }

        //Updates the value
        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("guesses"));
        }


        //Contain the main GuessingGame Logic
        private void GameLogic()
        {
            if (int.TryParse(GuessInput.Text, out int input) && Guesses > 0)
            {
                Guesses--;
                OutputText.Content = (numberToGuess > input) ? "Higher" : (numberToGuess < input) ? "Lower" : "Correct";
                if ((string)OutputText.Content == "Correct")
                {
                    Wins++;
                    Guesses += 3;
                    numberToGuess = random.Next(0, 10);
                }
            }
            if (Guesses == 0)
            {
                OutputText.Content = $"You Ran out of guesses and guessed {Wins} numbers correctly";
                numberToGuess = random.Next(0, 10);
                Guesses = 3;

            }
        }

        //Small method to open and close windows
        private void OpenWindow(Window window)
        {
            Close();
            window.Show();
        }
    }
}
