using Xamarin.Forms;

namespace todo7
{
    public partial class App : Application
    {
        public static string RutaBD;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new todo7Page());
        }

        public App(string rutaBD)
        {


			InitializeComponent();

            RutaBD = rutaBD;

			MainPage = new NavigationPage(new todo7Page());


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
