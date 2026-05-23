using MeuPostinhoAPI.Services;

namespace MeuPostinhoAPI.Views;

public partial class CadastroPage : ContentPage
{
	public CadastroPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        txtSenha.IsPassword = !txtSenha.IsPassword;
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string cpf = txtCPF.Text;
        string email = txtEmail.Text;
        string telefone = txtTelefone.Text;
        string senha = txtSenha.Text;

        if (string.IsNullOrWhiteSpace(nome) ||
            string.IsNullOrWhiteSpace(cpf) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(telefone) ||
            string.IsNullOrWhiteSpace(senha))
        {
            await DisplayAlert("Erro", "Preencha todos os campos!", "OK");
            return;
        }

        await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso!", "OK");

        await Navigation.PopAsync();
    }
}