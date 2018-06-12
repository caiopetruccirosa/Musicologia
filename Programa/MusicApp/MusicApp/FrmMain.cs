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
using Engine.DBO;

namespace MusicApp
{
    public partial class FrmMain : Form
    {
        private SplashScreen splash;
        private FrmJogo jogo;
        private string cs = Properties.Settings.Default.BD17197ConnectionString;

        private const string phTxtLogEmail = "E-mail...";
        private const string phTxtLogPassword = "Senha...";
        private const string phTxtCadUsername = "Username...";
        private const string phTxtCadPassword = "Senha...";
        private const string phTxtCadConfPass = "Confirme a senha...";
        private const string phTxtCadEmail = "E-mail...";

        private bool podeVerificar = false;

        public FrmMain()
        {
            InitializeComponent();
            InicializarCampos();

            splash = new SplashScreen();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            splash.Show();
            Application.DoEvents();

            Thread.Sleep(2000);
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
            string email = TxtLogEmail.Text;
            string pw = TxtLogPassword.Text;

            if (email == phTxtLogEmail && TxtLogEmail.ForeColor == Color.Gray)
                email = "";

            if (pw == phTxtLogPassword && TxtLogPassword.ForeColor == Color.Gray && TxtLogPassword.UseSystemPasswordChar == false)
                pw = "";

            try
            {
                User jogador = Engine.BDActions.Login(email, pw);
                if (jogador != null)
                {
                    jogo = new FrmJogo(jogador);

                    this.Hide();
                    jogo.Show();
                    jogo.FormClosing += (s, arg) =>
                    {
                        if (jogo.Deslogado)
                        {
                            jogo.Dispose();
                            jogo = null;
                            this.Show();
                            this.InicializarCampos();
                        }
                        else
                            this.Close();
                    };
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

            if (username == phTxtCadUsername && TxtCadUsername.ForeColor == Color.Gray)
                username = "";

            if (email == phTxtCadEmail && TxtCadEmail.ForeColor == Color.Gray)
                email = "";

            if (pw == phTxtCadPassword && TxtCadPassword.ForeColor == Color.Gray && TxtCadPassword.UseSystemPasswordChar == false)
                pw = "";

            if (confpw == phTxtCadConfPass && TxtCadConfPass.ForeColor == Color.Gray && TxtCadConfPass.UseSystemPasswordChar == false)
                confpw = "";

            try
            {
                if (Engine.BDActions.Cadastrar(username, email, pw, confpw))
                {
                    InicializarCampos();
                    SinalizarAviso(LblAvisoCadastro, "Cadastrado com sucesso!");
                }
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
            TxtAux.Focus();

            TxtLogEmail.Text = phTxtLogEmail;
            TxtLogPassword.Text = phTxtLogPassword;

            TxtCadUsername.Text = phTxtCadUsername;
            TxtCadPassword.Text = phTxtCadPassword;
            TxtCadConfPass.Text = phTxtCadConfPass;
            TxtCadEmail.Text = phTxtCadEmail;

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

            LblPWStrength.Visible = false;
            LblPWErro.Visible = false;
        }

        private void InserirPlaceholder(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.ForeColor = Color.Gray;

                if (txt == TxtLogEmail)
                {
                    txt.Text = phTxtLogEmail;
                }
                else if (txt == TxtCadEmail)
                {
                    txt.Text = phTxtCadEmail;
                }
                else if (txt == TxtLogPassword)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = phTxtLogPassword;
                }
                else if (txt == TxtCadPassword)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = phTxtCadPassword;
                }
                else if (txt == TxtCadConfPass)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = phTxtCadConfPass;
                }
                else if (txt == TxtCadUsername)
                {
                    txt.Text = phTxtCadUsername;
                }
            }
        }

        private void RemoverPlaceholder(TextBox txt)
        {
            if (
                (
                 (txt == TxtLogEmail && txt.Text == phTxtLogEmail) ||
                 (txt == TxtCadEmail && txt.Text == phTxtCadEmail) ||
                 (txt == TxtLogPassword && txt.Text == phTxtLogPassword) ||
                 (txt == TxtCadPassword && txt.Text == phTxtCadPassword) ||
                 (txt == TxtCadUsername && txt.Text == phTxtCadUsername) ||
                 (txt == TxtCadConfPass && txt.Text == phTxtCadConfPass)
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

        private void CheckPasswords(TextBox txtPw, TextBox txtConfPw)
        {
            if (txtPw.ForeColor == Color.Black && txtPw.UseSystemPasswordChar == true &&
                txtConfPw.ForeColor == Color.Black && txtConfPw.UseSystemPasswordChar == true &&
                !(txtPw.Text.Trim() == "" || txtConfPw.Text.Trim() == ""))
            {
                if (!txtPw.Text.Equals(txtConfPw.Text))
                    LblPWErro.Visible = true;
                else
                    LblPWErro.Visible = false;

                this.podeVerificar = true;
            }
            else
                LblPWErro.Visible = false;
        }

        private void CheckStrength(TextBox txtPw)
        {
            if (txtPw.ForeColor == Color.Black && txtPw.UseSystemPasswordChar == true && txtPw.Text.Trim() != "")
            {
                int strength = (int)Engine.BDActions.CheckPwStrength(txtPw.Text);

                switch (strength)
                {
                    case 1:
                        LblPWStrength.Text = "Força: Muito fraca";
                        LblPWStrength.Visible = true;
                        break;
                    case 2:
                        LblPWStrength.Text = "Força: Fraca";
                        LblPWStrength.Visible = true;
                        break;
                    case 3:
                        LblPWStrength.Text = "Força: Média";
                        LblPWStrength.Visible = true;
                        break;
                    case 4:
                        LblPWStrength.Text = "Força: Forte";
                        LblPWStrength.Visible = true;
                        break;
                    case 5:
                        LblPWStrength.Text = "Força: Muito forte";
                        LblPWStrength.Visible = true;
                        break;
                    default:
                        if (strength > 5)
                        {
                            LblPWStrength.Text = "Força: Muito forte";
                            LblPWStrength.Visible = true;
                        }
                        else
                            LblPWStrength.Visible = false;
                        break;
                }
            }
            else
                LblPWStrength.Visible = false;
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

        private void TxtCadConfPass_TextChanged(object sender, EventArgs e)
        {
            this.CheckPasswords(TxtCadPassword, TxtCadConfPass);
        }

        private void TxtCadPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.podeVerificar)
                this.CheckPasswords(TxtCadPassword, TxtCadConfPass);
            this.CheckStrength(TxtCadPassword);
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (PlLogin.Visible == true && PlCadastro.Visible == false)
                    BtnLogin_Click(new object(), new EventArgs());
                else if (PlCadastro.Visible == true && PlLogin.Visible == false)
                    BtnCadastrar_Click(new object(), new EventArgs());
            }

        }
    }
}
