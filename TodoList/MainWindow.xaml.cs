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
        }
            string filePath = @"C:\Users\fgoub\source\repos\Fabrice_Gouba_OOPProject\TodoList";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label newTask = new Label();
            newTask.Content = TekstInput.Text;
            lijst.Children.Add(newTask);
        }
    }
}