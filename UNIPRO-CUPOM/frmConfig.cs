using MySql.Data.MySqlClient;
using System.Data;

namespace UNIPRO_CUPOM
{
    public partial class frmConfig : Form
    {

        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            banco dadosBanco = new banco();
            txtHost.Text = dadosBanco.host;
            txtUsuario.Text = dadosBanco.user;
            txtSenha.Text = dadosBanco.password;
            txtPorta.Text = dadosBanco.port;
            txtDatabase.Text = dadosBanco.database;
        }

        private void btnSalvarBanco_Click(object sender, EventArgs e)
        {
            banco dadosBanco = new banco();
            dadosBanco.host = txtHost.Text;
            dadosBanco.user = txtUsuario.Text;
            dadosBanco.password = txtSenha.Text;
            dadosBanco.port = txtPorta.Text;
            dadosBanco.database = txtDatabase.Text;
            dadosBanco.Save();
            MessageBox.Show("Dados Alterados!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
