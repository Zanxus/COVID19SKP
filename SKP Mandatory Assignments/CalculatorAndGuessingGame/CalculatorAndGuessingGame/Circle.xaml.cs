﻿using System;
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
    /// Interaction logic for Circle.xaml
    /// </summary>
    public partial class Circle : Page
    {
        public Circle()
        {
            InitializeComponent();
        }

        //Method to calculate the area and input check
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(RadiusBox.Text, out double radius))
            {
                if (RadiusBox.Text != "")
                {
                    AreaBox.Text = (Math.PI*(radius*radius)).ToString();
                }
            }
        }
    }
}
