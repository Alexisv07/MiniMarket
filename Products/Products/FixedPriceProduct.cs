namespace Products
{
    public class FixedPriceProduct : Product
    {
        
        //public override decimal ValueToPay => Price;

        public override string ToString()
        {
            return $"base.ToString()\n\tValue to Pay: {ValueToPay}:C2";
        }

        public override decimal ValueToPay()
        {
            return Price;
        }
    }
}
