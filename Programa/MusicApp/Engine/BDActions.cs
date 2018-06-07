using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net;

namespace Engine
{
    public enum PasswordScore
    {
        Blank = 0,
        VeryWeak = 1,
        Weak = 2,
        Medium = 3,
        Strong = 4,
        VeryStrong = 5
    }

    public static class BDActions
    {
        private static string cs = Properties.Settings.Default.BDConnectionString;

        private static bool ValidaCadastro(string username, string email, string pw, string confpw)
        {
            username = username.Trim();
            email = email.Trim();
            pw = pw.Trim();
            confpw = confpw.Trim();

            if (username == "" || email == "" || pw == "" || confpw == "")
                throw new Exception("Preencha todos os campos!");

            if (!CheckEmail(email))
                throw new Exception("E-mail inválido!");

            if (!pw.Equals(confpw))
                throw new Exception("As senhas são diferentes!");

            if (CheckPwStrength(pw) < PasswordScore.Medium)
                throw new Exception("Senha muito fraca!");

            if (username.Length < 2)
                throw new Exception("Username muito pequeno!");

            if (username.Length > 15)
                throw new Exception("Username muito grande!");

            if (email.Length > 40)
                throw new Exception("E-mail muito grande!");

            if (pw.Length > 40)
                throw new Exception("Senha muito grande!");

            return true;
        }

        private static bool ValidaLogin(string email, string pw)
        {
            if (email.Trim() == "" || pw.Trim() == "")
                throw new Exception("Preencha todos os campos!");

            if (!CheckEmail(email))
                throw new Exception("E-mail inválido!");

            return true;
        }

        private static string EncodePassword(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private static bool CheckEmail(string email)
        {
            string pattern = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, pattern))
            {
                if (Regex.Replace(email, pattern, string.Empty).Length == 0)
                    return true;
                return false;
            }
            else
                return false;
        }

