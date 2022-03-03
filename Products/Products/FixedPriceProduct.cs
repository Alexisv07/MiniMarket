namespace Products
{
    public class FixedPriceProduct : Product
    {

        //public override decimal ValueToPay => Price;

        public override decimal ValueToPay()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"{Price}" + 
                $"n\tValue to Pay: {$"{ValueToPay():C2}",16}";
        }

       
    }
}
