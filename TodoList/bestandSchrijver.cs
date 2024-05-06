using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TodoList
{
    class bestandSchrijver
    {
        public string taak { get; set; }

        public static void writeTo(string task)
        {
            string taak = task;
            string filePath = @"C:\Users\fgoub\OneDrive\Bureaublad\taak\taken.txt";

            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(taak);
                }
                MessageBox.Show("Text has been written to the corresponding file!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }
        public static void readFrom(string task)
        {
            string filePath = @"C:\Users\fgoub\OneDrive\Bureaublad\taak\taken.txt";
            string taak = task;
            using(StreamReader sr =  new StreamReader(filePath))
            {
                string[] lines = sr.ReadToEnd().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                  if(line.CompareTo(taak) == 0)
                    {
                        MessageBox.Show(line);
                        break;
                    }
                }
                sr.Close();
            }
        }

    }

    }
