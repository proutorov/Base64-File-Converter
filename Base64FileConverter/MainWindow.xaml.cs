using System;
using System.Collections.Generic;
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
using System.IO;
using Base64FileConverter;

namespace Base64FileConverter
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
        private void Dropbox_Drop(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (byteToBase64.IsChecked.Value)
                    File.WriteAllText(files[0].Replace("." + files[0].Split('.')[files[0].Split('.').Length - 1], ".txt"), Convert.ToBase64String(File.ReadAllBytes(files[0])));
                else
                    File.WriteAllBytes(files[0].Replace("." + files[0].Split('.')[files[0].Split('.').Length -1 ], ".dat"), Convert.FromBase64String(File.ReadAllText(files[0])));
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
