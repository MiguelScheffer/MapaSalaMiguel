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
    public partial class FrmUsuarios : Form
    {
        BindingSource dados;
        public FrmUsuarios()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridUsuarios.DataSource = dados;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuario = new UsuariosEntidade();
            usuario.Id = Convert.ToInt32(txtboxId.Text);
            usuario.Login = txtboxLogin.Text;
            usuario.Senha = txtboxSenha.Text;
            usuario.Nome = txtboxNome.Text;
            usuario.Ativo = chkboxAtivo.Checked;
            dados.Add(usuario);
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()

        {
            txtboxId.Text = "";
            txtboxLogin.Text = "";
            txtboxNome.Text = "";
            txtboxSenha.Text = "";
            chkboxAtivo.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridUsuarios.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
