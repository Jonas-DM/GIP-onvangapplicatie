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
using System.Windows.Shapes;

namespace BSBestellingsform
{
  /// <summary>
  /// Interaction logic for Overzicht.xaml
  /// </summary>
  public partial class Overzicht : Window
  {
	 public Overzicht( )
	 {
		InitializeComponent( );
	 }

	 private void btn_Terug_Click(object sender, RoutedEventArgs e)
	 {
		MainWindow home = new MainWindow( );
		home.Show();
		this.Close();
	 }
  }
}
