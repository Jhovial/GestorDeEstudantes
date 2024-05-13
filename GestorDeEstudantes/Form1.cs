using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
                
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            // Cria um objeto da classe "MeuBancoDeDados"
            MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable tabelaDeDados = new DataTable();  
            MySqlCommand comandoSql= new MySqlCommand("", meuBancoDeDados.getConexao);

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
