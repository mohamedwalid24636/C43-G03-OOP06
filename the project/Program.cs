using System.Reflection.Metadata.Ecma335;
using the_project;

internal class Program
{


    private static void Main(string[] args)
    {


        Console.WriteLine("please enter user type {regular , Premium , guest}");
        string? type = Console.ReadLine();


        User U1 = type switch
        {
            "Regular" => new RegularUser("mohamed"),
            "Premium" => new PremiumUser("ezz"),
            "guest" => new Guest_user("bebe"),
            _ => throw new Exception("invalid")
        };


        Console.WriteLine("please enter user price");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("please enter user quantity");
        int quantity = int.Parse(Console.ReadLine());

        Discount? D1 = U1.GetDiscount();
      

        decimal discount = D1.CalculateDiscount(price, quantity);
        decimal final_result = (price * quantity) - discount;


        Console.WriteLine($"discount : {discount}");
        Console.WriteLine($"final price : {final_result}");



    }
}