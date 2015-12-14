using AutoMapper;

namespace Rh.Presentation.Web.UI.AutoMapper
{
    public class AutoMapperConfig
    {
        /// <summary>
        ///     Método que faz o registro dos mapeamentos.
        /// </summary>
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}