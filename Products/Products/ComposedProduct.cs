using System.Collections;
using System.Collections.Generic;

namespace Products
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }


        public List<Product> Products { get; set; }


       

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

        public override string ToString()
        {
            return $"{Discount}" +
               $"\n\tComposedProduct:........ {$"{Price:C2}",15 }" +
                $"\n\tDiscount: ........ {$"{Discount:P2}",15}" +
                $"\n\tValue to Pay:........ {$"{ValueToPay():C2}", 15}";
        }
    }
}
