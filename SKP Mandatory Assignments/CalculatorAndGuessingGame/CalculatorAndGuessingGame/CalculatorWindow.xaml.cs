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

        bool Expanded = false;
        bool FigureExpanded = false;
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
                temp = temp.Replace(',', '.');
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
                    ShowFigure(Expanded);
                    if (ShapeComboBox.SelectedItem != null)
                    {
                        SetupCanvas(ShapeComboBox.SelectedItem.ToString());
                    }
                });
            }
        }
        //Clears the Screen
        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            Width = (!FigureExpanded) ? (Width / 2) * 3 : (Width * 2) / 3;
            FigureExpanded = !FigureExpanded;

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

        //Calls method responseable for making the shapes depending on a given string
        private void SetupCanvas(string layoutstring)
        {
            switch (layoutstring)
            {
                case "Circle":
                    break;
                case "Traoezoid":
                    break;
                case "Cone":
                    break;
                case "Polygone":
                    break;
                case "Square":
                    Rectangle();
                    break;
                default:
                    break;
            }

        }

        //Calls the apropriate methods to make a Rectangle
        private void Rectangle()
        {
            AddShape(ConstructShape(new Rectangle()));
        }
        //Makes a given shape depending on the perameter (Limited to Square for now)
        private Shape ConstructShape(Shape shape)
        {
            Square square = (Square)SetupFrame.Content;

            double width;
            double height;
            int scale;
            //Checks input for only numbers
            if (double.TryParse(square.WidthBox.Text, out width) && double.TryParse(square.LengthBox.Text, out height))
            {
                if (square.WidthBox.Text != "" && square.LengthBox.Text != "")
                {
                    ShapeStyle(shape);
                    shape.Width = width;
                    shape.Height = height;

                    if (shape.Width > 100 || shape.Height > 100)
                    {
                        scale = (shape.Width > shape.Height) ? (int)shape.Width / 100 : (int)shape.Height / 100;

                        shape.Width = shape.Width / scale;
                        shape.Height = shape.Height / scale;
                    }
                }
            }
            return shape;
        }

        //Adds the Given shape to the Canvas and centers it
        private void AddShape(Shape shape)
        {
            FigureCanvas.Children.Clear();
            FigureCanvas.Children.Add(shape);
            Canvas.SetLeft(shape, ((FigureCanvas.Width / 2) - (shape.Width / 2)));
            Canvas.SetTop(shape, ((FigureCanvas.Height / 2) - (shape.Height / 2)));
        }
        
        //Sets the Drawing Style of the Shape
        private void ShapeStyle(Shape shape)
        {
            shape.StrokeThickness = 1;
            shape.Stroke = Brushes.Black;
            shape.Fill = Brushes.White;
        }

        private void ShowFigure(bool expanded)
        {
            if (expanded == true)
            {
                ShowButton.Visibility = Visibility.Visible;
            }
        }
    }
}
