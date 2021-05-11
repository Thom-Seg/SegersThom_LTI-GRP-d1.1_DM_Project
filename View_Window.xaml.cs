using System;
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

namespace Project_datamanipulatie
{
    /// <summary>
    /// Interaction logic for View_Window.xaml
    /// </summary>
    public partial class View_Window : Window
    {
        public View_Window()
        {
            InitializeComponent();
        }


        
        //Opens the MainWindow, and closes the ViewWindow
        private void btnBack(object sender, RoutedEventArgs e)
        {
            
            MainWindow main_Window = new MainWindow();
            main_Window.Show();
            this.Close();
        }


        //Opens an Edit Window, and closes the ViewWindow
        private void btnEdit(object sender, RoutedEventArgs e)
        {

        }


        //Deletes the current item from the Database, then opnes the MainWindow and closes the ViewWindow
        private void btnDelete(object sender, RoutedEventArgs e)
        {

        }
    }
}
