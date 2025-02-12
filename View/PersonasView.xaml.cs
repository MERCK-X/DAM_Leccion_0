using DAM_Leccion_0.ViewModel;
namespace DAM_Leccion_0.View;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		InitializeComponent();

		BindingContext = new PersonasViewModel();


	}
}