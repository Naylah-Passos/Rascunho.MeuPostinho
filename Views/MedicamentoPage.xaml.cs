namespace MeuPostinhoAPI.Views;

public partial class MedicamentoPage : ContentPage
{
	public MedicamentoPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listaMedicamentos.ItemsSource = await App.DbMedicamento.GetAll();
    }
}