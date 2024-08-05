using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using model.entidades;

namespace MapaSalaMiguel.DAO
{
    public class ProfessorDAO
    {
        private string linhaConexao = "SErver=L505MPF;Database=AULA_05;User id=sa;Password=admsql";
        private SqlConnection Conexao;
        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
    }
    public void Inserir(ProfessoresEntidade professor)
    {
        Conexao.Open();
        string query = "Insert into Professores () Values ()";
        SqlCommand Comando = new SqlCommand(query, Conexao);
        SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
        SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
        Comando.Parameters.Add(parametro1);
        Comando.Parameters.Add(parametro2;
        Comando.ExecuteNonQuery();

    }
}
