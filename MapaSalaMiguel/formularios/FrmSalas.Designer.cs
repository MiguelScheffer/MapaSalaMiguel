﻿
namespace MapaSala.Formularios
{
    partial class frmSalas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnomesala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numComputadores = new System.Windows.Forms.NumericUpDown();
            this.numCadeiras = new System.Windows.Forms.NumericUpDown();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.chkLaboratorio = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numComputadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnomesala
            // 
            this.txtnomesala.Location = new System.Drawing.Point(134, 130);
            this.txtnomesala.Name = "txtnomesala";
            this.txtnomesala.Size = new System.Drawing.Size(86, 20);
            this.txtnomesala.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Da Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº De Computador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº De Cadeiras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Formulário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(134, 298);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 20);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numComputadores
            // 
            this.numComputadores.Location = new System.Drawing.Point(134, 181);
            this.numComputadores.Name = "numComputadores";
            this.numComputadores.Size = new System.Drawing.Size(103, 20);
            this.numComputadores.TabIndex = 8;
            // 
            // numCadeiras
            // 
            this.numCadeiras.Location = new System.Drawing.Point(134, 229);
            this.numCadeiras.Name = "numCadeiras";
            this.numCadeiras.Size = new System.Drawing.Size(103, 20);
            this.numCadeiras.TabIndex = 9;
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(255, 96);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.RowTemplate.Height = 25;
            this.dtGridSalas.Size = new System.Drawing.Size(419, 258);
            this.dtGridSalas.TabIndex = 10;
            this.dtGridSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSalas_CellClick);
            // 
            // chkLaboratorio
            // 
            this.chkLaboratorio.AutoSize = true;
            this.chkLaboratorio.Location = new System.Drawing.Point(134, 254);
            this.chkLaboratorio.Name = "chkLaboratorio";
            this.chkLaboratorio.Size = new System.Drawing.Size(79, 17);
            this.chkLaboratorio.TabIndex = 11;
            this.chkLaboratorio.Text = "Laboratório";
            this.chkLaboratorio.UseVisualStyleBackColor = true;
            this.chkLaboratorio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(134, 276);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(77, 17);
            this.chkDisponivel.TabIndex = 12;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(64, 298);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(134, 324);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 20);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(57, 324);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 20);
            this.btnAtualizar.TabIndex = 45;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Pesquisa";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(255, 53);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(186, 20);
            this.txtpesquisa.TabIndex = 52;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 454);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkLaboratorio);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.numCadeiras);
            this.Controls.Add(this.numComputadores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomesala);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numComputadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnomesala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numComputadores;
        private System.Windows.Forms.NumericUpDown numCadeiras;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.CheckBox chkLaboratorio;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpesquisa;
    }
}