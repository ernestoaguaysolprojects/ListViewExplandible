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
            product.IsVisible = true;

            UpdateProduct(product);
        }

        private void UpdateProduct(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }
}
