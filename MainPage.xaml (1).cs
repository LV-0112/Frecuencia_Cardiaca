namespace frecuencia_cardiaca
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {
            if (int.TryParse(txtLatidos.Text, out int latidos15Seg))
            {
                int frecuenciaCardiaca = latidos15Seg * 4;

                string mensaje = "";

                if (frecuenciaCardiaca < 60)
                {
                    mensaje = $"Frecuencia cardiaca: {frecuenciaCardiaca} bpm - Frecuencia cardiaca baja";
                }
                else if (frecuenciaCardiaca > 100)
                {
                    mensaje = $"Frecuencia cardiaca: {frecuenciaCardiaca} bpm - Frecuencia cardiaca alta";
                }
                else
                {
                    mensaje = $"Frecuencia cardiaca: {frecuenciaCardiaca} bpm - Frecuencia cardiaca normal";
                }
                lblResultado.Text = mensaje;
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese un valor numérico válido.";
            }
        }
    }
}
