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

            foreach (Product product in products)
            {
                aux = 0;
                Console.Write(product);
                aux += product.ValueToPay();

            }
            return payroll - (payroll * (decimal)Discount);
        }


            public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
