namespace OperacionesApp1.Tabbed;

public partial class AreaDelCuadrado : ContentPage
{

	public AreaDelCuadrado()
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

                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                if (a == 0)
                {
                    DisplayAlert("ADVERTENCIA", "El valor del lado no puede ser igual a cero", "Aceptar");
                }
                else if (b == 0)
                {
                    DisplayAlert("ADVERTENCIA", "El valor del lado no puede ser igual a cero", "Aceptar");
                }else
                {
                    resultado = (a * b);
                     
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
        txtA.Focus();
    }

    private bool Validar()
    {
        bool esValido = true;

        if (txtA.Text == "" || txtA.Text is null)
        {
            Alerta("Ingrese valor del lado");

            esValido = false;
            txtA.Focus();
        }
        else if (txtB.Text == "" || txtB.Text is null)
        {
            Alerta("Ingrese valor del lado ");
            esValido = false;
            txtB.Focus();
        }

        return esValido;
    }
    private void Alerta(string mensaje)
    {
        DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
    }
}