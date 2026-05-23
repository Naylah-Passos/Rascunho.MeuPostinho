using MeuPostinhoAPI.Services;

namespace MeuPostinhoAPI.Views;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;

    public LoginPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var savedEmail = Preferences.Get("saved_email", string.Empty);

        if (!string.IsNullOrEmpty(savedEmail))
        {
            txtEmail.Text = savedEmail;
            chkRemember.IsChecked = true;
        }

        txtEmail.Focus();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        try
        {
            string email = txtEmail?.Text?.Trim();
            string senha = txtSenha?.Text?.Trim();

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha))
            {
                await DisplayAlert(
                    "Campos obrigatórios",
                    "Preencha email e senha.",
                    "OK");
                return;
            }

            // ADMIN
            if (email == "admin@teste.com" &&
                senha == "123")
            {
                await DisplayAlert(
                    "Sucesso",
                    "Login administrativo realizado!",
                    "OK");

                await Navigation.PushAsync(new AdminHomePage());
                return;
            }

            // USUÁRIO
            if (email == "user@teste.com" &&
                senha == "123")
            {
                await DisplayAlert(
                    "Sucesso",
                    "Login realizado!",
                    "OK");

                await Navigation.PushAsync(new HomePage());
                return;
            }

            await DisplayAlert(
                "Erro",
                "Email ou senha inválidos.",
                "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert(
                "Erro inesperado",
                ex.Message,
                "OK");
        }
    }

    private void OnEmailCompleted(object sender, EventArgs e)
    {
        txtSenha.Focus();
    }

    private void OnSenhaCompleted(object sender, EventArgs e)
    {
        OnLoginClicked(sender, EventArgs.Empty);
    }

    private async void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResetPasswordPage());
    }

    private async void OnCadastrarTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new CadastroPage());
    }


}