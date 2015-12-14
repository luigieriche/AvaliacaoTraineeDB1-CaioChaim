using Rh.Domain.Entities;
using Rh.Domain.Interfaces.Repositories;
using Rh.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Domain.Services
{
    public class TecnologiaService : ServiceBase<Tecnologia>, ITecnologiaService
    {
        private readonly ITecnologiaRepository _tecnologiaRepository;

        public TecnologiaService(ITecnologiaRepository tecnologiaRepository)
            : base(tecnologiaRepository)
        {
            _tecnologiaRepository = tecnologiaRepository;
        }

        public IEnumerable<Tecnologia> BuscarPorNome(string nome)
        {
            return _tecnologiaRepository.BuscarPorNome(nome);
        }
    }
}
