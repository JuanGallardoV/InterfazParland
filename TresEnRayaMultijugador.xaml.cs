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
    /// Lógica de interacción para TresEnRayaMultijugador.xaml
    /// </summary>
    public partial class TresEnRayaMultijugador : Page
    {
        public TresEnRayaMultijugador()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new JugarTresEnRaya());
        }

        private void btCrear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUnirse_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
