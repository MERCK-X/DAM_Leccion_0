using DAM_Leccion_0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_0.ViewModel
{
    public class MainPageViewModel
    {
        public PersonaModel personasModel { get; set; }

        public MainPageViewModel() 
        { 
            Consultar();
        }

        public void Consultar()
        {
            personasModel = new PersonaModel()
            {
                Nombre = "Janito",
                Apellido = "Alcachofas",
                Edad = "26",
            };

        }
    }
}
