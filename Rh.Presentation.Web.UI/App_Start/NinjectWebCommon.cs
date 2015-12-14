[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Rh.Presentation.Web.UI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Rh.Presentation.Web.UI.App_Start.NinjectWebCommon), "Stop")]

namespace Rh.Presentation.Web.UI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Rh.Application.Interfaces;
    using Rh.Application;
    using Rh.Domain.Interfaces.Services;
    using Rh.Domain.Services;
    using Rh.Domain.Interfaces.Repositories;
    using Rh.Infra.Data.Repositories;
    using Rh.Infra.Data;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<ICandidatoAppService>().To<CandidatoAppService>();
            kernel.Bind<ITecnologiaAppService>().To<TecnologiaAppService>();
            kernel.Bind<IVagaAppService>().To<VagaAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ICandidatoService>().To<CandidatoService>();
            kernel.Bind<ITecnologiaService>().To<TecnologiaService>();
            kernel.Bind<IVagaService>().To<VagaService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ICandidatoRepository>().To<CandidatoRepository>();
            kernel.Bind<ITecnologiaRepository>().To<TecnologiaRepository>();
            kernel.Bind<IVagaRepository>().To<VagaRepository>();
        }        
    }
}
