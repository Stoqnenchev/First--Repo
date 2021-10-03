using System;

namespace domashno2
{
    class Program
    {
        static void Main(string[] args)
        {
            string chislo = "21";
            int chislo2 = Convert.ToInt32(chislo, 16);
            string chislo3 = Convert.ToString(chislo2, 2);
            Console.WriteLine(chislo3);
        }
    }
}
