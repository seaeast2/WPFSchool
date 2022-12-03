using LoginUI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LoginUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show();
            // 로그인창이 닫히면 메인 윈도우 실행
            loginView.IsVisibleChanged += (s, ev) =>
            {
                // 로그인창이 실행된적이 있으면서, 안보이는 상태면 실행
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    var MainWindow = new MainWindow();
                    MainWindow.Show();
                    loginView.Close();
                }
            };
        }
    }
}
