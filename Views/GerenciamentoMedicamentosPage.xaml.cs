using System.Collections.ObjectModel;
using MeuPostinhoAPI.Models;

namespace MeuPostinhoAPI.Views;

public partial class GerenciamentoMedicamentos : ContentPage
{
    private ObservableCollection<Medicamento> medicamentos =
      new ObservableCollection<Medicamento>();

    private Medicamento medicamentoSelecionado;

    public GerenciamentoMedicamentos()
	{
		InitializeComponent();

        listaMedicamentos.ItemsSource = medicamentos;

    }
    private async void Adicionar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text) ||
            string.IsNullOrWhiteSpace(txtDescricao.Text) ||
            string.IsNullOrWhiteSpace(txtQuantidade.Text))
        {
            await DisplayAlert("Erro", "Preencha todos os campos.", "OK");
            return;
        }

        if (!int.TryParse(txtQuantidade.Text, out int quantidade))
        {
            await DisplayAlert("Erro", "Quantidade inválida.", "OK");
            return;
        }

        medicamentos.Add(new Medicamento
        {
            Nome = txtNome.Text,
            Descricao = txtDescricao.Text,
            Quantidade = quantidade
        });

        LimparCampos();
    }

    private async void Editar_Clicked(object sender, EventArgs e)
    {
        if (medicamentoSelecionado == null)
        {
            await DisplayAlert("Aviso", "Selecione um medicamento.", "OK");
            return;
        }

        if (!int.TryParse(txtQuantidade.Text, out int quantidade))
        {
            await DisplayAlert("Erro", "Quantidade inválida.", "OK");
            return;
        }

        medicamentoSelecionado.Nome = txtNome.Text;
        medicamentoSelecionado.Descricao = txtDescricao.Text;
        medicamentoSelecionado.Quantidade = quantidade;

        AtualizarLista();
        LimparCampos();
    }

    private async void Remover_Clicked(object sender, EventArgs e)
    {
        if (medicamentoSelecionado == null)
        {
            await DisplayAlert("Aviso", "Selecione um medicamento.", "OK");
            return;
        }

        medicamentos.Remove(medicamentoSelecionado);

        medicamentoSelecionado = null;

        LimparCampos();
    }

    private void listaMedicamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        medicamentoSelecionado = e.CurrentSelection.FirstOrDefault() as Medicamento;

        if (medicamentoSelecionado != null)
        {
            txtNome.Text = medicamentoSelecionado.Nome;
            txtDescricao.Text = medicamentoSelecionado.Descricao;
            txtQuantidade.Text = medicamentoSelecionado.Quantidade.ToString();
        }
    }

    private void LimparCampos()
    {
        txtNome.Text = string.Empty;
        txtDescricao.Text = string.Empty;
        txtQuantidade.Text = string.Empty;

        listaMedicamentos.SelectedItem = null;
    }

    private void AtualizarLista()
    {
        listaMedicamentos.ItemsSource = null;
        listaMedicamentos.ItemsSource = medicamentos;
    }
}