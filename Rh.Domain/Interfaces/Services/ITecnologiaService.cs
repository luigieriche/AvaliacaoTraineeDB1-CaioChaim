using Rh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Domain.Interfaces.Services
{
    public interface ITecnologiaService : IServiceBase<Tecnologia>
    {
        IEnumerable<Tecnologia> BuscarPorNome(string nome);
    }
}
