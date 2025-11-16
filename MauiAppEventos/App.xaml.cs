using MauiAppEventos.Models;
namespace MauiAppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Contratacao());
        }

        protected override Window CreateWindow(IActivationState activationState)
        {

            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;
            return window;
        }
    }
}
