using Infrastructure;
using Infrastructure.ModuleTracking;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ModuleA
{
    public class ModuleA :IModule
    {
        private readonly ILoggerFacade logger;
        private readonly IModuleTracker moduleTracker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleA"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="moduleTracker">The module tracker.</param>      

        public ModuleA(ILoggerFacade logger, IModuleTracker moduleTracker)
        {
            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }

            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.logger = logger;

            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleA);
        }
        public void Initialize()
        {
            this.logger.Log("ModuleA demonstrates logging during Initialize().", Category.Info, Priority.Medium);
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleA);

            //throw new NotImplementedException();
        }
    }
}
