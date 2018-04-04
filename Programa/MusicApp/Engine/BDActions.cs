using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Engine
{
    public class BDActions
    {
        private static string cs = Properties.Settings.Default.BDConnectionString;

        public static Boolean Cadastrar(string username, string pw, string email) {
            //verifica se os dados são válidos
            if (ValidaCadastro(username, pw, email))
            {
                // cria conexao ao banco de dados
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

                // cria comando de inserção ao SQL 
                SqlCommand cmd = new SqlCommand("INSERT INTO usuario VALUES(@username,  @email, @pw, @points, @fase)", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pw", Base64Encode(pw));
                cmd.Parameters.AddWithValue("@points", 0);
                cmd.Parameters.AddWithValue("@fase", 1);

                try
                {
                    //abre conexao
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro no cadastro");
                }
                finally
                {
                    //fecha conexao
                    conn.Close();
                    conn.Dispose();
                }
            }

            return false;
        }

        private static Boolean ValidaCadastro(string username, string pw, string email)
        {
            return true;
        }

        private static Boolean ValidaLogin(string email, string pw)
        {
            return true;
        }

        public static int Login(string email, string pw)
        {
            if (ValidaLogin(email, pw))
            {
                // cria conexao ao banco de dados
                SqlConnection con = new SqlConnection();
                con.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

                // cria comando de consulta ao SQL 
                SqlCommand cmd = new SqlCommand("SELECT id FROM usuario WHERE email=@email AND pw=@pw", con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pw", Base64Encode(pw));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataRow dr = null;

                try
                {
                    //abre a conexao
                    con.Open();
                    // executa a consulta
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count >= 1)
                    {
                        dr = ds.Tables[0].Rows[0];
                        return Convert.ToInt32(dr.ItemArray[0].ToString());
                    }
                    return -1;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro no login");
                }
                finally
                {
                    // encerra a conexao
                    con.Close();
                    con.Dispose();
                }
            }

            return -1;
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
