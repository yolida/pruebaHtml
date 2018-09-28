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

namespace FEI
{
    /// <summary>
    /// Lógica de interacción para Licencia.xaml
    /// </summary>
    public partial class Licencia : Window
    {
        private string codigoPeticion;
        private string fecha;
        private string tipoLicencia;

        public Licencia()
        {
            InitializeComponent();
        }

        public Licencia(string fecha, string tipoLicencia, string codigoPeticion)
        {
            InitializeComponent();
            this.fecha = fecha;
            this.tipoLicencia = tipoLicencia;
            this.codigoPeticion = codigoPeticion;

            Peticion.Content = codigoPeticion;
            fechaVencimiento.Content = fecha;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
