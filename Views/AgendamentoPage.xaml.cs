using MeuPostinhoAPI.Models;
using MeuPostinhoAPI.Data;

namespace MeuPostinhoAPI.Views;

public partial class AgendamentoPage : ContentPage
{
    private Dictionary<string,
        List<string>>
        profissionaisPorUSAFa;

    public AgendamentoPage()
	{
		InitializeComponent();
        ConfigurarUSAFAs();
        ConfigurarHorarios();

        dataConsulta.MinimumDate = DateTime.Today;
    }

    private void ConfigurarUSAFAs()
    {
        pickerUSAFa.ItemsSource = new List<string>
        {
            "USAFA Aloha",
            "USAFA Anhanguera",
            "USAFA Antártica",
            "USAFA Aviação",
            "USAFA Boqueirão",
            "USAFA Caiçara",
            "USAFA Esmeralda",
            "USAFA Forte",
            "USAFA Guaramar",
            "USAFA Guilhermina",
            "USAFA Maracanã",
            "USAFA Melvi",
            "USAFA Melvi II",
            "USAFA Mirim I",
            "USAFA Mirim II",
            "USAFA Noêmia",
            "USAFA Ocian",
            "USAFA Princesa",
            "USAFA Quietude",
            "USAFA Real",
            "USAFA Ribeirópolis",
            "USAFA Rio Branco",
            "USAFA Samambaia",
            "USAFA Santa Marina",
            "USAFA São Jorge",
            "USAFA Solemar",
            "USAFA Tude Bastos",
            "USAFA Tupi",
            "USAFA Tupiry",
            "USAFA Vila Alice",
            "USAFA Vila Sônia"
        };

        profissionaisPorUSAFa = new Dictionary<string, List<string>>
        {
            {
                "USAFA Aloha",
                new List<string>
                {
                    "Dr. Carlos Silva - Clínico Geral",
                    "Dra. Ana Souza - Geriatria",
                    "Dr. Rafael Lima - Pediatria",
                    "Enf. Fernanda Costa"
                }
            }
        };
    }

    private void ConfigurarHorarios()
    {
        pickerHorario.ItemsSource = new List<string>
        {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"
        };
    }

    private void PickerUSAFa_SelectedIndexChanged(object sender, EventArgs e)
    {
        string usafaSelecionada = pickerUSAFa.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(usafaSelecionada))
            return;

        if (profissionaisPorUSAFa.ContainsKey(usafaSelecionada))
        {
            pickerMedico.ItemsSource =
                profissionaisPorUSAFa[usafaSelecionada];
        }
        else
        {
            pickerMedico.ItemsSource =
                new List<string>
                {
                    "Dr. João Oliveira - Clínico Geral",
                    "Dra. Marina Costa - Medicina da Família",
                    "Enf. Camila Santos",
                    "Dr. Ricardo Lima - Pediatria"
                };
        }
    }

    private async void BtnAgendar_Clicked(object sender, EventArgs e)
    {
        if (dataConsulta.Date.DayOfWeek ==
            DayOfWeek.Saturday ||
            dataConsulta.Date.DayOfWeek ==
            DayOfWeek.Sunday)
        {
            await DisplayAlert(
                "Atenção",
                "As USAFAs funcionam apenas de segunda a sexta-feira.",
                "OK");

            return;
        }

        if (pickerUSAFa.SelectedItem == null ||
            pickerMedico.SelectedItem == null ||
            pickerHorario.SelectedItem == null)
        {
            await DisplayAlert(
                "Erro",
                "Preencha todos os campos.",
                "OK");

            return;
        }

        Agendamento a = new Agendamento
        {
            Data = dataConsulta.Date,
            Hora = pickerHorario.SelectedItem.ToString(),
            Medico = pickerMedico.SelectedItem.ToString(),
            UBS = pickerUSAFa.SelectedItem.ToString(),
            Status = "Agendada",
            Usuario = "Paciente"
        };

        ConsultaTemp.Consultas.Add(a);

        await DisplayAlert("Sucesso", "Consulta agendada!", "OK");

        await Navigation.PushAsync(new AgendaMedica());
    }
}