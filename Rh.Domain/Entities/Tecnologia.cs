using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Domain.Entities
{
    public class Tecnologia
    {
        public int TecnologiaId { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int CandidatoId { get; set; }
        public virtual Candidato Candidato { get; set; }
    }
}
