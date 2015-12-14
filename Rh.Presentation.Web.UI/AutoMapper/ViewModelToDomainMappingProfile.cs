using AutoMapper;
using Rh.Domain.Entities;
using Rh.Presentation.Web.UI.ViewModels;

namespace Rh.Presentation.Web.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        /// <summary>
        ///     Método que transforma a classe de Dominio em uma classe ViewModel.
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Candidato, CandidatoViewModel>();
            Mapper.CreateMap<Tecnologia, TecnologiaViewModel>();
            Mapper.CreateMap<Vaga, VagaViewModel>();
        }
    }
}