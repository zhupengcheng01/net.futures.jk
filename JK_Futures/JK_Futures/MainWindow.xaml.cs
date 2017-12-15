using JK_Futures.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JK_Futures
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainvm = null;
        public MainWindow()
        {
            InitializeComponent();
            mainvm = new MainWindowViewModel();
            this.DataContext = mainvm;
        }
        #region 主窗口功能
     
 

        private void SwitchMaxAndNomal()
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;

            }
            else if (this.WindowState == WindowState.Normal)
            {
               
                this.WindowState = WindowState.Maximized;
            }
        }

      

  

        private void State_OnClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;
            switch (button.Name)
            {
                case "Max":
                    SwitchMaxAndNomal();
                    break;
                case "Min":
                    WindowState = WindowState.Minimized;
                    break;
                case "Close":
                    if (MessageBox.Show(this, "您确定要退出吗？", "提示", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {

                        Close();
                    }
                    break;
            }
        }
        #endregion
    }
}
