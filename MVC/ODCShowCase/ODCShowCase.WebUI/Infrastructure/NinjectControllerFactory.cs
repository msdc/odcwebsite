using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using ODCShowCase.Domain.Concrete;
using ODCShowCase.Domain.Entities;
using ODCShowCase.Domain.Abstract;

namespace ODCShowCase.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBings()
        {
            ninjectKernel.Bind<IShowCaseRepository>().To<EFShowCaseRepostory>();
            ninjectKernel.Bind<INewsRepository>().To<EFNewsRepostory>();
        }
    }
}