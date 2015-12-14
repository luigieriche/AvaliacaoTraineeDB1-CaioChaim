using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Console
{
    abstract public class ResultMessage
    {
        /// <summary>
        ///     Método de retorno de mensagem a ser sobrescrito.
        /// </summary>
        /// <param name="m"> String m </param>
        /// <returns> String vazia </returns>
        public virtual String Message(String m)
        {
            return string.Empty;
        }
    }
}
