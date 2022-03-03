using System.Collections.Generic;

namespace Products
{
    public class Invoice : IPay
    {
        

        public List<Product> products { get; set; }
        

        //public void AddProduct(Product product)
        //{
        //    products.Add(product);
        //}

        

        //public override string ToString()
        //{

        //    int aux = 0;
        //    foreach (Product product in _products)
        //    {
        //        Console.Write(product);
        //        aux += _products.Count;

        //    }
        //    return aux + (aux * (_products.Count);
        //}

        
        public decimal ValueToPay()
        {
            return ValueToPay();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

    }
}
