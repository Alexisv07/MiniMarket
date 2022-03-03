namespace Products
{
    public class Invoice : IPay
    {
       

        public List<Product> products { get; set; }


        public decimal ValueToPay()
        {
            return ValueToPay();
        }

        //public override string ToString()
        //{

        //    int aux = 0;
        //    foreach (Product product in products)
        //    {
        //        Console.Write(product);
        //        aux += produts.ValueToPay();

        //    }
        //    return aux + (*products);
        //}


        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
