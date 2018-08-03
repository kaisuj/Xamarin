using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHelloWorldApp.RelativeLayout;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinHelloWorldApp
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new RelativeLayoutExercise1();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
