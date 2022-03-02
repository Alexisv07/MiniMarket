using System.Collections;
using System.Collections.Generic;

namespace Products
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }


        public List<Product> Products { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()}" +
               $"\n\tComposedProduct:{Price:C2} " +
                $"\n\tDiscount : {Discount:P2}" +
                $"\n\tValue to Pay: {ValueToPay}";
        }

        public override decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in Products)
            {
                Console.Write(product);
                payroll += product.ValueToPay();

            }
            return payroll - (payroll * (decimal)Discount);
        }
    }
}
