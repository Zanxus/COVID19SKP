using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
        BackgroundWorker worker = new BackgroundWorker();

        int numberToGuess;

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
        //The Event that gets fired
        public event PropertyChangedEventHandler PropertyChanged;
        public static ObservableCollection<Hiscore> HighscoreTableContent = new ObservableCollection<Hiscore>();

        public GuessingGameWindow()
        {
            //Initializes the number needed to be guessed aswell as number of tries
            
            Wins = 0;
            Guesses = 3;
            numberToGuess = random.Next(0, 10);

            InitializeComponent();

            worker.DoWork += BackgroundWorker_DoWork;
            worker.RunWorkerAsync(1000);

            HiscoreListVeiw.ItemsSource = HighscoreTableContent;
            GuessAmountLabel.DataContext = this;
            HighscoreTableContent = JSONHandler.Importer();
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
            if (int.TryParse(GuessInput.Text, out int input) && Guesses > 0 && input <= 10 && input >= 0)
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
                AddHiscore();
                OutputText.Content = $"You Ran out of guesses and guessed {Wins} numbers correctly";
                numberToGuess = random.Next(0, 10);
                Guesses = 3;
                Wins = 0;

            }
        }

        //Small method to open and close windows
        private void OpenWindow(Window window)
        {
            Close();
            window.Show();
        }

        //Updates the Hiscore every x milliseconds
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int waitTime = (int)e.Argument;
            while (true)
            {
                Thread.Sleep(waitTime);
                ObservableCollection<Hiscore> temp = JSONHandler.Importer();
                App.Current.Dispatcher.Invoke(delegate
                {
                    if (!HiscoreListVeiw.ItemsSource.Equals(temp))
                    {
                        HiscoreListVeiw.ItemsSource = temp;
                        JSONHandler.Exporter(HighscoreTableContent);
                    }
                });

            }
        }
        private void AddHiscore()
        {
            if (!HiscoreName.Text.Equals(""))
            {
                HighscoreTableContent.Add(new Hiscore(HiscoreName.Text, Wins));
            }
        }
    }
}
