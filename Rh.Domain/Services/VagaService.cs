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
    public class VagaService : ServiceBase<Vaga>, IVagaService
    {
        private readonly IVagaRepository _vagaRepository;

        public VagaService(IVagaRepository vagaRepository)
            : base(vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }
    }
}
