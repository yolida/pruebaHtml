using ContasisALF;
using Servicios;
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
    /// Lógica de interacción para Activacion.xaml
    /// </summary>
    public partial class Activacion : Window
    {
        private string Code;
        public Activacion(string codigoMaquina)
        {
            InitializeComponent();
            Code = codigoMaquina;
            labelCodigo.Content = Code;
        }

        private void btnActivar_Click(object sender, RoutedEventArgs e)
        {
            string text = txtCodigo.Text;
            string text2 = text.Trim();
            bool flag = text2.Trim() == "";
            if (flag)
            {
                MessageBox.Show("Ingrese Código de Activación");
            }
            else
            {
                string pEntrada = Encrypt.Base64_Encode(text.Trim());
                string Peticion = Encrypt.Base64_Encode(Code);
                string pEntrada2 = Encrypt.Base64_Encode("SFEI");
                try
                {
                   string soapResult = WebServiceALC.Execute_wsLicencia(pEntrada,Peticion, pEntrada2);
                    string text3 = captura_wslicencia(soapResult);
                    int length = text3.Length;
                   // this.txtLicencia.Text = text3;
                    bool flag2 = length > 1;
                    if (flag2)
                    {
                        bool flag3 = SaveLic.Save(text3);
                        bool flag4 = flag3;
                        if (flag4)
                        {
                            MessageBox.Show("Se ha realizado la activación");
                            DialogResult = true;
                            Close();
                        }
                    }
                    else
                    {
                      
                        if (text3 == "X")
                        {
                            MessageBox.Show("No se pudo activar su producto, código de activación ó producto no válido.");
                        }                       
                        if (text3 == "A")
                        {
                            MessageBox.Show("No se pudo activar su producto, el código de activación ya se encuentra registrado. Por favor contáctese con su proveedor.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo activar su producto, por favor verifique su conexión a Internet e intente nuevamente. " + ex.Message.ToString());
                }
            }
        }
        public string captura_wslicencia(string xml)
        {
            string text = "<T2 xmlns=\"UXMQ09K34J8\">";
            string text2 = "</T2>";
            int num = xml.Count<char>();
            int num2 = text.Count<char>();
            int num3 = text2.Count<char>();
            int num4 = num2 + xml.IndexOf(text);
            int num5 = xml.IndexOf(text2);
            return xml.Substring(num4, num5 - num4);
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
