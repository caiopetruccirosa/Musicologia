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
        private FrmJogo jogo;
        private string cs = Properties.Settings.Default.BD17197ConnectionString;

        private string phTxtLogEmail = "E-mail...";
        private string phTxtLogPassword = "Senha...";
        private string phTxtCadUsername = "Username...";
        private string phTxtCadPassword = "Senha...";
        private string phTxtCadConfPass = "Confirme a senha...";
        private string phTxtCadEmail = "E-mail...";

        public FrmMain()
        {
            InitializeComponent();
            InicializarCampos();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            splash = new SplashScreen();
            splash.Show();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            splash.Hide();

            PlLogin.Show();
            PlCadastro.Hide();
        }

        /////////////////////

        private void LblLogin_Click(object sender, EventArgs e)
        {
            PlCadastro.Hide();
            InicializarCampos();
            PlLogin.Show();
        }

        private void LblCadastro_Click(object sender, EventArgs e)
        {
            PlLogin.Hide();
            InicializarCampos();
            PlCadastro.Show();
        }

        /////////////////////

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int id;

            string email = TxtLogEmail.Text;
            string pw = TxtLogPassword.Text;

            if (email == this.phTxtLogEmail && TxtLogEmail.ForeColor == Color.Gray)
                email = "";

            if (pw == this.phTxtLogPassword && TxtLogPassword.ForeColor == Color.Gray && TxtLogPassword.UseSystemPasswordChar == false)
                pw = "";

            try
            {
                id = Engine.BDActions.Login(email, pw);
                if (id > 0)
                {
                    jogo = new FrmJogo(id);

                    this.Hide();
                    jogo.FormClosed += (s, arg) => this.Close();
                    jogo.Show();
                }
                else
                    SinalizarAviso(LblAvisoLogin, "E-mail ou senha incorreto!");
            }
            catch (Exception ex)
            {
                SinalizarAviso(LblAvisoLogin, ex.Message);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string username = TxtCadUsername.Text;
            string email = TxtCadEmail.Text;
            string pw = TxtCadPassword.Text;
            string confpw = TxtCadConfPass.Text;

            if (username == this.phTxtCadUsername && TxtCadUsername.ForeColor == Color.Gray)
                username = "";

            if (email == this.phTxtCadEmail && TxtCadEmail.ForeColor == Color.Gray)
                email = "";

            if (pw == this.phTxtCadPassword && TxtCadPassword.ForeColor == Color.Gray && TxtCadPassword.UseSystemPasswordChar == false)
                pw = "";

            if (confpw == this.phTxtCadConfPass && TxtCadConfPass.ForeColor == Color.Gray && TxtCadConfPass.UseSystemPasswordChar == false)
                confpw = "";

            try
            {
                if (Engine.BDActions.Cadastrar(username, email, pw, confpw))
                    SinalizarAviso(LblAvisoCadastro, "Cadastrado com sucesso!");
                else
                    SinalizarAviso(LblAvisoCadastro, "Ocorreu algum erro!");    
            }
            catch (Exception ex)
            {
                SinalizarAviso(LblAvisoCadastro, ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            splash.Dispose();
            if (jogo != null)
                jogo.Dispose();
            this.Dispose();
        }

        /////////////////////////////////////////////////////////
     
        private void SinalizarAviso(Label lbl, string str)
        {
            lbl.Visible = true;
            lbl.Text = str;
        }

        private void InicializarCampos()
        {
            TxtLogEmail.Text = this.phTxtLogEmail;
            TxtLogPassword.Text = this.phTxtLogPassword;

            TxtCadUsername.Text = this.phTxtCadUsername;
            TxtCadPassword.Text = this.phTxtCadPassword;
            TxtCadConfPass.Text = this.phTxtCadConfPass;
            TxtCadEmail.Text = this.phTxtCadEmail;

            TxtLogPassword.UseSystemPasswordChar = false;
            TxtCadPassword.UseSystemPasswordChar = false;
            TxtCadConfPass.UseSystemPasswordChar = false;

            TxtLogEmail.ForeColor = Color.Gray;
            TxtLogPassword.ForeColor = Color.Gray;

            TxtCadUsername.ForeColor = Color.Gray;
            TxtCadPassword.ForeColor = Color.Gray;
            TxtCadConfPass.ForeColor = Color.Gray;
            TxtCadEmail.ForeColor = Color.Gray;

            LblAvisoLogin.Visible = false;
            LblAvisoCadastro.Visible = false;

            LblAvisoLogin.Text = "Aviso";
            LblAvisoCadastro.Text = "Aviso";
        }

        private void InserirPlaceholder(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.ForeColor = Color.Gray;

                if (txt == TxtLogEmail)
                {
                    txt.Text = this.phTxtLogEmail;
                }
                else if (txt == TxtCadEmail)
                {
                    txt.Text = this.phTxtCadEmail;
                }
                else if (txt == TxtLogPassword)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = this.phTxtLogPassword;
                }
                else if (txt == TxtCadPassword)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = this.phTxtCadPassword;
                }
                else if (txt == TxtCadUsername)
                {
                    txt.Text = this.phTxtCadUsername;
                }
                else if (txt == TxtCadConfPass)
                {
                    txt.Text = this.phTxtCadConfPass;
                }
            }
        }

        private void RemoverPlaceholder(TextBox txt)
        {
            if (
                (
                 (txt == TxtLogEmail && txt.Text == this.phTxtLogEmail) ||
                 (txt == TxtCadEmail && txt.Text == this.phTxtCadEmail) ||
                 (txt == TxtLogPassword && txt.Text == this.phTxtLogPassword) ||
                 (txt == TxtCadPassword && txt.Text == this.phTxtCadPassword) ||
                 (txt == TxtCadUsername && txt.Text == this.phTxtCadUsername) ||
                 (txt == TxtCadConfPass && txt.Text == this.phTxtCadConfPass)
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

        private void TxtCadEmail_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(TxtCadEmail);
        }

        private void TxtCadEmail_Leave(object sender, EventArgs e)
        {
            InserirPlaceholder(TxtCadEmail);
        }

        private void TxtCadEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoverPlaceholder(TxtCadEmail);
        }

        private void TxtCadPassword_Leave(object sender, EventArgs e)
        {
            InserirPlaceholder(TxtCadPassword);
        }

        private void TxtCadPassword_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(TxtCadPassword);
        }

        private void TxtCadPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoverPlaceholder(TxtCadPassword);
        }

        private void TxtCadConfPass_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(TxtCadConfPass);
        }

        private void TxtCadConfPass_Leave(object sender, EventArgs e)
        {
            InserirPlaceholder(TxtCadConfPass);
        }

        private void TxtCadConfPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoverPlaceholder(TxtCadConfPass);
        }
    }
}
