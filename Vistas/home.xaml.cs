namespace cguambaS3.Vistas;

public partial class home : ContentPage
{
	public home(string nombre)
	{
		InitializeComponent();
		lblNombre.Text = nombre;
	}
}