        public static PasswordScore CheckPwStrength(string password)
        {
            int score = 1;
            if (password.Length < 1)
                return PasswordScore.Blank;
            if (password.Length < 4)
                return PasswordScore.VeryWeak;

            if (password.Length >= 8)
                score++;
            if (password.Length >= 12)
                score++;
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))
                score++;
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript))
                score++;
            if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript))
                score++;

            return (PasswordScore)score;
        }

        ////////////////////////////////////////////

        public static int Login(string email, string pw)
        {
            if (ValidaLogin(email, pw))
            {
                // cria conexao ao banco de dados
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

                // cria comando de consulta ao SQL 
                SqlCommand cmd = new SqlCommand("SELECT id FROM usuario WHERE email=@email AND pw=@pw", conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pw", EncodePassword(pw));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataRow dr = null;

                try
                {
                    //abre a conexao
                    conn.Open();
                    // executa a consulta
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dr = ds.Tables[0].Rows[0];
                        return Convert.ToInt32(dr.ItemArray[0].ToString());
                    }
                    else
                        return -1;
                }
                catch (Exception)
                {
                    throw new Exception("Erro no login");
                }
                finally
                {
                    // encerra a conexao
                    conn.Close();
                    conn.Dispose();
                }
            }

            return -1;
        }

        public static bool Cadastrar(string username, string email, string pw, string confpw)
        {
            //verifica se os dados são válidos
            if (ValidaCadastro(username, email, pw, confpw))
            {
                // cria conexao ao banco de dados
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

                SqlCommand cmd = new SqlCommand("SELECT id FROM usuario WHERE email=@email", conn);
                cmd.Parameters.AddWithValue("@email", email);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                //abre a conexao
                conn.Open();
                // executa a consulta
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                    throw new Exception("E-mail já usado!");

                conn = new SqlConnection();
                conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

                // cria comando de inserção ao SQL 
                cmd = new SqlCommand("INSERT INTO usuario VALUES(@username,  @email, @pw)", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pw", EncodePassword(pw));

                try
                {
                    //abre conexao
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
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

        public static string[] CarregarAlternativas(int numeroFase, int numeroPergunta) {
			// cria conexao ao banco de dados
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

            // cria comando de consulta ao SQL 
            SqlCommand cmd = new SqlCommand("EXEC sp_carregaralternativas @numeroFase, @numeroPergunta", conn);
            cmd.Parameters.AddWithValue("@numeroFase", numeroFase);
            cmd.Parameters.AddWithValue("@numeroPergunta", numeroPergunta);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            string[] alternativas = null;
            try
            {
                //abre a conexao
                conn.Open();
                // executa a consulta
                adapter.Fill(ds);

                DataTable table = ds.Tables[0];

                alternativas = new string[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                    alternativas[i] = table.Rows[i].ItemArray[0];
            }
            catch (Exception)
            {
                throw new Exception("Falha ao se comunicar com o banco de dados");
            }
            finally
            {
                // encerra a conexao
                conn.Close();
                conn.Dispose();
            }

            return alternativas;
        }

        public static void GuardarScore(int id, int fase, int score) {
            if (fase < 1 || fase > 6)
                throw new ArgumentOutOfRangeException();

            if (score < 0 || score > 3)
                throw new ArgumentOutOfRangeException();

            // cria conexao ao banco de dados
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

            SqlCommand cmd = new SqlCommand("EXEC sp_guardarscore @id, @fase, @score");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fase", fase);
            cmd.Parameters.AddWithValue("@score", score);

            try
            {
                //abre conexao
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Falha ao guardar score");
            }
            finally
            {
                //fecha conexao
                conn.Close();
                conn.Dispose();
            }
        }

        public static void FicarDisponivel(int id, IPAddress ip)
        {
            if (ip == null)
                throw new Exception("IP nulo");

            // cria conexao ao banco de dados
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

            SqlCommand cmd = new SqlCommand("EXEC sp_ficardisponivel @id, @ip");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ip", ip.ToString());

            try
            {
                //abre conexao
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Falha ao ficar indisponivel");
            }
            finally
            {
                //fecha conexao
                conn.Close();
                conn.Dispose();
            }
        }

        public static void FicarIndisponivel(int id)
        {
            // cria conexao ao banco de dados
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

            SqlCommand cmd = new SqlCommand("EXEC sp_ficarindisponivel @id");
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                //abre conexao
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Falha ao ficar indisponivel");
            }
            finally
            {
                //fecha conexao
                conn.Close();
                conn.Dispose();
            }
        }

        public static User[] UsuariosDisponiveis()
        {
            // cria conexao ao banco de dados
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

            // cria comando de consulta ao SQL 
            SqlCommand cmd = new SqlCommand("EXEC sp_usuariosdisponiveis", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            User[] users = null;
            try
            {
                //abre a conexao
                conn.Open();
                // executa a consulta
                adapter.Fill(ds);

                DataTable table = ds.Tables[0];
                DataRow dr = null;

                users = new User[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dr = table.Rows[i];

                    int id = (int)dr.ItemArray[0];
                    string username = (string)dr.ItemArray[1];
                    string ip = (string)dr.ItemArray[2];

                    users[i] = new User(id, username, ip);
                }
            }
            catch (Exception)
            {
                throw new Exception("Falha ao se comunicar com o banco de dados");
            }
            finally
            {
                // encerra a conexao
                conn.Close();
                conn.Dispose();
            }

            return users;
        }

        public static FaseDados[] FasesJogadas(int id)
        {
            // cria conexao ao banco de dados
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cs.Substring(cs.IndexOf("Data Source"));

            // cria comando de consulta ao SQL 
            SqlCommand cmd = new SqlCommand("EXEC sp_selecionarfases @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            FaseDados[] fases = null;
            try
            {
                //abre a conexao
                conn.Open();
                // executa a consulta
                adapter.Fill(ds);

                DataTable table = ds.Tables[0];
                DataRow dr = null;

                fases = new FaseDados[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dr = table.Rows[i];

                    int numero = (int)dr.ItemArray[0];
                    int pontuacao = (int) dr.ItemArray[1];

                    fases[i] = new FaseDados(numero, pontuacao);
                }
            }
            catch (Exception)
            {
                throw new Exception("Falha ao se comunicar com o banco de dados");
            }
            finally
            {
                // encerra a conexao
                conn.Close();
                conn.Dispose();
            }

            return fases;
        }
    }
}
