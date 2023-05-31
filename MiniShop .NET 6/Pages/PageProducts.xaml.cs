using MiniShop_.NET_6.AppData;
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
using System.Windows.Threading;

namespace MiniShop_.NET_6.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProducts.xaml
    /// </summary>
    public partial class PageProducts : Page
    {
        public PageProducts()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
        }

        private void UpdateData(object? sender, EventArgs e)
        {
            var history = ConnectDB.MiniShopContext.Products.ToList();
            ListProducts.ItemsSource = history;

            if (!string.IsNullOrEmpty(TxbSearch.Text))
                ListProducts.ItemsSource = ConnectDB.MiniShopContext.Products.Where(p => p.Name.StartsWith(TxbSearch.Text)).ToList();
        }

        private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.Frame.Navigate(new PageEditProduct((sender as Button).DataContext as Product));
        }
    }
}
