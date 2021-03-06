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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AHS.xaml
    /// </summary>
    public partial class AHS : UserControl
    {
        public AHS()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Button backbuton = (Button)sender;
            backbuton.Visibility = Visibility.Collapsed;
            Navigate.Move(new GovDoc1());
        }

        private void Clipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Clipboard());
        }


        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new GovDoc1());
        }

        private void AddToClipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new GovDoc1());
        }
    }
}
