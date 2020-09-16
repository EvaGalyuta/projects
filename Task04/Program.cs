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
                Console.WriteLine("I = " + ((double)u_1 / r_1));
                Console.WriteLine("P = " + ((double)Math.Pow(u_1, 2) / r_1));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            Console.ReadLine();

        }
    }
}
