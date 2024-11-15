using CadastroEventos.Models;

namespace CadastroEventos
{
    public partial class App : Application
    {
        public List<Local> local_selecionado = new List<Local>
        {
            new Local()
            {
                NomeLocal = "Salão de festa",
                ValorParticipante = 80.0
            },
            new Local()
            {
                NomeLocal = "Buffet",
                ValorParticipante = 200.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Cadastro());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var Window = base.CreateWindow(activationState);

            Window.Height = 600;
            Window.Width = 400;

            return Window;
        }
    }
}
