﻿using System;
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

namespace InterfazParland
{
    /// <summary>
    /// Lógica de interacción para JugarTresEnRaya.xaml
    /// </summary>
    public partial class JugarTresEnRaya : Page
    {
        public JugarTresEnRaya()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new MenuPrincipal());
        }

        private void btnMultijugador_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new TresEnRayaMultijugador());
        }

        private void btnUnJugador_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("TresEnRayaLocal.jar");
            Application.Current.Windows[0].WindowState = WindowState.Minimized;
        }
    }
}
