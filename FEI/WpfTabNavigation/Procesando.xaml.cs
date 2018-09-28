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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;
/// <summary>
/// Jordy Amaro 12-01-17 FEI2-4
/// Cambio de interfaz
/// </summary>
namespace FEI
{
    /// <summary>
    /// Lógica de interacción para Procesando.xaml
    /// </summary>
    public partial class Procesando : Window
    {
        BitmapImage image_replace = new BitmapImage();
        public Procesando()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            image_replace.BeginInit();
            image_replace.UriSource = new Uri(@"/FEIv2;component/images/Animation.gif", UriKind.RelativeOrAbsolute);
            image_replace.EndInit();
            ImageBehavior.SetAnimatedSource(image, image_replace);
            ImageBehavior.SetRepeatBehavior(image, RepeatBehavior.Forever);
        }
    }
}
