using AutoMapper;
using Rh.Domain.Entities;
using Rh.Presentation.Web.UI.ViewModels;

namespace Rh.Presentation.Web.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        ///     Método que transforma a ViewModel em uma classe de domínio.
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<CandidatoViewModel, Candidato>();
            Mapper.CreateMap<TecnologiaViewModel, Tecnologia>();
            Mapper.CreateMap<VagaViewModel, Vaga>();
        }
    }
}