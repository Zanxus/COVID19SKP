using System;
using System.Collections.Generic;
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
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        BackgroundWorker worker = new BackgroundWorker();
        StringBuilder sb = new StringBuilder();
        public CalculatorWindow()
        {
            worker.DoWork += BackgroundWorker_DoWork;
            worker.RunWorkerAsync(100);

            InitializeComponent();
            DataContext = this;
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
        
        //Finds the content of pressed button and adds it to the string
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)e.Source;
            sb.Append(b.Content);

        }

        private void Eval_Button_Click(object sender, RoutedEventArgs e)
        {
            string temp = "";
            System.Data.DataTable table = new System.Data.DataTable();
            if(sb.ToString() != "")
            {
                temp = Convert.ToDouble(table.Compute(sb.ToString(), String.Empty)).ToString();
            }

            sb.Clear();
            sb.Append(temp);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int waitTime = (int)e.Argument;
            while (true)
            {
                Thread.Sleep(waitTime);
                App.Current.Dispatcher.Invoke(delegate
                {
                    Screen.Text = sb.ToString();
                    
                });

            }
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
        }
    }

}
