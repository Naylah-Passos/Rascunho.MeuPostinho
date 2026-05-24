namespace MeuPostinhoAPI.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void Agendar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AgendamentoPage());
    }

    private async void Medicamentos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MedicamentoPage());
    }

    private async void Consultas_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MinhasConsultasPage());
    }

    private async void Logout_Clicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert(
            "Sair",
            "Deseja realmente sair da conta?",
            "Sim",
            "Cancelar");

        if (confirmar)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}