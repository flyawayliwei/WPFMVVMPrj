using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.BaseClasses;

namespace WpfApplication1
{
    public class NavBarItem : INotifyPropertyChanged
    {
        public string ID { get { return Guid.NewGuid().ToString(); } }
        public string ItemName { get; set; }
        public string ItemProperty { get; set; }
        public List<NavBarItem> Children { get; set; }
        public NavBarItem()
        {
            Children = new List<NavBarItem>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 00构造及初始化
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion
        #region 01私有变量
        /// <summary>
        /// 工具条ToggleButton对象字典
        /// </summary>
        private static Dictionary<string, ToggleButton> ToolBarToggleButtonDic = new Dictionary<string, ToggleButton>();
        #endregion
        #region 02公开变量
        #endregion
        #region 03事件注册
        public delegate void ControlsLoadedEventHandler(object sender, RoutedEventArgs e);
        protected ControlsLoadedEventHandler CommonLoadedControls = ViewLoadHelper.getInstance().CommonLoadedControlsMethod;
        
        #endregion
        #region 04事件方法(点击，选中等事件)
        /// <summary>
        /// 右侧工具条按钮选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolButton_Checked(object sender, RoutedEventArgs e)
        {
            Control control = sender as Control;
            string tag = control.Tag.ToString();
            switch (control.Tag.ToString())
            {
                default: break;
            }
        }
        /// <summary>
        /// 右侧工具条按钮取消选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Control control = sender as Control;
            string tag = control.Tag.ToString();
            switch (control.Tag.ToString())
            {
                default: break;
            }
        }
        /// <summary>
        /// 工具条ToggleButton加载注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolBarLoaded(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleBt = sender as ToggleButton;
            if (toggleBt != null && !string.IsNullOrEmpty(toggleBt.Tag.ToString()))
            {
                // 如果字典已存在该Key则重置该项
                if (ToolBarToggleButtonDic.ContainsKey(toggleBt.Tag.ToString()))
                {
                    ToolBarToggleButtonDic.Remove(toggleBt.Tag.ToString());
                }
                ToolBarToggleButtonDic.Add(toggleBt.Tag.ToString(), toggleBt);
            }
        }

        #endregion
        #region 05私有方法
        #region 主题色切换

        private void ThemeButton_Checked(object sender, RoutedEventArgs e)
        {
            ViewLoadHelper.getInstance().RestAllBackaground(false);
        }
        private void ThemeButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ViewLoadHelper.getInstance().RestAllBackaground(true);
        }
        #endregion
        #endregion
        #region 06公开方法
        #endregion

    }

   
}
