using MySql.Data.MySqlClient;
using System.Data;

namespace UNIPRO_CUPOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=SERVIDOR;User Id=USUARIO;database=BANCO; password=SENHA");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM print_cupom WHERE key='" +  + "'", conexao);
            DataTable tabela = new DataTable();
            try
            {
                conexao.Open();
                gdvDados.DataSource = comando.ExecuteReader();
                gdvDados.DataBind();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}