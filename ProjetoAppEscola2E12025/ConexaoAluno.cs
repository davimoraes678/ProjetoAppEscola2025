using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAppEscola2E12025
{
    internal class ConexaoAluno
    {
        MySqlConnection conn;

        public void ConectarBD()
        {
            try
            {
                conn = new MySqlConnection("Persist Security info = false; server = localhost; database = bdescola; user=root; pwd=;");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }

        }

        public void ExecutarComandos(string sql)
        {
            try
            {
                //Abrir conexão
                ConectarBD();
                //Preparar o comando 
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Executar o comando
                cmd.ExecuteNonQuery();
                
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao executar o comando: " + ex.Message);
            }
            finally
            {
                //Fechar a conexão
                conn.Close();
            }
            
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao executar a consulta: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
