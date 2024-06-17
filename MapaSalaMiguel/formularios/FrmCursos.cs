﻿using model.entidades;
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
        DataTable dados;
        int LinhaSelecionada;
        public FrmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridCursos.DataSource = dados;
            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("321","DS","2024","Integral","16");
            

        }

        private void chkboxVagas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursosEntidade cursos = new CursosEntidade(); // arumar 
            cursos.Id = Convert.ToInt32(txtboxId.Text);
            cursos.Nome = txtboxNome.Text;
            cursos.Ano = Convert.ToInt32(txtboxAno.Text);
            cursos.Periodo = txtboxPeriodo.Text;
            cursos.Vagas = chkboxVagas.Checked;
            dados.Rows.Add(cursos.Linha());
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridCursos.Rows.RemoveAt(LinhaSelecionada);

        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtboxId.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtboxNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtboxAno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtboxPeriodo.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[4].Value.ToString();
           
        }
    }
}
