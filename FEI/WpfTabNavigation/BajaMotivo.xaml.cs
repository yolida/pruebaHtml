﻿using FEI.Extension.Datos;
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
/// <summary>
/// Jordy Amaro 12-01-17 FEI2-4
///  Cambio de interfaz - Ventana de motivo de baja de comprobante.Sera llamado desde otra interfaz.
/// </summary>
namespace FEI
{
    /// <summary>
    /// Lógica de interacción para BajaMotivo.xaml
    /// </summary>
    public partial class BajaMotivo : Window
    {
        string Id;
        clsEntityVoidedDocuments_VoidedDocumentsLine documento;
        clsEntityDatabaseLocal localDB;
        //Constructor de la clase
        public BajaMotivo(string Id,clsEntityDatabaseLocal local)
        {
            InitializeComponent();
            this.Id = Id;
            localDB = local;
            //Obtener los documentos asociados a la comunicacion de baja.
            documento = new clsEntityVoidedDocuments_VoidedDocumentsLine(localDB).cs_fxObtenerUnoPorId(this.Id);
            txtMotivo.Text = documento.Cs_tag_VoidReasonDescription;
        }
        //Cierre de Ventana 
        private void Window_Closed(object sender, EventArgs e)
        {
            Close();
        }
        //Evento Guardar motivo de baja para los documentos.
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            documento.Cs_tag_VoidReasonDescription = txtMotivo.Text;
            documento.cs_pxActualizar(true,true);
            Close();
        }
    }
}
