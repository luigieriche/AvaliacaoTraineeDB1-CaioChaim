using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Console
{
    public class ViewResult
    {
        /// <summary>
        ///     Método para retornar os numeros distintos.
        /// </summary>
        /// <param name="primeiroArray"></param>
        /// <param name="segundoArray"></param>
        /// <returns> Array de inteiros </returns>
        public int[] MostrarNumeros(int[] primeiroArray, int[] segundoArray)
        {
            // Capturando somente os números distindos do primeiro array em relação ao segundo.
            var query = primeiroArray.Except(segundoArray);

            // Converta query para array.
            var array = query.ToArray();

            return array;
        }
    }
}
