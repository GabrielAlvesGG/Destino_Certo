using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
namespace atividade2.Models
{
    public class PacotesTuristicosRepository
    {
        private const string conectaBanco = "DATABASE=destino_certo;Data Source=localhost; User id=root";

        /*          Testa conexão          */
        public void TextaConexao()
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            Console.WriteLine("conectou o banco Pacotes");
            conexao.Close();
        }
        /*          encerrando texte de conexão  */
        
        /*          iniciando InserirPacote(V)   */
        public void InserirPacote(PacotesTuristicos pacotes){

            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "INSERT INTO pacotesturisticos (NomeCliente, Origem, Destino, Atrativos,  Saida, Retorno) VALUES (@NomeCliente, @Origem, @Destino, @Atrativos, @Saida, @Retorno) ";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            
            comando.Parameters.AddWithValue("@NomeCliente", pacotes.NomeCliente);
            comando.Parameters.AddWithValue("@Origem", pacotes.Origem);
            comando.Parameters.AddWithValue("@Destino", pacotes.Destino);
            comando.Parameters.AddWithValue("@Atrativos", pacotes.Atrativos);
            comando.Parameters.AddWithValue("@Saida", pacotes.Saida);
            comando.Parameters.AddWithValue("@Retorno", pacotes.Retorno);

            comando.ExecuteNonQuery();
            conexao.Close();
        }
        /*         encerrando InserirPacote(V)    */

        /*           iniciando ListarPacotes(V)    */
        public List<PacotesTuristicos> ListarPacotes(PacotesTuristicos pacotest)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query ="SELECT * FROM pacotesturisticos ";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<PacotesTuristicos> lista = new List<PacotesTuristicos>();

            while(reader.Read())
            {
                PacotesTuristicos pacotes = new PacotesTuristicos();

                pacotes.idViagem = reader.GetInt32("idViagem");

                if(!reader.IsDBNull(reader.GetOrdinal("NomeCliente")))
                pacotes.NomeCliente = reader.GetString("NomeCliente");

                if(!reader.IsDBNull(reader.GetOrdinal("Origem")))
                pacotes.Origem = reader.GetString("Origem");

                if(!reader.IsDBNull(reader.GetOrdinal("Destino")))
                pacotes.Destino = reader.GetString("Destino");

                if(!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                pacotes.Atrativos = reader.GetString("Atrativos");

                pacotes.Saida = reader.GetDateTime("Saida");

                pacotes.Retorno = reader.GetDateTime("Retorno");

                lista.Add(pacotes);
            }
                conexao.Close();
                return lista;
        }
        /*      Encerrando ListarPacotes(V)          */
        
        /*    Iniciando Deletar(V)       */
        public void Deletar (int idViagem)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "DELETE FROM pacotesturisticos WHERE idViagem=@idViagem";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@idViagem", idViagem );
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        /*    encerrando Deletar(V)       */

        /*    Iniciando Atualizar()       */
        public void AtualizarPacotes(PacotesTuristicos pacotes)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "UPDATE pacotesturisticos SET NomeCliente=@NomeCliente, Origem=@Origem, Destino=@Destino, Atrativos=@Atrativos, Saida=@Saida, Retorno=@Retorno WHERE idViagem=@idViagem";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@idViagem", pacotes.idViagem);
            comando.Parameters.AddWithValue("@NomeCliente", pacotes.NomeCliente);
            comando.Parameters.AddWithValue("@Origem", pacotes.Origem);
            comando.Parameters.AddWithValue("@Destino", pacotes.Destino);
            comando.Parameters.AddWithValue("@Atrativos", pacotes.Atrativos);
            comando.Parameters.AddWithValue("@Saida", pacotes.Saida);
            comando.Parameters.AddWithValue("@Retorno", pacotes.Retorno);
            comando.ExecuteNonQuery();
            conexao.Close();   
        }
        /*    encerrando Atualizar()       */

        /*    Iniciando BuscarPorId()       */
        public PacotesTuristicos BuscarPorId(int idViagem)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "SELECT * FROM pacotesturisticos WHERE idViagem=@idViagem";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@idViagem", idViagem);
            MySqlDataReader reader = comando.ExecuteReader();

            PacotesTuristicos pacotesEncontrados = new PacotesTuristicos();

            while(reader.Read())
            {
                pacotesEncontrados.idViagem = reader.GetInt32("idViagem");
                
                if(!reader.IsDBNull(reader.GetOrdinal("NomeCliente")))
                pacotesEncontrados.NomeCliente =reader.GetString("NomeCliente");

                if(!reader.IsDBNull(reader.GetOrdinal("Origem")))
                pacotesEncontrados.Origem = reader.GetString("Origem");

                if(!reader.IsDBNull(reader.GetOrdinal("Destino")))
                pacotesEncontrados.Destino = reader.GetString("Destino");

                if(!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                pacotesEncontrados.Atrativos =reader.GetString("Atrativos");

                pacotesEncontrados.Saida = reader.GetDateTime("Saida");

                pacotesEncontrados.Retorno = reader.GetDateTime("Retorno");
            }
            conexao.Close();
            return pacotesEncontrados;
        }
        
        /*    encerrando BuscarPorId()       */
    }
}