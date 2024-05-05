﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using System.IO;
using TodoList;

namespace TodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(filePath);
        }
            string filePath = @"C:\Users\fgoub\OneDrive\Bureaublad\taak\taken.txt";
            bestandSchrijver schrijver = new bestandSchrijver();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              string taak = TekstInput.Text;
              bestandSchrijver.writeTo(taak, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Couldn't find the file :(");
            }
        }
    }
}