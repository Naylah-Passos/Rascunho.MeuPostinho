using MeuPostinhoAPI.Data;

namespace MeuPostinhoAPI.Views;

public partial class MinhasConsultasPage : ContentPage
{
	public MinhasConsultasPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        consultasCollection.ItemsSource =
            null;

        consultasCollection.ItemsSource =
            ConsultaTemp.Consultas;
    }
}