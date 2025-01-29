using DAM_Leccion_0.Model;

namespace DAM_Leccion_0
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void Ejecutar()
        {
            PersonaModel personaModel = new PersonaModel();
            personaModel.Nombre = "Hola, aquitoi";
            //txtNombre.Text = "Hola, aquitoi";
        }
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD","Aceptar");
        }
    }

}
