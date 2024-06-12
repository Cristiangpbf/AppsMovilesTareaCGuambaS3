using cguambaS3.Vistas;

namespace cguambaS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.Login());
        }
    }
}
