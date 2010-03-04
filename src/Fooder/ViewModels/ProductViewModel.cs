using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Fooder.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();

            AllProducts = new ObservableCollection<Product>  
                             {  
                                 new Product {ProductId = 1, ProductName = "Apple"},  
                                 new Product {ProductId = 2, ProductName = "Orange"},  
                                 new Product {ProductId = 3, ProductName = "Banana"},  
                                 new Product {ProductId = 4, ProductName = "Pear"},  
                                 new Product {ProductId = 5, ProductName = "Grape"},  
                                 new Product {ProductId = 6, ProductName = "Grapefruit"},  
                                 new Product {ProductId = 7, ProductName = "Strawberry"},  
                                 new Product {ProductId = 8, ProductName = "Melon"},  
                                 new Product {ProductId = 9, ProductName = "Guava"},  
                                 new Product {ProductId = 10, ProductName = "Kiwi"},  
                                 new Product {ProductId = 11, ProductName = "Pineapple"},  
                                 new Product {ProductId = 12, ProductName = "Mango"}  
                             };
        }

        public ObservableCollection<Product> AllProducts { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        public void LoadProducts(string filter)
        {
            Products.Clear();
            var query = from p in AllProducts
                        where p.ProductName.ToLower().StartsWith(filter.ToLower())
                        select p;
            foreach (var item in query)
            {
                Products.Add(item);
            }
        }

        public bool CanLoadProducts
        {
            get { return true; }
        }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}