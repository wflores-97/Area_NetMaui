namespace Area_NetMaui.Pages;

public partial class AreaRectangulo : ContentPage
{
	public AreaRectangulo()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (N1.Text==null || N1.Text=="")
        {
            Alerta("Ingrese el valor del ancho");
        }else if (N2.Text == null || N2.Text=="" )
        {
            Alerta("Ingrese el valor de la altura");
        }
        else
        {
            double n1, n2, resultado;
            n1 = double.Parse(N1.Text);
            n2 = double.Parse(N2.Text);

            resultado = n1 * n2;
            Resultado.Text = $"El area del rectangulo es de: {resultado} cm2";
        }

    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        N1.Text = "";
        N2.Text = "";
        Resultado.Text = "";

    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
    }
}