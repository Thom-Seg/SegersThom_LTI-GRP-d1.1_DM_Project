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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_datamanipulatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Item> items = new List<Item>();
            items.Add(new Item() { Title = "Item 1" });
            items.Add(new Item() { Title = "Item 2" });
            items.Add(new Item() { Title = "Item 3" });
            items.Add(new Item() { Title = "Item 4" });
            items.Add(new Item() { Title = "Item 5" });
            items.Add(new Item() { Title = "Item 6" });
            items.Add(new Item() { Title = "Item 7" });
            items.Add(new Item() { Title = "Item 8" });
            items.Add(new Item() { Title = "Item 9" });
            items.Add(new Item() { Title = "Item 10" });

            lbItems.ItemsSource = items;
        }

        private void lbItem_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lbItems.SelectedItem != null)
                this.Title = (lbItems.SelectedItem as Item).Title;
        }



        public class Item
        {
            public string Title { get; set; }

            public override string ToString()
            {
                return this.Title;
            }
        }

        private void View(object sender, RoutedEventArgs e)
        {
            View_Window view_Window = new View_Window();
            view_Window.Show();
        }


    }
}
