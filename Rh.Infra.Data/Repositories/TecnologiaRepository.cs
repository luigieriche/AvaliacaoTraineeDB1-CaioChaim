using Rh.Domain.Entities;
using Rh.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Infra.Data.Repositories
{
    public class TecnologiaRepository : RepositoryBase<Tecnologia>, ITecnologiaRepository
    {
        // Método de busca de tecnologias por nome
        public IEnumerable<Tecnologia> BuscarPorNome(string nome)
        {
            return Db.Tecnologias.Where(t => t.Nome == nome);
        }
    }
}
