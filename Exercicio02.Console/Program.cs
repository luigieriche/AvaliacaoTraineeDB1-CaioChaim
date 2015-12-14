using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Arrays definidos na avaliação técnica.
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            ViewResult result = new ViewResult();
            var NumerosDistintos = result.MostrarNumeros(primeiroArray, segundoArray);

            foreach (var item in NumerosDistintos)
            {
                System.Console.WriteLine(item);
            }

            System.Console.ReadKey();
        }
    }
}
