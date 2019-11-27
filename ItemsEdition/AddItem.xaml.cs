using Domain;
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

namespace ItemsEdition
{
    /// <summary>
    /// Логика взаимодействия для AddItem.xaml
    /// </summary>
    public partial class AddItem : Page
    {
        public Item Item;
        public MainWindow Window;
        public AddItem(MainWindow Window)
        {
            InitializeComponent();
            this.Window = Window;
            Item = new Item();
        }

        private void Button_Accept(object sender, RoutedEventArgs e)
        {
            Item.Name = textBox_ItemName.Text;
            Item.Type = textBox_ItemType.Text;
            Item.Price = Convert.ToInt32(textBox_ItemPrice.Text);
            Item.Weight = textBox_ItemWeight.Text;
            Window.Context.Add(Item);
            Window.Context.SaveChanges();
            Window.frame.Navigate(new Table(Window));
        }
    }
}
