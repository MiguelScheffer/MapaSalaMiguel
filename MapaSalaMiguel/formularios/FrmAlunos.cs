using model.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSalaMiguel.formularios
{
    public partial class FrmAlunos : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public FrmAlunos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridAlunos.DataSource = dados;
        }

        private void chkboxVagas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AlunoEntidade aluno = new AlunoEntidade();
            aluno.ID = Convert.ToInt32(txtboxID.Text);
            aluno.nome = txtboxNome.Text;
            aluno.idade = Convert.ToInt32(txtboxIdade.Text);
            aluno.sala = Convert.ToInt32(txtboxSala.Text);
            aluno.apelido = txtBoxApelido.Text;
            aluno.estudante = chkboxEstudante.Checked;
            dados.Add(aluno);
            limpar();
                }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtboxID.Text = "";
            txtboxNome.Text = "";
            txtboxIdade.Text = "";
            txtBoxApelido.Text = "";
            txtboxSala.Text = "";
            chkboxEstudante.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridAlunos.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
