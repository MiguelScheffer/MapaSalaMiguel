using MapaSala.DAO;
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
        }
    }
}
