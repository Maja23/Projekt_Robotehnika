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

namespace Projekt1
{
    /// <summary>
    /// Interaction logic for ZacetnaStran.xaml
    /// </summary>
    public partial class ZacetnaStran : Page
    {
        public ZacetnaStran()
        {
            InitializeComponent();
        }

        private void delovno_mesto_Click(object sender, RoutedEventArgs e)
        {

            PrijavaUporabnika ba = new PrijavaUporabnika();
            ba.ShowDialog();

            DelovnoMesto a = new DelovnoMesto();
            this.NavigationService.Navigate(a);
        }

        private void stroji_Click(object sender, RoutedEventArgs e)
        {
            Stroji a = new Stroji();
            this.NavigationService.Navigate(a);
        }
    }
}
