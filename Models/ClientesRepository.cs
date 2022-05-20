using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
namespace atividade2.Models
{
    public class ClientesRepository
    {
        private const string conectaBanco = "DATABASE=destino_certo;Data Source= localhost; User Id=root;";
        /*            TestandoConexao(V)            */
        public void TestaConexao()
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            Console.WriteLine("Funfa");
            conexao.Close();
        }
        /*            TestandoConexao(V)            */


        /*         iniciando Inserir(V)             */
        public void Inserir(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "INSERT INTO usuario (nome, login, senha, dataNascimento) VALUES ( @nome, @login, @senha, @dataNascimento)";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@login", cliente.login);
            comando.Parameters.AddWithValue("@senha", cliente.senha);
            comando.Parameters.AddWithValue("@dataNascimento", cliente.dataNascimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        /*           encerrando o Inserir(V)         */

        /*           Iniciando ListaClientes(V)      */
        public List<Cliente> ListarClientes(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "SELECT * FROM usuario";
            MySqlCommand comando = new MySqlCommand(query, conexao );
            MySqlDataReader reader = comando.ExecuteReader();

            List<Cliente> lista = new List<Cliente>();

            while(reader.Read())
            {
                Cliente clienteEncontrado = new Cliente();

                clienteEncontrado.id = reader.GetInt32("id");

                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                clienteEncontrado.nome = reader.GetString("nome");

                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                clienteEncontrado.login = reader.GetString("login");

                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                clienteEncontrado.senha = reader.GetString("senha");

                clienteEncontrado.dataNascimento = reader.GetDateTime("dataNascimento");

                lista.Add(clienteEncontrado);
            }
            conexao.Close();
            return lista;
        }
        /*      encerrando ListaClientes(V)          */
        
        /*            Iniciando Deletar(V)           */
        public void Deletar(int id)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "DELETE FROM usuario WHERE id=@id";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        /*             Encerrando Deletar(V)         */

        /*              Iniciando Atualizar(V)        */
        public void Atualizar(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            
            string query ="UPDATE usuario SET nome=@nome, login=@login, senha=@senha, dataNascimento=@dataNascimento WHERE id=@id";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            
            comando.Parameters.AddWithValue("@id", cliente.id);
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@login", cliente.login);
            comando.Parameters.AddWithValue("@senha", cliente.senha);
            comando.Parameters.AddWithValue("@dataNascimento", cliente.dataNascimento);

            comando.ExecuteNonQuery();
            conexao.Close();
        }
        /*             encerrando Atualizar(V)          */

        /*             Iniciando BuscarPorId(V)         */
        
        public Cliente BuscarPorId(int id)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "SELECT * FROM usuario WHERE id=@id";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();

                Cliente clienteEncontrado = new Cliente();
            if(reader.Read())
            {
                clienteEncontrado.id = reader.GetInt32("id");

                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                clienteEncontrado.nome= reader.GetString("nome");

                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                clienteEncontrado.login = reader.GetString("login");

                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                clienteEncontrado.senha = reader.GetString("senha");

                clienteEncontrado.dataNascimento = reader.GetDateTime("dataNascimento");
            }
            conexao.Close();
            return clienteEncontrado;

        }
        /*             encerrando BuscarPorId(V)        */

        /*             Iniciando   ValidandoCliente()   */
        public Cliente ValidandoCliente(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "SELECT * FROM usuario WHERE login=@login AND senha=@senha";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@login", cliente.login);
            comando.Parameters.AddWithValue("@senha", cliente.senha);
            MySqlDataReader reader = comando.ExecuteReader();
            
            Cliente Buscado = null;

            if(reader.Read())
            {
                Buscado = new Cliente();

                Buscado.id = reader.GetInt16("id");
                
                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                Buscado.nome = reader.GetString("nome");

                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                Buscado.login = reader.GetString("login");

                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                Buscado.senha = reader.GetString("senha");

                Buscado.dataNascimento = reader.GetDateTime("dataNascimento");
            }
            conexao.Close();
            return Buscado;
        }
        /*             Encerrando   ValidandoCliente()   */
    }
        
        
}