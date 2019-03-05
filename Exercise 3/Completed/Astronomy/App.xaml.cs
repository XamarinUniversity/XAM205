using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace Astronomy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new Astronomy.MainPage());

            navPage.BarBackgroundColor = Color.Black;
            navPage.BarTextColor = Color.White;

            MainPage = navPage;
        }

        protected override async void OnStart()
        {
            base.OnStart();

            if (Current.Properties.ContainsKey("Name") == false)
            {
                await MainPage.Navigation.PushModalAsync(new PersonalizePage());
            }
        }
    }
}