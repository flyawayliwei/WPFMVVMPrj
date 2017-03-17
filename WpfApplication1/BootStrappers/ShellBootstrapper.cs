using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1.Shell
{
    class ShellBootstrapper : UnityBootstrapper
    {
        // TODO: 02 - The Shell loads the EmployeeModule, as specified in the module catalog (ModuleCatalog.xaml).
        #region Private Fields

        private readonly CallbackLogger callbackLogger = new CallbackLogger();

        #endregion Private Fields

        #region Public Methods

        public Window GetShell()
        {
            return this.Shell as Window;
        }

        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);

            //显示球体遮罩窗口
            Window mask = (Window)this.Shell;
            mask.WindowState = WindowState.Maximized;
            mask.Show();
        }

        #endregion Public Methods

        #region Protected Methods

        protected override void ConfigureModuleCatalog()
        {
            //系统模块直接加载
            ModuleCatalog.AddModule(new ModuleInfo(ModuleNames.TopModule, typeof(TopModule).AssemblyQualifiedName));
            ModuleCatalog.AddModule(new ModuleInfo(ModuleNames.BottomModule, typeof(BottomModule).AssemblyQualifiedName));
            ModuleCatalog.AddModule(new ModuleInfo(ModuleNames.PublicToolbarModule, typeof(PublicToolBarModule).AssemblyQualifiedName));

            //功能模块文件夹中加载模块
            DirectoryModuleCatalog directoryCatalog = new DirectoryModuleCatalog() { ModulePath = System.Environment.CurrentDirectory + @"\Modules\" };
            ((AggregateModuleCatalog)ModuleCatalog).AddCatalog(directoryCatalog);
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new AggregateModuleCatalog();
        }

        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shells.MaskShell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
        }

    }
}
