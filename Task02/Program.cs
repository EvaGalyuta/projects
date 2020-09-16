using System;

namespace Task02{
    class Program { 
        static void Main(string[] args) {
            string x = Console.ReadLine();
            int num = 0;
            char symb;
            if (int.TryParse(x, out num) && num >= 32 && num <= 127){
                symb = (char)num;
                Console.WriteLine(symb);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }

        }
    }
}
