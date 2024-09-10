using MapaSala.DAO;
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
    public partial class frmCursoDisciplina : Form
    {
        disciplinasDAO disciplinasDAO = new disciplinasDAO();
        cursosDAO cursosDAO = new cursosDAO();
        public frmCursoDisciplina()
        {
            InitializeComponent();
            cbDisciplinas.DataSource = disciplinasDAO.PreencherComboBox();
            cbDisciplinas.DisplayMember = "Nome";
            cbDisciplinas.ValueMember = "Id";

            cbxCursos.DataSource = cursosDAO.PreencherComboBox();
            cbxCursos.DisplayMember = "Nome";
            cbxCursos.ValueMember = "Id";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCursoDisciplina_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CursoDisciplinaDAO cursoDisciplinaDAO = new CursoDisciplinaDAO();
            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();
            entidade.CursoId = Convert.ToInt32(cbxCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(cbDisciplinas.SelectedValue);
            entidade.Periodo = comboperiodo.SelectedItem.ToString();
            cursoDisciplinaDAO.Inserir(entidade);
        }
        /*      public long Id { get; set; }
        public long DisciplinaId { get; set; }
        public long CursoId { get; set; }
        public string Periodo { get; set; }
        public string NomeDisciplina { get; set; }
        public string NomeCurso { get; set; }
        public object[] Linha()
        {
            return new object[] { Id, NomeCurso, NomeDisciplina };*/
    }
}
