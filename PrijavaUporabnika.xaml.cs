using PovezavaBaza;
using PovezavaBaza.Models;
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
    /// Interaction logic for PrijavaUporabnika.xaml
    /// </summary>
    public partial class PrijavaUporabnika : Window
    {

        List<Person> people = new List<Person>();
        List<SifraOperacije> postopek_sifraoperacije = new List<SifraOperacije>();

        public PrijavaUporabnika()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            DataAccess db = new DataAccess();

            // za napolnjen combobox
            people = db.GetPeople(); //pridobljen podatki iz baze

            foreach (Person a in people) //iz lista prepisem v combobox
            {

                delavec_ComboBox.Items.Add(a.FullInfro.ToString());
            }

            postopek_sifraoperacije = db.SifraOperacije();

            foreach (SifraOperacije b in postopek_sifraoperacije) //iz lista prepisem v combobox
            {

                operacija_ComboBox.Items.Add(b.FullInfro.ToString());
            }



        }

        private void delvec_Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = delavec_ComboBox.SelectedIndex;
            Object selectedItem = delavec_ComboBox.SelectedItem;

            if (selectedIndex == -1)
                MessageBox.Show("Izberi vrednost");
            else
                MessageBox.Show("Selected Item Text: " + selectedItem.ToString());
        }

        private void operacija_Button_Click(object sender, RoutedEventArgs e)
        {

        }


        public int preveri = 0;
        private void potrdi_Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

            if(sender == potrdi_Button)
            {
                preveri = 1;
            }

        }
    }
}
