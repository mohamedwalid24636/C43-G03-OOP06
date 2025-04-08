using ConsoleApp2;




internal class Program
{


    private static void Main(string[] args)
    {
        #region Q1
        //calss_Math.Add(50,70);
        //calss_Math.Subtract(50,70);
        //calss_Math.Multiply(50,70);
        //calss_Math.Divide(50,70);
        #endregion


        #region Q2
        //Console.WriteLine("please enter the coordinator for you point ");
        //int.TryParse(Console.ReadLine(), out int a ); 
        //int b = int.Parse(Console.ReadLine()??"0");
        //int c = Convert.ToInt32(Console.ReadLine()) ;
        #endregion




        #region Q3
        _3D_point[] P =
        {
            new _3D_point(2,6,4),
            new _3D_point (2,1,1),
            new _3D_point (4,5,6),
            new _3D_point (7,22,6),
            new _3D_point (1,85,6),
        };

        Console.WriteLine(P);


        Array.Sort(P);


        foreach (_3D_point nj in P)
        {
            Console.WriteLine(nj);
        }

        Console.WriteLine("\n");

        Array.Sort(P, new POINT_P2());

        foreach (_3D_point n in P)
        {
            Console.WriteLine(n);
        }

        #endregion




        #region Clone 

        _3D_point p = new _3D_point(2, 5, 8);

        _3D_point p1 = new _3D_point(0, 0, 0);
        Console.WriteLine("\n");

        Console.WriteLine(p);
        Console.WriteLine(p1);

        Console.WriteLine("\n");


        p = (_3D_point)p1.Clone();



        Console.WriteLine(p);
        Console.WriteLine(p1);

        #endregion












    }





}