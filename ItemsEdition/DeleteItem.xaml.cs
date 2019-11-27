using Domain;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для DeleteItem.xaml
    /// </summary>
    public partial class DeleteItem : Page
    {
        public MainWindow Window;
        public DeleteItem(MainWindow Window)
        {
            InitializeComponent();
            this.Window = Window;
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if(textBox_DeleteItemName.Text != null)
            {
                Item item = Window.Context.Items.Where(x => x.Name == textBox_DeleteItemName.Text).FirstOrDefault();

                Window.Context.Items.Remove(item);
                Window.Context.SaveChanges();
                Window.frame.Navigate(new Table(Window));
            }
        }
    }
}
