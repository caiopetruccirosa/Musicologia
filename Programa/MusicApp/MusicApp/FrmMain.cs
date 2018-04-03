using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicApp
{
    public partial class FrmMain : Form
    {
        private SplashScreen splash;

        private string cs = Properties.Settings.Default.BD17197ConnectionString;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            splash = new SplashScreen();
            splash.Show();
            Thread.Sleep(3000);
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            splash.Hide();

            this.InicializarCampos();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // cria conexao ao banco de dados
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;

                // cria comando de consulta ao SQL 
                string cmd_s = "Select * from usuarioMusic where nome=@user and senha=@pwd";
                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@user", TxtLogEmail.Text);
                cmd.Parameters.AddWithValue("@pwd", TxtLogPassword.Text);

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    string rs = "usu : " + dr.ItemArray[1].ToString();
                    rs += "\n cargo : " + dr.ItemArray[2].ToString();
                    rs += "\n senha : " + dr.ItemArray[3].ToString();
                    MessageBox.Show(rs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LblCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();

            this.Hide();
            frmCadastro.FormClosed += (s, arg) => this.Show();
            frmCadastro.Show();
        }

        private void InserirPlaceholder(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.ForeColor = Color.Gray;

                if (txt == TxtLogEmail || txt == TxtCadEmail)
                {
                    txt.Text = "E-mail...";
                }
                else if (txt == TxtLogPassword || txt == TxtCadPassword)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = "Senha...";
                }
                else if (txt == TxtCadUsername)
                {
                    txt.Text = "Username...";
                }
                else if (txt == TxtCadConfPass)
                {
                    txt.Text = "Confirme a senha...";
                }
            }
        }

        private void RemoverPlaceholder(TextBox txt)
        {
            if (
                (
                 ((txt == TxtLogEmail || txt == TxtCadEmail) && txt.Text == "E-mail...") || 
                 ((txt == TxtLogPassword || txt == TxtCadPassword) && txt.Text == "Senha...") || 
                 (txt == TxtCadUsername && txt.Text == "Username...") || 
                 (txt == TxtCadConfPass && txt.Text == "Confirme a senha...")
                ) 
                && txt.ForeColor == Color.Gray
               )
            {
                if (txt == TxtLogPassword || txt == TxtCadPassword || txt == TxtCadConfPass)
                    txt.UseSystemPasswordChar = true;
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void InicializarCampos()
        {
            TxtLogEmail.Text = "E-mail...";
            TxtLogPassword.Text = "Senha...";

            TxtCadUsername.Text = "Username...";
            TxtCadPassword.Text = "Senha...";
            TxtCadConfPass.Text = "Confirmar Senha...";
            TxtCadEmail.Text = "E-mail...";

            TxtLogEmail.ForeColor = Color.Gray;
            TxtLogPassword.ForeColor = Color.Gray;

            TxtCadUsername.ForeColor = Color.Gray;
            TxtCadPassword.ForeColor = Color.Gray;
            TxtCadConfPass.ForeColor = Color.Gray;
            TxtCadEmail.ForeColor = Color.Gray;
        }

        private void TxtLogEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoverPlaceholder(TxtLogEmail);
        }

        private void TxtLogEmail_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(TxtLogEmail);
        }

        private void TxtLogEmail_Leave(object sender, EventArgs e)
        {
            InserirPlaceholder(TxtLogEmail);
        }

        private void TxtLogPassword_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(TxtLogPassword);
        }

        private void TxtLogPassword_Leave(object sender, EventArgs e)
        {
            InserirPlaceholder(TxtLogPassword);
        }

        private void TxtLogPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoverPlaceholder(TxtLogPassword);
        }

        private void TxtCadUsername_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(TxtCadUsername);
        }

        private void TxtCadUsername_Leave(object sender, EventArgs e)
        {
            InserirPlaceholder(TxtCadUsername);
        }

        private void TxtCadUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoverPlaceholder(TxtCadUsername);
        }
    }
}
