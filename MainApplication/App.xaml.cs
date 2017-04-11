using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MainApplication.Shell;
using MainApplication.Views;

namespace MainApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


          
            LoginWnd.getInstance().ShowDialog();
          
          
            // The boostrapper will create the Shell instance, so the App.xaml does not have a StartupUri.
            //程序启动执行bootstrapper.Run()，在ShellBootstrapper里面会加载ShellWindows，后加载MainWindows
            ShellBootstrapper bootstrapper = new ShellBootstrapper();
            bootstrapper.Run();


        }
    }
}
