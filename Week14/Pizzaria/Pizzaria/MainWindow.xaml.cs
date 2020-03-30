using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Pizzaria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PizzaController.CreatePizza(0, "Margherita", Pizza.PizzaSize.Normal, new ObservableCollection<string>{"Tomatosauce","Cheese","Oregano" }, 60);
            PizzaController.CreatePizza(1, "Vesuvio", Pizza.PizzaSize.Normal, new ObservableCollection<string> { "Tomatosauce", "Cheese", "Oregano", "Ham"}, 60);
            PizzaController.CreatePizza(2, "Capricciosa", Pizza.PizzaSize.Normal, new ObservableCollection<string> { "Tomatosauce", "Cheese", "Oregano", "Ham", "Mushrooms", "Shrimp" }, 70);

            icPizzaList.ItemsSource = PizzaController.PizzaList;
        }
    }
}
