using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo");
            string sexo = Console.ReadLine();
            Console.WriteLine("Ingrese su peso");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa tu altura");
            double altura = Convert.ToDouble(Console.ReadLine());


        }
    }
}
