namespace MeuPostinhoAPI.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
        {
            await DisplayAlert("Erro", "Preencha todos os campos", "OK");
            return;
        }

        if (email == "admin@teste.com" && senha == "123")
        {
            await DisplayAlert("Sucesso", "Login realizado!", "OK");

        }
        else
        {
            await DisplayAlert("Erro", "Email ou senha inválidos", "OK");
        }
    }

    private async void OnCadastrarTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Cadastro", "Abrindo tela de cadastro...", "OK");

        await Navigation.PushAsync(new CadastroPage());
    }
}