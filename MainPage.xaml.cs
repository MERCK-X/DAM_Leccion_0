using DAM_Leccion_0.Model;

namespace DAM_Leccion_0
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public PersonaModel personaModel { get; set; }
        
        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

        public void Ejecutar()
        {
            personaModel = new PersonaModel()
            {
                Nombre = "Hola, aquitoi",
            };

            BindingContext = personaModel;

            //Binding personaBinding = new Binding();
            //personaBinding.Source = personaModel;//Origen
            //personaBinding.Path = "Nombre";//Ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding);//Destino final

            //personaModel.Nombre = "Hola, aquitoi";
            //txtNombre.Text = "Hola, aquitoi";
        }

        //EVENTO ACEPTAR
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD","Aceptar");
            personaModel.Nombre = "Juanito Alcachofas";
        }
    }

}
