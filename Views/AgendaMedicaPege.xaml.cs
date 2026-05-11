namespace MeuPostinhoAPI.Views;
using MeuPostinhoAPI.Models;

public partial class AgendaMedica : ContentPage
{
	public AgendaMedica()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Lista simulada de agendamentos
        var lista = new List<Agendamento>
        {
            new Agendamento
            {
                Usuario = "Maria Oliveira",
                Medico = "Dr. João Silva",
                UBS = "UBS Central",
                Data = new DateTime(2026, 04, 25),
                Hora = "09:00",
                Status = "Pendente"
            },

            new Agendamento
            {
                Usuario = "Carlos Mendes",
                Medico = "Dra. Ana Costa",
                UBS = "UBS Norte",
                Data = new DateTime(2026, 04, 28),
                Hora = "14:30",
                Status = "Confirmada"
            },

            new Agendamento
            {
                Usuario = "Fernanda Lima",
                Medico = "Dr. Paulo Souza",
                UBS = "UBS Sul",
                Data = new DateTime(2026, 05, 02),
                Hora = "11:00",
                Status = "Realizada"
            }
        };

        cvAgendamentos.ItemsSource = lista;
    }
}