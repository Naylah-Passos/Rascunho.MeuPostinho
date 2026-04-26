namespace MeuPostinhoAPI.Views;

public partial class MinhasConsultasPage : ContentPage
{
	public MinhasConsultasPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listaConsultas.ItemsSource = await App.DbAgendamento.GetAll();
    }
}