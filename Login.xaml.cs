using JestrellaS3.Vistas;
using Microsoft.Maui.Controls;
using Microsoft.Win32;

namespace JestrellaS3;

public partial class Login : ContentPage
{
	private string[] users = { "Carlos", "Ana", "Jose" };
	private string[] passwords = { "carlos123", "ana123", "jose123" };
	public Login()
	{
		InitializeComponent();
	}

    private void btninicio_Clicked(object sender, EventArgs e)
    {
		string enteredUsername = txtusuario.Text;
		string enteredPassword = txtcontraseña.Text;

		// Verificar credenciales
		bool isValidCredentials = CheckCredentials(enteredUsername, enteredPassword);
        if (isValidCredentials)
        {
            // Mostrar mensaje de bienvenida
            DisplayAlert("Bienvenido", $"¡Hola {enteredUsername}!", "OK");
            Navigation.PushAsync(new Vistas.Calificaciones(enteredUsername));
        }
        else
        {
            // Mostrar mensaje de error
            DisplayAlert("Error", "Credenciales inválidas", "OK");
        }
    }
    private bool CheckCredentials(string username, string password)
    {
        // Verificar si las credenciales coinciden
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] == username && passwords[i] == password)
            {
                return true;
            }
        }

        return false;
    }
}

