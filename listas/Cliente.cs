using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Cliente : Conexao
    {
        public int id;
        public int id_empresa;
        public string nome;
        private string documento;
        public string telefone;
        public string email;
        public DateTime data_cadastro;


        List<Cliente> clientes = new List<Cliente>();  
     
            
        public void setDocumento(string documento)
        {
            this.documento = documento; 
        }

        public string getDocumento() 
        {
            return this.documento;
        }

        public List<Cliente> GetListaClientes()
        {
            List<Cliente> cliente = new List<Cliente>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM clientes;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente novoCliente = new Cliente();

                            novoCliente.id              = Convert.ToInt32(reader.GetString("id"));
                            novoCliente.id_empresa      = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoCliente.nome            = reader.GetString("nome");
                            novoCliente.telefone        = reader.GetString("telefone");
                            novoCliente.email           = reader.GetString("email");
                            novoCliente.data_cadastro   = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoCliente.setDocumento(reader.GetString("documento"));

                            cliente.Add(novoCliente);

                        }

                        
                    }

                }

            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);   
            }

            return cliente;
        }

        
    }
}
