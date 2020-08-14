using PovezavaBaza;
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

            DataAccess db = new DataAccess();


            int preveri = ba.preveri;

            if(preveri == 1)
            {
                DelovnoMesto a = new DelovnoMesto();
                a.delavec.Content = ba.delavec;  //zapisem kaj je izbrano v PrijavaUporabnik pod kategorijo delavec 
                a.dn.Content = ba.st_nalog_textBox.Text;

                string del_nalog = ba.st_nalog_textBox.Text;
                string sifra_blaga = db.SifraBlaga(del_nalog);
                string kolicina = db.Stkosov(del_nalog);
                string koda_blaga = db.KodaBlaga(sifra_blaga);
                string koda_operacije = ba.operacija;

                string teh_postopek_st = db.CikelCas1(sifra_blaga);
                string cikel_cas = db.CikelCas(teh_postopek_st, koda_operacije);
                double cas = Convert.ToDouble(cikel_cas);
                double cas_minute = cas * 60;
                int minute = Convert.ToInt32(Math.Floor(cas_minute));
                int sekunde = Convert.ToInt32(60 * (cas_minute - Math.Floor(cas_minute)));

                a.sifra.Content = sifra_blaga.Replace(" ", "");
                a.koda.Content = koda_blaga;
                a.kos.Content = kolicina;
                a.cikel.Content = minute + "min " + sekunde + "s";

                this.NavigationService.Navigate(a);
            }
        }

        private void stroji_Click(object sender, RoutedEventArgs e)
        {
            Stroji a = new Stroji();
            this.NavigationService.Navigate(a);
        }
    }
}
