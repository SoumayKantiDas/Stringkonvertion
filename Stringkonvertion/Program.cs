using System;

namespace Stringkonvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Anik";
                string lastname = "Das";
            Console.WriteLine("Full name= " + firstName + lastname);
            string A;
            A = firstName + lastname;
            Console.WriteLine(A);
            A = A.Substring(2, 4);
            Console.WriteLine(A);

        }
    }
}
