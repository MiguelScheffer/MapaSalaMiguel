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
        DataTable dados;
        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridSalas.DataSource = dados;
            foreach (var atributos in typeof(SalasEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("B",true,"21","21",true);
            
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

            dados.Rows.Add(sala.Linha());
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtnomesala.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            numComputadores.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            numCadeiras.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value);
            chkLaboratorio.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value = txtnomesala.Text;
            dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value = numCadeiras.Text;
            dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value = numComputadores.Text;
            dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value = chkDisponivel.Checked;
            dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value = chkLaboratorio.Checked;
        }
    }
}
