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
    public partial class FrmDisciplina : Form
    {
        BindingSource dados;
        public FrmDisciplina()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridDisciplina.DataSource = dados;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade disciplina = new DisciplinasEntidade();
            disciplina.ID = Convert.ToInt32(txtboxId.Text);
            disciplina.nome = txtboxNome.Text;
            disciplina.sigla = txtboxSigla.Text;
            disciplina.ativo = chkboxAtivo.Checked;
            dados.Add(disciplina);
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtboxNome.Text = "";
            txtboxId.Text = "";
            txtboxSigla.Text = "";
            chkboxAtivo.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
