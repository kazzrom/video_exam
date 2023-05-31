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

namespace MiniShop_.NET_6.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditProduct.xaml
    /// </summary>
    public partial class PageEditProduct : Page
    {
        public PageEditProduct(Product product)
        {
            InitializeComponent();

            TxbNameProduct.Text = product.Name;
            TxbCostProduct.Text = product.Cost.ToString();
            TxbDescriptionProduct.Text = product.Description;
            TxbImageProduct.Text = product.Image;

            ControllerProduct.Id = product.Id;
        }

        private void BtnSaveProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentProduct = ConnectDB.MiniShopContext.Products
                                       .Where(p => p.Id == ControllerProduct.Id)
                                       .First();

                if (string.IsNullOrEmpty(TxbNameProduct.Text) || string.IsNullOrEmpty(TxbCostProduct.Text))
                    throw new Exception("Введите данные некорректно");

                currentProduct.Name = TxbNameProduct.Text;
                currentProduct.Cost = decimal.Parse(TxbCostProduct.Text);
                currentProduct.Description = TxbDescriptionProduct.Text;
                currentProduct.Image = TxbImageProduct.Text;

                ConnectDB.MiniShopContext.SaveChanges();
                MessageBox.Show("Изменения произошли успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
