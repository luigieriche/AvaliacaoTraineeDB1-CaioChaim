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
    public class CandidatoService : ServiceBase<Candidato>, ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository)
            : base(candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }
    }
}
