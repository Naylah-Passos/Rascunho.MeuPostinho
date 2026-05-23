namespace MeuPostinhoAPI.Views;

public partial class ResetPasswordPage : ContentPage
{
	public ResetPasswordPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        txtEmail.Focus();
    }

    private async void OnSendClicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text?.Trim();

        if (string.IsNullOrWhiteSpace(email))
        {
            await DisplayAlert(
                "Campo obrigatório",
                "Digite um email válido.",
                "OK");

            return;
        }

        await DisplayAlert(
            "Recuperação enviada",
            "Se este email estiver cadastrado, você receberá as instruções para redefinir sua senha.",
            "OK");

        await Navigation.PopAsync();
    }

    private async void OnBackTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}