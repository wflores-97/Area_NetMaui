using Xamarin.Google.Crypto.Tink.Aead.Internal;

namespace Area_NetMaui.Pages;

public partial class AreaCirculo : ContentPage
{
	public AreaCirculo()
	{
		InitializeComponent();
	}

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        if(Radio.Text==null || Radio.Text == "")
        {
            Alerta("Ingrese el radio del circulo");
        }
        else
        {
            double radio, resultado, redondear;
            radio = double.Parse(Radio.Text);

            resultado =Math.PI*Math.Pow(radio,2);
            redondear = Math.Round(resultado,2);
            Resultado.Text = $"El area del circulo es de: {redondear} cm2";
        }

    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        Radio.Text = "";
        Resultado.Text = "";

    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
    }
}