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
    public class TecnologiaAppService : AppServiceBase<Tecnologia>, ITecnologiaAppService
    {
        private readonly ITecnologiaService _tecnologiaService;

        public TecnologiaAppService(ITecnologiaService tecnologiaService)
            : base(tecnologiaService)
        {
            _tecnologiaService = tecnologiaService;
        }
    }
}
