using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Engine.BDActions.Cadastrar(txtUsername.Text, txtPassword.Text, txtEmail.Text);
        }

        

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username..." && txtUsername.ForeColor == Color.Gray)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username...";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Senha..." && txtPassword.UseSystemPasswordChar == false && txtPassword.ForeColor == Color.Gray)
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Senha...";
                txtPassword.ForeColor = Color.Gray;
            }

        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirmar Senha..." && txtConfirm.UseSystemPasswordChar == false && txtConfirm.ForeColor == Color.Gray)
            {
                txtConfirm.Text = "";
                txtConfirm.UseSystemPasswordChar = true;
                txtConfirm.ForeColor = Color.Black;
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.UseSystemPasswordChar = false;
                txtConfirm.Text = "Confirmar Senha...";
                txtConfirm.ForeColor = Color.Gray;
            }

            if (txtConfirm.Text != txtPassword.Text)
                lblPWError.Visible = true;
            else
                lblPWError.Visible = false;
        } 

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "E-mail...")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail...";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void Cadastro_Shown(object sender, EventArgs e)
        {
            txtUsername.Text = "Username...";
            txtPassword.Text = "Senha...";
            txtConfirm.Text = "Confirmar Senha...";
            txtEmail.Text = "E-mail...";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            txtConfirm.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsername.Text == "Username..." && txtUsername.ForeColor == Color.Gray)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }
    }
}
