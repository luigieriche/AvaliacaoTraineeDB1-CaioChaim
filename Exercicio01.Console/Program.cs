using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array definido na avaliação tecnica.
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            ViewResult result = new ViewResult();
            // Variável recebe o resultado da função "result.ValidaArray()".
            var listNumbers = result.ValidaArray(numeros);

            // Apresentãção dos números ímpares encontrados no Array.
            if (listNumbers.Length > 0)
            {
                System.Console.WriteLine(result.Message("Os números ímpares encontrados no Array são:\n")); 

                foreach (var item in listNumbers)
                    System.Console.WriteLine(item);
            }
            else
            {
                System.Console.WriteLine(result.Message("Não existem números ímpares no Array."));
            }

            System.Console.ReadKey();
        }
    }
}
