using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Funcionario : Conexao
    {
        public int id;
        public int id_empresa;
        public int nivel;
        public string nome;
        public string email;
        public string senha;
        public DateTime data_cadastro;

        List<Funcionario> funcionario = new List<Funcionario>();

        public List<Funcionario> GetListaFuncionarios()
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionarios;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcionario novoFuncionario = new Funcionario();

                            novoFuncionario.id              = Convert.ToInt32(reader.GetString("id"));
                            novoFuncionario.id_empresa      = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoFuncionario.nome            = reader.GetString("nome");
                            novoFuncionario.email           = reader.GetString("email");
                            novoFuncionario.senha           = reader.GetString("senha");
                            novoFuncionario.nivel           = Convert.ToInt32(reader.GetString("nivel"));
                            novoFuncionario.data_cadastro   = DateTime.Parse(reader.GetString("data_cadastro"));

                         
                            funcionario.Add(novoFuncionario);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return funcionario;
        }

    }
}
