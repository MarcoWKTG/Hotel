namespace CadastroEventos.Views;

public partial class EventoCadastrado : ContentPage
{
	public EventoCadastrado()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}