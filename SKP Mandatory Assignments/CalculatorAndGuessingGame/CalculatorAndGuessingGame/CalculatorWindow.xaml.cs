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
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        StringBuilder sb = new StringBuilder();
        public CalculatorWindow()
        {
            InitializeComponent();
        }

        //Adds Return fuctionality to the ClaculatorWindow
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            OpenWindow(new MainWindow());
        }

        private void OpenWindow(Window window)
        {
            Close();
            window.Show();
        }
        Eval
        //Takes a string and splits it into more parts
        private List<string> StringSpliter(string mathString)
        {
            return new List<string>();
        }
        //Turns a string into "Mathable functions"
        private void StringEval(string mathString)
        {

        }
    }

}
