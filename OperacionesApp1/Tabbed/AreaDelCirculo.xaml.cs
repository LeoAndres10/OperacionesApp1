namespace OperacionesApp1.Tabbed;

public partial class AreaDelCirculo : ContentPage
{
	public AreaDelCirculo()
	{
		InitializeComponent();
	}

    private void txtCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (Validar())
            {
                double d, resultado;

                d = double.Parse(txtD.Text);

                if (d == 0)
                {
                    DisplayAlert("ADVERTENCIA", "El valor de la basee no puede ser igual a cero", "Aceptar");
                }
                
                else
                {
                    resultado = (Math.PI * (Math.Pow(d/2,2)));

                    txtX1.Text = resultado.ToString();

                }
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("ERROR", ex.Message, "Aceptar");
        }
    }

    private void txtLimpiar_Clicked(object sender, EventArgs e)
    {
        txtD.Text = "";
        txtX1.Text = "";
        txtD.Focus();
    }

    private bool Validar()
    {
        bool esValido = true;

        if (txtD.Text == "" || txtD.Text is null)
        {
            Alerta("Ingrese el diametro");
            esValido = false;
            txtD.Focus();
        }

        return esValido;
    }
    private void Alerta(string mensaje)
    {
        DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
    }

}