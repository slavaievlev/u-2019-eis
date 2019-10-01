using Database.ApiImpl;
using EisDatabase;
using EisDatabase.Api;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Unity.Lifetime;

namespace EisView
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = BuildUnityContainer();

            container
                .Resolve<MainWindow>()
                .Show();
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<DbContext, EisDbContext>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IChartOfAccountsRepository, EFChartOfAccountsRepository>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<MainWindow, MainWindow>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}