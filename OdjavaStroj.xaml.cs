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
using System.Windows.Shapes;

namespace Projekt1
{
    /// <summary>
    /// Interaction logic for OdjavaStroj.xaml
    /// </summary>
    public partial class OdjavaStroj : Window
    {

        public int preveri = 0;

        public OdjavaStroj()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            shrani.Click += Button_Click;

            prekini.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender == shrani)
            {
                this.Close();
                preveri = 1;
            }
            else if(sender == prekini)
            {
                this.Close();
                preveri = 0;
            }

        }

    }
}
