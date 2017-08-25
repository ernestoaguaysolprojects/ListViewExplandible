using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExplandible
{
    public class MainViewModel
    {
        private Product _oldProduct;

        public ObservableCollection<Product> Products { get; set; }

        public MainViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Title = "Remeras",
                    IsVisible = false,
                },

                new Product
                {
                    Title = "Zapatos",
                },

                new Product
                {
                    Title = "Jeans"
                },
            };
        }

        public void HideOrShowProduct(Product product)
        {
            if(_oldProduct == product)
            {
                product.IsVisible = !product.IsVisible;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.IsVisible = false;
                    UpdateProducts(_oldProduct);
                }

                product.IsVisible = true;
                UpdateProducts(product);
            }

            _oldProduct = product;
        }

        private void UpdateProducts(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }
}
