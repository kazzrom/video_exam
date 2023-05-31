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
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        public PageAddProduct()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            TxbNameProduct.Clear();
            TxbCostProduct.Clear();
            TxbDescriptionProduct.Clear();
            TxbImageProduct.Clear();
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Name = TxbNameProduct.Text;
                product.Cost = decimal.Parse(TxbCostProduct.Text);
                product.Description = TxbDescriptionProduct.Text;
                product.Image = TxbImageProduct.Text;

                ConnectDB.MiniShopContext.Add(product);
                ConnectDB.MiniShopContext.SaveChanges();
                MessageBox.Show("Товар успешно создан!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
