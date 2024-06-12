namespace cguambaS3.Vistas;

public partial class registro : ContentPage
{
	public registro()
	{
		InitializeComponent();
	}

    private void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) 
            || string.IsNullOrWhiteSpace(txtPassword.Text) 
            || string.IsNullOrWhiteSpace(txtPasswordConf.Text))
        {
            DisplayAlert("Error", "Por favor, rellena todos los campos", "OK");
        }

        if (txtPasswordConf.Text == txtPassword.Text)
		{
            string usuario = txtUsuario.Text;
            string pass = txtPassword.Text;
            DisplayAlert("Atenci�n", "Usuario guardado", "ok");
            Navigation.PushAsync(new Login(usuario, pass));
        }
        else
        {
            DisplayAlert("Error", "Las contrase�as ingresadas no coinciden", "OK");
            txtPassword.Focus();
        }
		
    }
}