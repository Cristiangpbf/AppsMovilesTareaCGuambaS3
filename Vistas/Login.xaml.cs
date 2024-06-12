namespace cguambaS3.Vistas;

public partial class Login : ContentPage
{
    string user;
    string password;
	public Login()
	{
		InitializeComponent();
	}

	public Login(string usr, string pass)
	{        
        InitializeComponent();
        user = usr;
        password = pass;

    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && password == txtPassword.Text)
        {
            Navigation.PushAsync(new home(user));
        }else
        {
            DisplayAlert("Alerta!", "Usuario o contraseña incorrecto.", "OK");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new registro());
    }
}