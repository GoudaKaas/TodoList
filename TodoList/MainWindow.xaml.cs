using System.Text;
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
            bestandSchrijver schrijver = new bestandSchrijver();
        }
            string filePath = @"C:\Users\fgoub\OneDrive\Bureaublad\taak\taken.txt";
        private void Button_Click(object sender, RoutedEventArgs e) {
                try
                {
                    string taak = TekstInput.Text;
                    bestandSchrijver.writeTo(taak);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n Couldn't find the file :(");
                }
            }

        private void LeesBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               bestandSchrijver.readFrom(TekstInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Dit is niet gelukt");
            }
        }
    }
    }