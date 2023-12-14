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
using System.Configuration;
using System.Data.SqlClient;

namespace Projecte_Kanban
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection laMevaConnexioSQL;
        public MainWindow()
        {
            InitializeComponent();

            string laMevaConnexio = ConfigurationManager.ConnectionStrings["Projecte Kanban.Properties.Settings.SimuladorKanbanConnectionString"].ConnectionString;

        }
        private void Afegir_Click(object sender, RoutedEventArgs e)
        {
            Afegir finestraAfegir = new Afegir();
            finestraAfegir.ShowDialog();

        }
    }
}
