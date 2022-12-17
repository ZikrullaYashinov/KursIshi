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
using IntegrallarniHisoblash.ViewModels;

namespace IntegrallarniHisoblash.Views
{
    /// <summary>
    /// Логика взаимодействия для UserControl_sinkx.xaml
    /// </summary>
    public partial class UserControl_sinkx : UserControl
    {
        public UserControl_sinkx()
        {
            InitializeComponent();
        }
        private void Integral_sinkx_Ok_Cliced(object sender, RoutedEventArgs e)
        {
            try
            {
                double ad = double.Parse(txta.Text.ToString());
                double bd = double.Parse(txtb.Text.ToString());
                double nd = double.Parse(txtk.Text.ToString());
                a.Content = ad.ToString();
                b.Content = bd.ToString();
                k.Content = nd.ToString();

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
        private double hisobla(double k, double a, double b)
        {
            return -1.0 * (Math.Cos(k * b) - Math.Cos(k * a)) / k;
        }
    }
}
