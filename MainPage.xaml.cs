using DAM_Leccion_0.Model;
using DAM_Leccion_0.ViewModel;

namespace DAM_Leccion_0
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        
        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

        

        //EVENTO ACEPTAR
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD","Aceptar");
            //personaModel.Nombre = "Mamerto";
            //personaModel.Apellido = "Rodaciano";
            //personaModel.Edad = "15";

        }
    }

}
