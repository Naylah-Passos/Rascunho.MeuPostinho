namespace MeuPostinhoAPI.Views;

public partial class CadastroPage : ContentPage
{
	public CadastroPage()
	{
		InitializeComponent();
	}

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string cpf = txtCPF.Text;
        string email = txtEmail.Text;
        string telefone = txtTelefone.Text;
        string senha = txtSenha.Text;

        if (string.IsNullOrWhiteSpace(nome) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(senha))
        {
            await DisplayAlert("Erro", "Preencha todos os campos obrigatórios!", "OK");
            return;
        }

        await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso!", "OK");

        await Navigation.PopAsync();
    }
}