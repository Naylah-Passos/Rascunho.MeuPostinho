namespace MeuPostinhoAPI.Views;

public partial class AdminHomePage : ContentPage
{
	public AdminHomePage()
	{
		InitializeComponent();
	}
    private async void Agendar_Clicked(
        object sender,
        EventArgs e)
    {
        await Navigation.PushAsync(
            new AgendaMedica());
    }

    private async void Medicamentos_Clicked(
        object sender,
        EventArgs e)
    {
        await Navigation.PushAsync(
            new GerenciamentoMedicamentos());
    }

    private async void Consultas_Clicked(
        object sender,
        EventArgs e)
    {
        await Navigation.PushAsync(
            new RelatoriosPage());
    }

    private async void Logout_Clicked(
        object sender,
        EventArgs e)
    {
        bool confirmar = await DisplayAlert(
            "Sair",
            "Deseja realmente sair da conta administrativa?",
            "Sim",
            "Cancelar");

        if (confirmar)
        {
            await Navigation.PushAsync(
                new LoginPage());
        }
    }
}