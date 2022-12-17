using IntegrallarniHisoblash.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntegrallarniHisoblash
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Integral_xn_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Integral_xn();
        }

        private void Integral_sinkx_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Integral_sinkx();
        }

        private void Integral_coskx_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Integral_coskx();
        }
    }
}
