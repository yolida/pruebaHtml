﻿using FEI.Base;
using FEI.Extension.Datos;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
/// <summary>
/// Jordy Amaro 11-01-17 FEI2-4
/// Cambio de interfaz - Alertas de facturas.
/// </summary>
namespace FEI.pages
{
    /// <summary>
    /// Lógica de interacción para Factura_Alerta.xaml
    /// </summary>
    public partial class Factura_Alerta : Page
    {
        List<ComboBoxPares> veces_al_dia = new List<ComboBoxPares>();
        List<ComboBoxPares> veces_por_hora = new List<ComboBoxPares>();
        private clsEntityAlarms entidad_alarma;
        //Metodo constructor 
        public Factura_Alerta(clsEntityAlarms alarm)
        {
            InitializeComponent();
            //Agregar valores al combobox de veces al dia para alarma automatica.
            veces_al_dia.Add(new ComboBoxPares("2", "2"));
            veces_al_dia.Add(new ComboBoxPares("3", "3"));
            veces_al_dia.Add(new ComboBoxPares("4", "4"));
            veces_al_dia.Add(new ComboBoxPares("6", "6"));
            veces_al_dia.Add(new ComboBoxPares("24", "24"));
            cboVecesDia.DisplayMemberPath = "_Value";
            cboVecesDia.SelectedValuePath = "_key";
            cboVecesDia.SelectedIndex = 0;
            cboVecesDia.ItemsSource = veces_al_dia;
            //Agregar valores al combobox de veces por hora para envio manual
            veces_por_hora.Add(new ComboBoxPares("2", "2"));
            veces_por_hora.Add(new ComboBoxPares("3", "3"));
            veces_por_hora.Add(new ComboBoxPares("4", "4"));
            veces_por_hora.Add(new ComboBoxPares("6", "6"));
            veces_por_hora.Add(new ComboBoxPares("60", "60"));
            cboVecesHora.DisplayMemberPath = "_Value";
            cboVecesHora.SelectedValuePath = "_key";
            cboVecesHora.SelectedIndex = 0;
            cboVecesHora.ItemsSource = veces_por_hora;
            //cboVecesDia.SelectedIndex = 0;
            //cboVecesHora.SelectedIndex = 0;
            entidad_alarma = alarm;
            this.chkEnvioAutomatico.IsChecked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Envioautomatico);
            this.rbtEnvioautomatico_minutos.IsChecked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Envioautomatico_minutos);
            //Evaluar la cantidad seleccionada para la alarma
            switch (entidad_alarma.Cs_pr_Envioautomatico_minutosvalor){
                case "2":
                    this.cboVecesDia.SelectedIndex = 0;
                    break;
                case "3":
                    this.cboVecesDia.SelectedIndex = 1;
                    break;
                case "4":
                    this.cboVecesDia.SelectedIndex = 2;
                    break;
                case "6":
                    this.cboVecesDia.SelectedIndex = 3;
                    break;
                case "24":
                    this.cboVecesDia.SelectedIndex = 4;
                    break;
                default:
                    this.cboVecesDia.SelectedIndex = 0;
                    break;
            }
            
            this.rbtEnvioautomatico_hora.IsChecked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Envioautomatico_hora);
            this.dtpEnvioautomatico_horavalor.Value = Convert.ToDateTime(entidad_alarma.Cs_pr_Envioautomatico_horavalor);
            this.chkEnvioManual.IsChecked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Enviomanual);
            this.rbtEnviomanual_mostrarglobo.IsChecked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Enviomanual_mostrarglobo);
            //Evaluar  el valor de los minutos para envio manual
            switch (entidad_alarma.Cs_pr_Enviomanual_mostrarglobo_minutosvalor)
            {
                case "2":
                    this.cboVecesHora.SelectedIndex = 0;
                    break;
                case "3":
                    this.cboVecesHora.SelectedIndex = 1;
                    break;
                case "4":
                    this.cboVecesHora.SelectedIndex = 2;
                    break;
                case "6":
                    this.cboVecesHora.SelectedIndex = 3;
                    break;
                case "60":
                    this.cboVecesHora.SelectedIndex = 4;
                    break;
                default:
                    this.cboVecesHora.SelectedIndex = 0;
                    break;
            }
            this.rbtEnviomanual_nomostrarglobo.IsChecked = clsBaseUtil.cs_fxStringToBoolean(entidad_alarma.Cs_pr_Enviomanual_nomostrarglobo);
           
            if (chkEnvioAutomatico.IsChecked == true)
            {
                chkEnvioManual.IsChecked = false;
            }
            else
            {
                chkEnvioManual.IsChecked = true;
            }

            if (chkEnvioAutomatico.IsChecked == true)
            {
                chkEnvioManual.IsChecked = false;
            }
            else
            {
                chkEnvioManual.IsChecked = true;
            }
        }    
       
        //Evento click para enviar la configuracion a la base de datos.
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxPares cbpVecesDia = (ComboBoxPares)cboVecesDia.SelectedItem;
            ComboBoxPares cbpVecesHora = (ComboBoxPares)cboVecesHora.SelectedItem;
            //Actualizar valores para entidad alarma.
            entidad_alarma.Cs_pr_Envioautomatico = clsBaseUtil.cs_fxBooleanToString((bool)chkEnvioAutomatico.IsChecked);
            entidad_alarma.Cs_pr_Envioautomatico_minutos = clsBaseUtil.cs_fxBooleanToString((bool)rbtEnvioautomatico_minutos.IsChecked);
            entidad_alarma.Cs_pr_Envioautomatico_minutosvalor = cbpVecesDia._Id;
            entidad_alarma.Cs_pr_Envioautomatico_hora = clsBaseUtil.cs_fxBooleanToString((bool)rbtEnvioautomatico_hora.IsChecked);
            entidad_alarma.Cs_pr_Envioautomatico_horavalor = dtpEnvioautomatico_horavalor.Text;
            entidad_alarma.Cs_pr_Enviomanual = clsBaseUtil.cs_fxBooleanToString((bool)chkEnvioManual.IsChecked);
            entidad_alarma.Cs_pr_Enviomanual_mostrarglobo = clsBaseUtil.cs_fxBooleanToString((bool)rbtEnviomanual_mostrarglobo.IsChecked);
            entidad_alarma.Cs_pr_Enviomanual_mostrarglobo_minutosvalor = cbpVecesHora._Id;
            entidad_alarma.Cs_pr_Enviomanual_nomostrarglobo = clsBaseUtil.cs_fxBooleanToString((bool)rbtEnviomanual_nomostrarglobo.IsChecked);
            dtpEnvioautomatico_horavalor.Value = Convert.ToDateTime(entidad_alarma.Cs_pr_Envioautomatico_horavalor);
            entidad_alarma.cs_pxActualizar(true);
        }
        //Evento check para envio automatico
        private void chkEnvioAutomatico_Checked(object sender, RoutedEventArgs e)
        {
            chkEnvioManual.IsChecked = false;
        }
        //Evento uncheck para envio automatico
        private void chkEnvioAutomatico_Unchecked(object sender, RoutedEventArgs e)
        {
            chkEnvioManual.IsChecked = false;
        }
        //Evento check para envio manual
        private void chkEnvioManual_Unchecked(object sender, RoutedEventArgs e)
        {
            chkEnvioAutomatico.IsChecked = false;
        }
        //Evento uncheck para envio manual
        private void chkEnvioManual_Checked(object sender, RoutedEventArgs e)
        {
            chkEnvioAutomatico.IsChecked = false;
        }
    }
}
