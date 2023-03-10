using Xamarin.Forms;

namespace CursoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraGrid();
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