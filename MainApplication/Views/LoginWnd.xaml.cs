using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainApplication.Views
{
    /// <summary>
    /// Interaction logic for LoginWnd.xaml
    /// </summary>
    public partial class LoginWnd : Window
    {
        private static LoginWnd loginWnd = null;
        public static LoginWnd getInstance()
        {
            if (loginWnd ==null)
	        {
                loginWnd = new LoginWnd();
	        }
            return loginWnd;
        }
        private LoginWnd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWnd.getInstance().Hide();
        }
    }
}
