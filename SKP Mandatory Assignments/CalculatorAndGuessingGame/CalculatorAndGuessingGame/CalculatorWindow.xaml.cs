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
using System.Data;

namespace CalculatorAndGuessingGame
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        BackgroundWorker worker = new BackgroundWorker();
        StringBuilder sb = new StringBuilder();
        string[] shapes = { "Circle", "Square", "Traoezoid", "Cone", "Polygone" };
        
        enum Shapes
        {
            Circle,Square,Traoezoid,Cone,Polygone
        }

        bool Expanded = false;
        public CalculatorWindow()
        {

            worker.DoWork += BackgroundWorker_DoWork;
            worker.RunWorkerAsync(100);

            InitializeComponent();
            ShapeComboBox.ItemsSource = shapes;
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

        //Expands the UI to make space for Area calculators
        private void Expand_Button_Click(object sender, RoutedEventArgs e)
        {
            Width = (!Expanded) ? Width * 2 : Width / 2;
            Expanded = !Expanded;
        }

        //Finds the content of pressed button and adds it to the string
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)e.Source;
            sb.Append(b.Content);

        }
        //adds the stringbuilder's string to a datatable if !Empty and uses datatables in build compute to handle calculations
        private void Eval_Button_Click(object sender, RoutedEventArgs e)
        {
            string temp = "";
            DataTable table = new DataTable();
            if(sb.ToString() != "")
            {
                temp = Convert.ToDouble(table.Compute(sb.ToString(), String.Empty)).ToString();
            }

            sb.Clear();
            sb.Append(temp);
        }

        //Updates the input Screen of the calculator
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
        //Clears the Screen
        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
        }
        //uses a comboBox to pass a string to setup method.
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)e.Source;
            Setup(cb.SelectedItem.ToString());
        }

        //Creates a page and navigate to it using the layoutstring.
        private void Setup(string layoutstring)
        {
            switch (layoutstring)
            {
                case "Circle":
                    SetupFrame.Navigate(new Circle());
                    break;
                case "Traoezoid":
                    SetupFrame.Navigate(new Traoezoid());
                    break;
                case "Cone":
                    SetupFrame.Navigate(new Cone());
                    break;
                case "Polygone":
                    SetupFrame.Navigate(new Polygone());
                    break;
                case "Square":
                    SetupFrame.Navigate(new Square());
                    break;
                default:
                    break;
            }

        }

        
        
        
    }

}
