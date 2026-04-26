using MeuPostinhoAPI.Helpers;
using MeuPostinhoAPI.Views;

namespace MeuPostinhoAPI
{
    public partial class App : Application
    {
        public static UsuarioHelper DbUsuario { get; set; }
        public static AgendamentoHelper DbAgendamento { get; set; }
        public static MedicamentoHelper DbMedicamento { get; set; }

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "meupostinho.db3");

            DbUsuario = new UsuarioHelper(dbPath);
            DbAgendamento = new AgendamentoHelper(dbPath);
            DbMedicamento = new MedicamentoHelper(dbPath);

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
