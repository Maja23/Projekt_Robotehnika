using Syncfusion.Pdf.Interactive;
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
    /// Interaction logic for DelovnoMesto.xaml
    /// </summary>
    public partial class DelovnoMesto : Page
    {
        public DelovnoMesto()
        {
            InitializeComponent();

            nacrt.Load(@"..\..\PDF\4500394992.pdf");
            kontrola.Load(@"..\..\PDF\plan.pdf");
   
        }
    }
}
