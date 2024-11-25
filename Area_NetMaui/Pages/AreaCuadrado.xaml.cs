namespace Area_NetMaui.Pages;

public partial class AreaCuadrado : ContentPage
{
	public AreaCuadrado()
	{
		InitializeComponent();
	}

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        N1.Text = "";
        N2.Text = "";
        Resultado.Text = "";
        N1.Focus();

    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

        if (N1.Text == null || N1.Text == "")
        {
            Alerta("Ingrese el valor del lado 1");
        }else if (N2.Text == null || N2.Text == "")
        {
            Alerta("Ingrese el valor del lado 2");
        }
        else
        {
            double n1, n2, area;
            n1= double.Parse(N1.Text);
            n2= double.Parse(N2.Text);

            area = n1 * n2;
            Resultado.Text = $"El area del cuadrado es: {area} cm2";
            
        }

    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
    }
}