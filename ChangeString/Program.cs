using System;
using System.Reflection.PortableExecutable;
using System.Text;

namespace finalString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string request1 = Console.ReadLine();
            Console.Write("Caráter: ");
            string request2 = Console.ReadLine();
            char c2 = char.Parse(request2);

            string final = "";

            foreach (char c in request1)
            {
                if (c == c2)
                {
                    final += "x";
                }

                if (c != c2)
                {
                    final += c;
                }
            }
            Console.WriteLine(final);

        }
    }
}
