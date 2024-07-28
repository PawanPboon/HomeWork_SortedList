using System;
using System.Collections;
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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public object key;

        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{keyTxt.Text} has been added.");
            sortedList.Add(keyTxt.Text,valueTxt.Text);
            ICollection icollection = sortedList.Keys;
            string dataName = string.Empty;
            
            foreach (string key in icollection)
            {
                dataName += $"{key} : {sortedList[key]}\n";
            }
           
               MessageBox.Show(dataName);


        }
    }
}
