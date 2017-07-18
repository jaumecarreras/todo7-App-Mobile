using Xamarin.Forms;

namespace todo7
{
    public partial class todo7Page : ContentPage
    {
        public todo7Page()
        {
            InitializeComponent();
        }

        public async System.Threading.Tasks.Task Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioEntry.Text) || string.IsNullOrEmpty(contrasena.Text))
            {
                resultadoLabel.Text = "Debe escribir usuario y contraseña";


            }
            else
            {
                resultadoLabel.Text = "Resultado exitoso";
                await Navigation.PushAsync(new ListaTareas());
            }
        }
    }
}
