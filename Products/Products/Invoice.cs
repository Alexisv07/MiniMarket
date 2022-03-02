namespace Products
{
    public class Invoice : IPay
    {
        private int aux;

        public List<Product> products { get; set; }

        
        public decimal ValueToPay()
        {
            return 0; 
        }

        public override string ToString()
        {

            decimal payroll = 0;
            foreach (Product product in products)
            {
                Console.Write(product);
                payroll += product.ValueToPay();

            }
            return payroll + (payroll * (decimal)Discount);
        }


            public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
