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

namespace Teste03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, RoutedEventArgs e)
        {
            double dolares, reais, vDolar;

            dolares = Convert.ToDouble(txtValorDolares.Text);
            vDolar = Convert.ToDouble(txtVDolar.Text);

            reais = dolares * vDolar;

            lblValorReais.Content = "R$" + reais.ToString("0.00");
        }
    }
}
