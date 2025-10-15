using Contador_manual.models;

namespace Contador_manual
{
    public partial class MainPage : ContentPage
    {
        //_conteo lleva el conteo de la aplicacion
        private Contador contador;

        public MainPage()
        {
            InitializeComponent();
            contador = new Contador();
            ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void OnContarButtonClicked(object sender, EventArgs e)
        {
            contador.Contar();
            ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void OnReiniciarButtonClicked(object sender, EventArgs e)
        {
            contador.Reiniciar();
            ConteoLabel.Text = contador.Conteo.ToString();
        }
    }
}
