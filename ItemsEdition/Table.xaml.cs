using Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace ItemsEdition
{
    /// <summary>
    /// Логика взаимодействия для Table.xaml
    /// </summary>
    public partial class Table : Page
    {
        public List<Item> Items { get; set; }
        public MainWindow Window;
        public Table(MainWindow Window)
        {
            InitializeComponent();
            this.Window = Window;
            var Items = Window.Context.Items.ToList();
            dataGrid.ItemsSource = Items;
        }

        private void Add_ItemClick(object sender, RoutedEventArgs e)
        {
            Window.frame.Navigate(new AddItem(Window));
        }

        private void Delete_ItemClick(object sender, RoutedEventArgs e)
        {
            Window.frame.Navigate(new DeleteItem(Window));
        }

        private void Edit_ItemClick(object sender, RoutedEventArgs e)
        {
            Window.Context.SaveChanges();
        }
    }
}
