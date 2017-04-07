using Infrastructure.ModuleTracking;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Modules
{
    class AppToolBarModule:IModule
    {
         #region Private Fields

        private readonly IRegionViewRegistry regionViewRegistry;

        #endregion Private Fields

        #region Public Constructors

        public AppToolBarModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        #endregion Public Constructors

        #region Public Methods

        public void Initialize()
        {
            //region注册
            regionViewRegistry.RegisterViewWithRegion(WellKnownModuleNames.AppToolBarModule, typeof(Views.AppToolBar));
        }

        #endregion Public Methods
    }
}
