using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {


            string nombre = string.Empty;
            do
            {
                Console.WriteLine("Ingrese el nombre :");
                nombre = Console.ReadLine();

            } while (!IsLetter(nombre));

            Console.WriteLine("Su nombre es:");
            Console.WriteLine(nombre);

            string id = string.Empty;
            do
            {
                Console.Write("Ingrese el ID :");
                id = Console.ReadLine();

            } while (IsLetter(id));


            Console.Write("Su ID es:");
            Console.WriteLine(id);
        }

        public static bool IsLetter(string input)
        {
            return !Regex.IsMatch(input, @"^\d+$");
        }
    }
}
