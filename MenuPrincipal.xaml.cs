﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTresEnRaya_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new JugarTresEnRaya());
        }

        private void btnDamas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuscaminas_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Buscaminas.jar");
            Application.Current.Windows[0].WindowState = WindowState.Minimized;
        }

        private void btnBlackjack_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Blackjack.jar");
            Application.Current.Windows[0].WindowState = WindowState.Minimized;
        }

        private void btnSolitario_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Solitario.jar");
            Application.Current.Windows[0].WindowState = WindowState.Minimized;
        }
    }
}
