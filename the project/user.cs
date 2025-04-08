using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_project
{
    internal abstract class User 
    {
        public string? Name { set; get; }
        public abstract Discount? GetDiscount();

    }



    internal class RegularUser : User
    {
       public RegularUser(string name )
        {
            Name = name;
        }

        public override Discount? GetDiscount()
        {
            return new PercentageDiscount(5);

        }
    }






    internal class PremiumUser : User
    {
        public PremiumUser(string name )
        {
            Name = name;
        }

        public override Discount? GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }




    internal class Guest_user : User
    { 
   public Guest_user(string name )
        {      Name = name;        }

        public override Discount? GetDiscount()
        {
            return null; 
        }
    }


}
