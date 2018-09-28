﻿using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;
using System.ComponentModel;
using FEI.Extension.Datos;
/// <summary>
/// Jordy Amaro 12-01-17 FEI2-4
///  Cambio de interfaz - Ventana de carga actualizacion de base de datos.
/// </summary>
namespace FEI
{
    /// <summary>
    /// Lógica de interacción para Loading.xaml
    /// </summary>
    public partial class Loading : Window
    {
        private readonly BackgroundWorker worker = new BackgroundWorker();
        BitmapImage image_replace_gif = new BitmapImage();
        BitmapImage image_replace_png = new BitmapImage();
        //Metodo constructor.
        public Loading()
        {
            InitializeComponent();
        }
        //Evento carga de ventana de Loading
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Cargar imagen gif en componene imagen.
            image_replace_gif.BeginInit();
            image_replace_gif.UriSource = new Uri(@"/FEIv2;component/images/loader.gif", UriKind.RelativeOrAbsolute);
            image_replace_gif.EndInit();
            ImageBehavior.SetAnimatedSource(image, image_replace_gif);
            ImageBehavior.SetRepeatBehavior(image, RepeatBehavior.Forever);
            //Inicializar worker
            worker.DoWork += OnDoWork;
            worker.ProgressChanged += OnProgressChanged;
            worker.RunWorkerCompleted += OnRunWorkerCompleted;
            worker.RunWorkerAsync();
        }
        //Evento mientras se realiza el trabajo en segundo plano
        private void OnDoWork(object sender, DoWorkEventArgs e)
        {
            new clsEntityDatabaseLocal().cs_pxVerificarBaseDatos();
        }
        //Evento en progreso de trabajo en segundo plano
        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            estado.Content= "Actualizando...";
        }
        //Evento al culminar el proceso en segundo plano
        private void OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Redefinir imagen a mostrar.
            ImageBehavior.SetAnimatedSource(image,null);
            image.Source = null;          
            image_replace_png.BeginInit();
            image_replace_png.UriSource = new Uri(@"/FEIv2;component/images/Information.png", UriKind.RelativeOrAbsolute);
            image_replace_png.EndInit();
            image.Source = image_replace_png;
            //Cambiar valores de texto
            this.Title = "Actualizado";
            estado.Content = "Estructura actualizada";
        }
    }
}
