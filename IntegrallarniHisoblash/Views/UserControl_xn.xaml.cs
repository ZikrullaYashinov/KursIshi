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

namespace IntegrallarniHisoblash.Views
{
    /// <summary>
    /// Логика взаимодействия для UserControl_xn.xaml
    /// </summary>
    public partial class UserControl_xn : UserControl
    {

        

        public UserControl_xn()
        {
            InitializeComponent();
            
        }

        private void Integral_xn_Ok_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                double ad = double.Parse(txta.Text.ToString());
                double bd = double.Parse(txtb.Text.ToString());
                double nd = double.Parse(txtn.Text.ToString());
                a.Content = ad.ToString();
                b.Content = bd.ToString();
                n.Content = nd.ToString();

                result.Content = hisobla(nd, ad, bd).ToString();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Iltimos kiritish parametirlaringizni tekshiring",
                                    "Xatolik",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Error);
            }
            
        }

        private string hisobla(double n, double a, double b)
        {
            if (n != -1)
                return ((Math.Pow(b, n + 1) - Math.Pow(a, n + 1)) / (n + 1)).ToString();
            return (Math.Log(b) - Math.Log(a)).ToString();
        }
    }
}
