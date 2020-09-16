using System;


namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string u = Console.ReadLine();
            string r = Console.ReadLine();
            int u_1, r_1;
            if (int.TryParse(u, out u_1) && int.TryParse(r, out r_1))
            {
                Console.WriteLine("гипотенуза = " + ((double)Math.Sqrt(Math.Pow(u_1, 2)  + Math.Pow(r_1,2))));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            Console.ReadLine();

        }
    }
}
