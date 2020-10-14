using Xamarin.Forms;
using EndlessEntities.Core.Models;
using EndlessEntities.Data;
using EndlessEntities.UI.Controllers;
using EndlessEntities.Core.Services;
using EndlessEntities.Services.Services;
using Unity;
using CommonServiceLocator;
using Unity.ServiceLocation;
using System.ComponentModel;

namespace EndlessEntities
{
    public partial class App : Application
    {
        public static UnityContainer Container { get; } = new UnityContainer();

        public App()
        {
            InitializeComponent();

            Container.RegisterSingleton<IDataStore<Entity>, MockDataStore>();
            Container.RegisterType<IEntityService<Entity>, EntityService>();
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(Container));

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}