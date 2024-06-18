using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormAtualizarApagarEstudante : Form
    {
        public FormAtualizarApagarEstudante()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Abre janela para pesquisar a imagem no computador.
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            int idAluno = Convert.ToInt32(textBoxID.Text);
       
            if(MessageBox.Show("Tem certeza que deseja apagar o aluno?", 
            "Apagar Estudante", MessageBoxButtons.YesNo, 
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (estudante.apagarEstudante(idAluno))
                {
                    MessageBox.Show("Aluno apagado!", "Apagar Estudante", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpa as coisas de texto.
                    textBoxID.Text = "";
                    textBoxNome.Text = "";
                    textBoxSobrenome.Text = "";
                    dateTimePickerNascimento.Text = "";
                    textBoxTelefone.Text = "";
                    textBoxEndereco.Text = "";
                    pictureBoxFoto.Text = "";

                }
            }
        
        
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
