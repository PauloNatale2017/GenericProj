using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Project.Domain.Core.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {

        private IKernel ninjectKernnel;


        public NinjectControllerFactory()
        {
            ninjectKernnel = new StandardKernel();
            AdBinding();
        }

        //protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        //{
        //    return controllerType == null ? null : (IController)ninjectKernnel.Get(controllerType);
        //}


        private void AdBinding()
        {
            //ninjectKernnel.Bind<GlobalVisionVendor.Domain.Core.IRepositorio.IRepository<GlobalVisionVendor.Domain.MapEntities.Entities.CadastroEndereco>>().To<GlobalVisionVendor.Domain.Core.Repository.CadastroEnderecoRepository>();
           
        }



    }
}
