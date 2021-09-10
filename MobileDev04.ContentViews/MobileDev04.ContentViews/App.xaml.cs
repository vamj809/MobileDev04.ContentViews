using MobileDev04.ContentViews.Views;
using Xamarin.Forms;

namespace MobileDev04.ContentViews
{
    public partial class App : Application
    {
        public App() {
            InitializeComponent();

            MainPage = new MainMenuPage();
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
