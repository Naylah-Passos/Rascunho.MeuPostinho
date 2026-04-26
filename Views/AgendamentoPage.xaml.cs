using MeuPostinhoAPI.Models;

namespace MeuPostinhoAPI.Views;

public partial class AgendamentoPage : ContentPage
{
	public AgendamentoPage()
	{
		InitializeComponent();
	}

    private async void BtnAgendar_Clicked(object sender, EventArgs e)
    {

        Agendamento a = new Agendamento
        {
            Data = dataConsulta.Date,
            Medico = txtMedico.Text,
            UBS = txtUBS.Text
        };

        await App.DbAgendamento.Insert(a);

        await DisplayAlert("Sucesso", "Consulta agendada!", "OK");
    }
}