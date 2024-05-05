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
        public string path { get; set; }

        public static void writeTo(string task, string filepath)
        {
           string taak  = task;
           string path = filepath;
           
            StreamWriter streamWriter = new StreamWriter(path);
            if(File.Exists(path))
            {
                streamWriter.Write(taak);
                MessageBox.Show("File has been wroten to!");
            } else
            {
                MessageBox.Show("Couldn't find the file");
            }
           streamWriter.Close();
        }
    }
}
