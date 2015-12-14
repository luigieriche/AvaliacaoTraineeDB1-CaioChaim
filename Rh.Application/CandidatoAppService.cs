using Rh.Application.Interfaces;
using Rh.Domain.Entities;
using Rh.Domain.Interfaces.Services;

namespace Rh.Application
{
    public class CandidatoAppService : AppServiceBase<Candidato>, ICandidatoAppService
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatoAppService(ICandidatoService candidatoService)
            : base(candidatoService)
        {
            _candidatoService = candidatoService;
        }
    }
}
