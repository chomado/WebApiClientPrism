using Autofac;
using Prism.Autofac;
using Prism.Autofac.Forms;
using WebApiClientPrism.Views;
using Xamarin.Forms;

namespace WebApiClientPrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("AppNavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<AppNavigationPage>();
        }
    }
}
