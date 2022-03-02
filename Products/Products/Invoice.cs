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
                //$"{Id} - {Description}" +
                //$"\n\tQuantity.......: {Quantity:N2}" +
                //$"\n\tPrice..........: {Price:N2}" +
                //$"\n\tValue..........: {ValueToPay:N2}";
            }

            return 0;
        }



          public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
