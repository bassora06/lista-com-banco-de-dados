using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente clientes = new Cliente();
            Funcionario funcionarios = new Funcionario();

            Console.WriteLine("\n--------------CLIENTES------------");

            foreach (Cliente cliente in clientes.GetListaClientes()) 
            {
                Console.WriteLine("Id: " + cliente.id );
                Console.WriteLine("Id da empresa: " + cliente.id_empresa);
                Console.WriteLine("Nome " + cliente.nome);
                Console.WriteLine("telefone: " + cliente.telefone);
                Console.WriteLine("Documento: " + cliente.getDocumento());
                Console.WriteLine("Email: " + cliente.email);
                Console.WriteLine("Data de cadastro: " + cliente.data_cadastro);
                Console.WriteLine("-----------------------------------------------");

                


            }

            Console.WriteLine("\n--------------FUNCIONARIOS------------");

            foreach (Funcionario funcionario in funcionarios.GetListaFuncionarios())
            {
                Console.WriteLine("Id: " + funcionario.id);
                Console.WriteLine("Id da empresa: " + funcionario.id_empresa);
                Console.WriteLine("Nome " + funcionario.nome);
                Console.WriteLine("telefone: " + funcionario.email);
                Console.WriteLine("Email: " + funcionario.senha);
                Console.WriteLine("Email: " + funcionario.nivel);
                Console.WriteLine("Data de cadastro: " + funcionario.data_cadastro);
                Console.WriteLine("-----------------------------------------------");




            }

            Console.ReadLine();

        }
    }
}
