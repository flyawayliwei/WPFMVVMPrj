using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication1.Shell;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // The boostrapper will create the Shell instance, so the App.xaml does not have a StartupUri.
            //程序启动后先加载MainWindows，接着执行bootstrapper.Run()，在ShellBootstrapper里面会加载ShellWindows
            ShellBootstrapper bootstrapper = new ShellBootstrapper();
            bootstrapper.Run();
        }
    }
}
