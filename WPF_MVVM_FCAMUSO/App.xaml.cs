using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_MVVM_FCAMUSO
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var personeService = new Models.PersoneService();
            var mainWindowViewModel = new ViewModels.MainWindowViewModel(personeService);
            var mainWindows = new MainWindow(mainWindowViewModel);

            //var mainWindows = new MainWindow(new Models.PersoneService());
            mainWindows.Show();
        }
    }
}
