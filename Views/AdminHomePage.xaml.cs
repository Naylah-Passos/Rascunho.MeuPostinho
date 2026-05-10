namespace MeuPostinhoAPI.Views;

public partial class AdminHomePage : ContentPage
{
	public AdminHomePage()
	{
		InitializeComponent();
	}
    private async void Agendar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AgendaMedica());
    }

    private async void Medicamentos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GerenciamentoMedicamentos());
    }

    private async void Consultas_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RelatoriosPage());
    }
}