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
    public partial class FrmCursos : Form
    {
        BindingSource dados;
        public FrmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridCursos.DataSource = dados;
        }

        private void chkboxVagas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidades cursos = new SalasEntidades();
            cursos.Id = Convert.ToInt32(txtboxId.Text);
            cursos.Nome = txtboxNome.Text;
            cursos.ano = Convert.ToInt32(txtboxAno.Text);
            cursos.periodo = txtboxPeriodo.Text;
            cursos.Disponivel = chkboxVagas.Checked;
            dados.Add(cursos);
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtboxId.Text = "";
            txtboxAno.Text = "";
            txtboxNome.Text = "";
            txtboxPeriodo.Text = "";
            chkboxVagas.Checked = false;
        }
    }
}
