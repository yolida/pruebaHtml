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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FEI
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class presentacion : Window
    {
        DispatcherTimer Presentacion_FEI = new DispatcherTimer();
        public presentacion()
        {
            InitializeComponent();
            Presentacion_FEI.Tick += new EventHandler(Presentacion_FEI_Tick);
            Presentacion_FEI.Interval = new TimeSpan(0, 0, 3);
            Presentacion_FEI.IsEnabled = true;
            Presentacion_FEI.Start();
        }

        private void Presentacion_FEI_Tick(object sender, EventArgs e)
        {
            Presentacion_FEI.Stop();
            Presentacion_FEI.IsEnabled = false;
            this.Visibility = Visibility.Hidden;
            //InicioSesion inicio = new InicioSesion();
            Acceso acceso   =   new Acceso();
            acceso.Show();
        }
    }
}
