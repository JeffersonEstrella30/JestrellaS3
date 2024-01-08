namespace JestrellaS3.Vistas;

public partial class Calificaciones : ContentPage
{
    string usuario1;
	public Calificaciones(string enteredUsername)
	{
		InitializeComponent();
        lblUsuarios.Text = "Usuario Conectado: " + enteredUsername;
        usuario1 = enteredUsername;
    }

    private void btncalcular_Clicked(object sender, EventArgs e)
    {

    }

    private void btncalcular1_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        double nSeguimiento1 = Convert.ToDouble(txtNota.Text) * 0.3;
        double examen1 = Convert.ToDouble(txtExamen.Text) * 0.2;
        double nSeguimiento2 = Convert.ToDouble(txtNota2.Text) * 0.3;
        double examen2 = Convert.ToDouble(txtExamen2.Text) * 0.2;
        double nParcial1 = nSeguimiento1 + examen1;
        double nParcial2 = nSeguimiento2 + examen2;
        double nFinal = nParcial1 + nParcial2;

        string fecha = dpFecha.Date.ToString("M/d/yyyy");

        if (nFinal > 7)
        {
            DisplayAlert("Notas Finales", "\nNombre: " + nombre + "\nFecha " + fecha + "\nNota Parcial 1: " + nParcial1 +
                "\nNota Parcial 2 " + nParcial2 + " \nNota final " + nFinal + " \n Estado: Aprobado", "Cerrar");
            txtNombre.Text = "";
            txtNota.Text = "";
            txtExamen.Text = "";
            txtNota2.Text = "";
            txtExamen2.Text = "";
        }
        if (nFinal >= 5 && nFinal <= 6.9)
        {
            DisplayAlert("Notas Finales", "\nNombre: " + nombre + "\nFecha " + fecha + "\nNota Parcial 1: " + nParcial1 +
                "\nNota Parcial 2 " + nParcial2 + " \nNota final " + nFinal + " \nEstado: Complementario", "Cerrar");
            txtNombre.Text = "";
            txtNota.Text = "";
            txtExamen.Text = "";
            txtNota2.Text = "";
            txtExamen2.Text = "";
        }
        if (nFinal < 5)
        {
            DisplayAlert("Notas Finales", "\nNombre: " + nombre + "\nFecha " + fecha + "\nNota Parcial 1: " + nParcial1 +
                "\nNota Parcial 2 " + nParcial2 + " \nNota final " + nFinal + " \nEstado:  Reprobado", "Cerrar");
            txtNombre.Text = "";
            txtNota.Text = "";
            txtExamen.Text = "";
            txtNota2.Text = "";
            txtExamen2.Text = "";
        }
    }
}
