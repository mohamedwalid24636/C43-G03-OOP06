using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_project
{
    abstract internal class Discount
    {
       
        public abstract decimal CalculateDiscount(decimal price, int quantity);
        public string? Name { set; get; }
    }

    internal class PercentageDiscount :Discount  
    {
        
        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
            Name = "PercentageDiscount";
        }

        public decimal Percentage { set; get; }
  

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
           return  price * quantity * (Percentage / 100);
        }
    }

    internal class FlatDiscount : Discount
    {
        public FlatDiscount(decimal flatAmount)
        {
            FlatAmount = flatAmount;
            Name = "FlatDiscount";

        }

        public decimal FlatAmount { set; get; }


        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }

    internal class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
                return (price / 2) * (quantity / 2);
            else 
                return 0 ;

        }
    }


}
