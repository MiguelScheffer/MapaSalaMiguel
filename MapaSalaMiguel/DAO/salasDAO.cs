using System;
using System.Data;
using System.Data.SqlClient;
using model.entidades;

namespace MapaSala.DAO
{
    public class salasDAO
    {
        private readonly string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";

        public void Inserir(SalasEntidades salas)
        {
            using (var conexao = new SqlConnection(LinhaConexao))
            {
                conexao.Open();
                string query = "INSERT INTO Salas (Nome, Ano, Periodo, npcs, ncadeiras, Disponivel) VALUES (@nome, @ano, @periodo, @npcs, @ncadeiras, @disp)";

                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", salas.Nome);
                    comando.Parameters.AddWithValue("@ano", salas.ano);
                    comando.Parameters.AddWithValue("@periodo", salas.periodo);
                    comando.Parameters.AddWithValue("@npcs", salas.NumeroComputador);
                    comando.Parameters.AddWithValue("@ncadeiras", salas.NumeroCadeiras);
                    comando.Parameters.AddWithValue("@disp", salas.Disponivel);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Id, Nome FROM Salas";

            using (var connection = new SqlConnection(LinhaConexao))
            {
                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao acessar os dados: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }

        public DataTable obtersala()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Salas ORDER BY Id DESC";

            using (var conexao = new SqlConnection(LinhaConexao))
            {
                conexao.Open();
                using (var comando = new SqlCommand(query, conexao))
                {
                    using (var leitura = comando.ExecuteReader())
                    {
                        foreach (var atributos in typeof(SalasEntidades).GetProperties())
                        {
                            dt.Columns.Add(atributos.Name);
                        }

                        if (leitura.HasRows)
                        {
                            while (leitura.Read())
                            {
                                SalasEntidades salas = new SalasEntidades
                                {
                                    Id = Convert.ToInt32(leitura["Id"]),
                                    ano = Convert.ToInt32(leitura["ano"]),
                                    Nome = leitura["Nome"].ToString(),
                                    periodo = leitura["periodo"].ToString(),
                                    NumeroComputador = Convert.ToInt32(leitura["NumeroComputador"]),
                                    IsLab = Convert.ToBoolean(leitura["IsLab"]),
                                    NumeroCadeiras = Convert.ToInt32(leitura["NumeroCadeiras"]),
                                    Disponivel = Convert.ToBoolean(leitura["Disponivel"])
                                };

                                dt.Rows.Add(salas.Linha());
                            }
                        }
                    }
                }
            }

            return dt;
        }

        public DataTable pesquisar(string pesquisar)
        {
            DataTable dt = new DataTable();
            string query = string.IsNullOrEmpty(pesquisar) ?
                "SELECT Id, ano, Nome, periodo, NumeroComputador, IsLab, NumeroCadeiras, Disponivel FROM Salas ORDER BY Id DESC" :
                "SELECT Id, ano, Nome, periodo, NumeroComputador, IsLab, NumeroCadeiras, Disponivel FROM Salas WHERE Nome LIKE @pesquisar ORDER BY Id DESC";

            using (var conexao = new SqlConnection(LinhaConexao))
            {
                conexao.Open();
                using (var comando = new SqlCommand(query, conexao))
                {
                    if (!string.IsNullOrEmpty(pesquisar))
                    {
                        comando.Parameters.AddWithValue("@pesquisar", "%" + pesquisar + "%");
                    }

                    using (var leitura = comando.ExecuteReader())
                    {
                        foreach (var atributos in typeof(SalasEntidades).GetProperties())
                        {
                            dt.Columns.Add(atributos.Name);
                        }

                        if (leitura.HasRows)
                        {
                            while (leitura.Read())
                            {
                                SalasEntidades salas = new SalasEntidades
                                {
                                    Id = Convert.ToInt32(leitura["Id"]),
                                    ano = Convert.ToInt32(leitura["ano"]),
                                    Nome = leitura["Nome"].ToString(),
                                    periodo = leitura["periodo"].ToString(),
                                    NumeroComputador = Convert.ToInt32(leitura["NumeroComputador"]),
                                    IsLab = Convert.ToBoolean(leitura["IsLab"]),
                                    NumeroCadeiras = Convert.ToInt32(leitura["NumeroCadeiras"]),
                                    Disponivel = Convert.ToBoolean(leitura["Disponivel"])
                                };

                                dt.Rows.Add(salas.Linha());
                            }
                        }
                    }
                }
            }

            return dt;
        }
    }
}
