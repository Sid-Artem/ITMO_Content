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

namespace Задание_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble((rate.Text));
            double sumDollar = Convert.ToDouble((sum.Text));
            double result=rateDollar * sumDollar;
            resSum.Text=result.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble((rate2.Text));
            double sumEvro = Convert.ToDouble((sum2.Text));
            double resultEvro=rateEvro * sumEvro;
            resSum2.Text = resultEvro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGri = Convert.ToDouble((rate3.Text));
            double sumGri = Convert.ToDouble((sum3.Text));
            double resultGri = rateGri * sumGri;
            resSum3.Text = resultGri.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            double rateDra = Convert.ToDouble((rate4.Text));
            double sumDra = Convert.ToDouble((sum4.Text));
            double resultDra = rateDra * sumDra;
            resSum4.Text = resultDra.ToString();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double Dume = Convert.ToDouble((rast1.Text));
            double resDume = Dume* 0.0254;
            sumrast1.Text =resDume.ToString();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double Fute = Convert.ToDouble((rast2.Text));
            double resFute = Fute * 0.3048;
            sumrast2.Text = resFute.ToString();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            double Milli = Convert.ToDouble((rast3.Text));
            double resMilli = Milli * 1609.34;
            sumrast3.Text = resMilli.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double Verst = Convert.ToDouble((rast4.Text));
            double resVerst = Verst * 1066.8;
            sumrast4.Text=resVerst.ToString();
        }
    }
}
