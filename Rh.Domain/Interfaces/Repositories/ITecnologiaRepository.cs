using Rh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Domain.Interfaces.Repositories
{
    public interface ITecnologiaRepository : IRepositoryBase<Tecnologia>
    {
        IEnumerable<Tecnologia> BuscarPorNome(string nome);
    }
}
