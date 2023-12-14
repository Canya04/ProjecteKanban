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

namespace Projecte_Kanban
{
    /// <summary>
    /// Lógica de interacción para Afegir.xaml
    /// </summary>
    public partial class Afegir : Window
    {
        public Afegir()
        {
            InitializeComponent();
        }

        private void nomTasca_GotFocus(object sender, RoutedEventArgs e)
        {            
            nomTasca.Text = string.Empty;
        }

        private void descripcioTasca_GotFocus(object sender, RoutedEventArgs e)
        {
            descripcioTasca.Text = string.Empty;
        }

        private void dataTasca_GotFocus(object sender, RoutedEventArgs e)
        {
            dataTasca.Text = string.Empty;
        }

        private void responsableTasca_GotFocus(object sender, RoutedEventArgs e)
        {
            responasbleTasca.Text = string.Empty;
        }
    }
}
