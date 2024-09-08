namespace OperacionesApp1.Tabbed;

public partial class AreaDelRectangulo : ContentPage
{
	public AreaDelRectangulo()
	{
		InitializeComponent();
	}

    private void txtCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (Validar())
            {
                double a, b, resultado;

                b = double.Parse(txtB.Text);
                a = double.Parse(txtA.Text);

                if (a == 0)
                {
                    DisplayAlert("ADVERTENCIA", "El valor de la basee no puede ser igual a cero", "Aceptar");
                } else if (b == 0)
                {
                    DisplayAlert("ADVERTENCIA", "El valor de la altura no puede ser igual a cero", "Aceptar");
                }
                else
                {
                resultado = (b * a);

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
        txtA.Text = "";
        txtB.Text = "";
        txtX1.Text = "";
        txtB.Focus();
    }

    private bool Validar()
    {
        bool esValido = true;

        if (txtB.Text == "" || txtB.Text is null)
        {
            Alerta("Ingrese la base");
            esValido = false;
            txtB.Focus();
        }else if(txtA.Text== "" || txtA.Text is null)
        {

            Alerta("Ingrese la altura");
            esValido = false;
            txtA.Focus();
        }


        return esValido;
    }
    private void Alerta(string mensaje)
    {
        DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
    }


}
