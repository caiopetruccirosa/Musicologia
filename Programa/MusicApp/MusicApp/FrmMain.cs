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

        public FrmMain()
        {
            InitializeComponent();
            InicializarCampos();
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

            PlLogin.Show();
            PlCadastro.Hide();
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            PlLogin.Show();
            PlCadastro.Hide();
        }

        private void LblCadastro_Click(object sender, EventArgs e)
        {
            PlLogin.Hide();
            PlCadastro.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Engine.BDActions.Login(TxtLogEmail.Text, TxtLogPassword.Text);
                if (id > 0)
                {
                    jogo = new FrmJogo(id);

                    this.Hide();
                    jogo.Show();
                    jogo.FormClosed += (s, arg) => this.Close();
                }
                else
                {
                    SinalizarAviso(LblAvisoLogin, "E-mail ou senha incorreto!");
                }
            }
            catch (Exception ex)
            {
                SinalizarAviso(LblAvisoLogin, ex.Message);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Engine.BDActions.Cadastrar(TxtCadUsername.Text, TxtCadPassword.Text, TxtCadEmail.Text))
                {
                    SinalizarAviso(LblAvisoCadastro, "Cadastrado com sucesso!");
                }
                else
                {
                    SinalizarAviso(LblAvisoCadastro, "Ocorreu algum erro!");
                }
                    
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

        /// //////////////////////////////////////////////////////
     
        private void SinalizarAviso(Label lbl, string str)
        {
            lbl.Visible = true;
            lbl.Text = str;

            Thread.Sleep(6000);
            lbl.Visible = false;
        }

        private void InicializarCampos()
        {
            TxtLogEmail.Text = "E-mail...";
            TxtLogPassword.Text = "Senha...";

            TxtCadUsername.Text = "Username...";
            TxtCadPassword.Text = "Senha...";
            TxtCadConfPass.Text = "Confirme a senha...";
            TxtCadEmail.Text = "E-mail...";

            TxtLogEmail.ForeColor = Color.Gray;
            TxtLogPassword.ForeColor = Color.Gray;

            TxtCadUsername.ForeColor = Color.Gray;
            TxtCadPassword.ForeColor = Color.Gray;
            TxtCadConfPass.ForeColor = Color.Gray;
            TxtCadEmail.ForeColor = Color.Gray;
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
