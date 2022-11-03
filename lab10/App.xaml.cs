using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace lab10
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Entities context;
        public App()
        {
            context = Entities.GetContext();
        }
        protected override void OnStartup(StartupEventArgs e)
        { 
            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
