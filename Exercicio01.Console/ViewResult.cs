using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Console
{
    public class ViewResult : ResultMessage
    {
        /// <summary> 
        ///     Método que valida se existe números pares dentro do array passado por argumento.
        /// </summary>
        /// <param name="numeros"> Array de inteiros </param>
        /// <returns> Retorna um Array de inteiros com os números ímpares encontrados no Array "Numeros", se houver </returns>
        public int[] ValidaArray(int[] numeros)
        {
            // Consulta LINQ para obter todos os números pares do Array.
            var query = 
                from n in numeros 
                where n % 2 != 0 
                select n;

            var array = query.ToArray();

            return array;
        }

        /// <summary>
        ///     Método de sobrescrita para retornar a mensagem enviada por argumento.
        /// </summary>
        /// <param name="message"> String message </param>
        /// <returns> Retorna a string passada por argumento. </returns>
        public override String Message(String m)
        {
            return m;
        }
    }
}
