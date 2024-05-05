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
            if (File.Exists(@"C:\Users\fgoub\OneDrive\Bureaublad\taak\taken.txt"))
            {
                File.WriteAllText(@"C:\Users\fgoub\OneDrive\Bureaublad\taak\taken.txt", taak);
                MessageBox.Show("Text has been written to the corresponding file!");
            } else {
                Console.WriteLine("This file does not exist");
                MessageBox.Show("File does not exist");
            }
        }

    }
}
