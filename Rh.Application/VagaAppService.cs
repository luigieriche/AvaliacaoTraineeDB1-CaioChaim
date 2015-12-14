using Rh.Application.Interfaces;
using Rh.Domain.Entities;
using Rh.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rh.Application
{
    public class VagaAppService : AppServiceBase<Vaga>, IVagaAppService
    {
        private readonly IVagaService _vagaService;

        public VagaAppService(IVagaService vagaService)
            : base(vagaService)
        {
            _vagaService = vagaService;
        }
    }
}
