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

namespace MapaSala.Formularios
{
    public partial class frmSalas : Form
    {
        BindingSource dados;
        public frmSalas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidades sala = new SalasEntidades();
            sala.Nome = txtnomesala.Text;
            sala.IsLab = chkLaboratorio.Checked;
            sala.NumeroCadeiras = Convert.ToInt32(numCadeiras.Value);
            sala.NumeroComputador = Convert.ToInt32(numComputadores.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Add(sala);
            limpar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtnomesala.Text = "";
            numCadeiras.Text = "";
            numComputadores.Text = "";
            chkDisponivel.Checked = false;
            chkLaboratorio.Checked = false;
        }
    }
}
