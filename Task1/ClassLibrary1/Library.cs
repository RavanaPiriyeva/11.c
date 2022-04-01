using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Library
    {
        public Product[] Products=new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length-1] = product;


        }
        public Product [] GetProductsByPrice(double max , double min)
        {
            Product [] products = new Product[0];
            int j = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if(Products[i].Price<=max && Products[i].Price >= min)
                {
                    Array.Resize(ref products, products.Length+1);
                    products[j++] = Products[i];
                }
            }
            return products;
        }

        public Product [] GetProductByName (string name)
        {
            Product[] products = new Product[0];
            int j = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name.Contains(name))
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[j++] = Products[i];
                }
            }
            return products;

        }
    }
}
