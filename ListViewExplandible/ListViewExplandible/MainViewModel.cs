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
                    Title = "Remeras"
                },

                new Product
                {
                    Title = "Zapatos"
                },

                new Product
                {
                    Title = "Jeans"
                },
            };
        }
    }
}
