﻿namespace Products
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }
        public override decimal ValueToPay() 
        { 
            return (decimal)Quantity * Price; 
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tVariablePriceProduct:{Price:C2} " +
                $"\n\tPticeTotal:....... {Price:C2}" +
                $"\n\tValue to Pay: {ValueToPay}";
        }

       
    }
}
