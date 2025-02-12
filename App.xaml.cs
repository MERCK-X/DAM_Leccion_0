using DAM_Leccion_0.View;

namespace DAM_Leccion_0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            MainPage = new PersonasView();
        }
    }
}
