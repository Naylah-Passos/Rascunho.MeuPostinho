namespace MeuPostinhoAPI.Views;

public partial class RelatoriosPage : ContentPage
{
	public RelatoriosPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Dados simulados para apresentação
        lblConsultasAgendadas.Text = "18";
        lblConsultasRealizadas.Text = "12";
        lblMedicamentos.Text = "7";
        lblBaixoEstoque.Text = "2";
    }
}