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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pizzaria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool normalPizzaSelected = true;
        BackgroundWorker worker = new BackgroundWorker();
        public MainWindow()
        {
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync(100);
            InitializeComponent();

            //Normal Test Pizzas
            PizzaController.CreatePizza(1, "Margherita", Pizza.PizzaSize.Normal, Pizza.PizzaDough.Wheat,Pizza.PizzaSauce.Tomato, new ObservableCollection<string>{"Tomatosauce","Cheese","Oregano" }, 60);
            PizzaController.CreatePizza(2, "Vesuvio", Pizza.PizzaSize.Normal, Pizza.PizzaDough.Wheat, Pizza.PizzaSauce.Tomato, new ObservableCollection<string> { "Tomatosauce", "Cheese", "Oregano", "Ham"}, 60);
            PizzaController.CreatePizza(3, "Capricciosa", Pizza.PizzaSize.Normal, Pizza.PizzaDough.Wheat, Pizza.PizzaSauce.Tomato, new ObservableCollection<string> { "Tomatosauce", "Cheese", "Oregano", "Ham", "Mushrooms", "Shrimp" }, 70);
           


            icPizzaList.ItemsSource = PizzaController.PizzaList;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int waitTime = (int)e.Argument;
            while (true)
            {
                Thread.Sleep(waitTime);
                ObservableCollection<Pizza> temp = PizzaController.PizzaList;
                App.Current.Dispatcher.Invoke(delegate
                {
                    if (!icPizzaList.ItemsSource.Equals(temp))
                    {
                        icPizzaList.ItemsSource = temp;
                    }
                });

            }
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            if (!normalPizzaSelected)
            {
                foreach (Pizza pizza in PizzaController.PizzaList)
                {
                    PizzaController.UpdatePizza(pizza.PizzaID, Pizza.PizzaSize.Normal, pizza.Price / 2);
                }
                normalPizzaSelected = true;
            }

        }

        private void Familiy_Click(object sender, RoutedEventArgs e)
        {
            if (normalPizzaSelected)
            {
                foreach (Pizza pizza in PizzaController.PizzaList)
                {
                    PizzaController.UpdatePizza(pizza.PizzaID, Pizza.PizzaSize.Familiy, pizza.Price * 2);
                }
                normalPizzaSelected = false;
            }

            
        }
    }
}
