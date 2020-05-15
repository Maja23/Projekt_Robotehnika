using Syncfusion.Pdf.Interactive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt1
{
    /// <summary>
    /// Interaction logic for DelovnoMesto.xaml
    /// </summary>
    public partial class DelovnoMesto : Page
    {
        public DelovnoMesto()
        {
            InitializeComponent();

            nacrt.Load(@"..\..\PDF\4500394992.pdf");
   
        }

        private void plan_kontrole_Click(object sender, RoutedEventArgs e)
        {
            kontrola.Load(@"..\..\PDF\plan.pdf");
        }

        private void reklamacija_Click(object sender, RoutedEventArgs e)
        {
            kontrola.Load(@"..\..\PDF\4500394992.pdf");
        }

        private void teh_postopki_Click(object sender, RoutedEventArgs e)
        {
            kontrola.Load(@"..\..\PDF\4500394442.pdf");
        }

        private void nastavitev_stroja_Click(object sender, RoutedEventArgs e)
        {
            NastavitevStroja a = new NastavitevStroja();

            a.ShowDialog();

       /*     ZacetnaStran b = new ZacetnaStran();
            this.NavigationService.Navigate(b);

            Thread.Sleep(500);*/

        }

        private void odjava_Click(object sender, RoutedEventArgs e)
        {
            OdjavaStroj a = new OdjavaStroj();

            a.ShowDialog();

            int previous = a.preveri;

            if(previous == 1)
            {
                ZacetnaStran b = new ZacetnaStran();
                this.NavigationService.Navigate(b);

                Thread.Sleep(500);
            }
            






        }
    }
}
