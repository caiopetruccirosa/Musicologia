using CSCore.Codecs;
using CSCore.SoundOut;
using MusicApp.Fases;
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
    public partial class FrmMenu : Form
    {
        private int IdJogador;
        private string Modo;

        private bool mouseDown;
        private Point lastLocation;

        private FasePadrao Fase;

        public FrmMenu(int id)
        {
            InitializeComponent();

            this.IdJogador = id;
            this.Modo = "";
            this.Fase = null;

            plFases.Hide();
            plFase.Hide();
            plSettings.Hide();
            plAbout.Hide();
            plAchievement.Hide();
            plMenu.Show();

            plSettings.Location = new Point(
                this.ClientSize.Width / 2 - plSettings.Size.Width / 2,
                this.ClientSize.Height / 2 - plSettings.Size.Height / 2);

            plAbout.Location = new Point(
                this.ClientSize.Width / 2 - plSettings.Size.Width / 2,
                this.ClientSize.Height / 2 - plSettings.Size.Height / 2);

            plAchievement.Location = new Point(
                this.ClientSize.Width / 2 - plSettings.Size.Width / 2,
                this.ClientSize.Height / 2 - plSettings.Size.Height / 2);
        }

        private void IniciarFase(int n)
        {       
            switch (n)
            {
                case 1:
                    this.Fase = new Fase1(plFase, pbNarrador, pbFalas, TrackBarVolume.Value);
                    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                    break;
                case 2:
                    //this.Fase = new Fase2(plFase, pbNarrador, pbFalas, TrackBarVolume.Value);
                    //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                    break;
                case 3:
                    //this.Fase = new Fase3(plFase, pbNarrador, pbFalas, TrackBarVolume.Value);
                    //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                    break;
                case 4:
                    //this.Fase = new Fase4(plFase, pbNarrador, pbFalas, TrackBarVolume.Value);
                    //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                    break;
                case 5:
                    //this.Fase = new Fase5(plFase, pbNarrador, pbFalas, TrackBarVolume.Value);
                    //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                    break;
                case 6:
                    //this.Fase = new Fase6(plFase, pbNarrador, pbFalas, TrackBarVolume.Value);
                    //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                    break;
            }
            
        }

        // Eventos dos botões do menu
        ////////////////////////////////////////////////////////////////

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            PrepararControlesJogar();
            
            plMenu.Hide();
            plFases.Show();
        }

        private void BtnMultiplayer_Click(object sender, EventArgs e)
        {
            PrepararControlesMultiplayer();

            plMenu.Hide();
            plFases.Show();
        }

        // Métodos que preparam e carregam a área de fases
        ////////////////////////////////////////////////////////////////

        private void PrepararControlesMultiplayer()
        {
            Button[] fases = { BtnFase1, BtnFase2, BtnFase3, BtnFase4, BtnFase5, BtnFase6 };

            LblFases.Text = "Multiplayer";

            // carregar a área
            for (int i = 0; i < fases.Length; i++)
            {
                fases[i].Enabled = true;
                fases[i].BackColor = SystemColors.HotTrack;
                fases[i].Click += new System.EventHandler(this.Click_Multiplayer);
            }
        }

        private void PrepararControlesJogar()
        {
            Button[] fases = { BtnFase1, BtnFase2, BtnFase3, BtnFase4, BtnFase5, BtnFase6 };

            LblFases.Text = "Jogar";

            // carregar a área
            int fase = Engine.BDActions.QualFase(this.IdJogador);
            for (int i = 0; i < fases.Length; i++)
            {
                if (i <= fase-1)
                {
                    fases[i].Enabled = true;
                    fases[i].BackColor = SystemColors.HotTrack;
                    fases[i].Click += new System.EventHandler(this.Click_Jogar);
                }
                else 
                {
                    fases[i].Enabled = false;
                    fases[i].BackColor = SystemColors.InactiveCaption;
                }
            }
        }

        // Eventos dos botões das fases
        //////////////////////////////////////////////////////////////////

        private void Click_Multiplayer(object sender, EventArgs e)
        {
            plFases.Hide();
            plFase.Show();

            this.Modo = "multiplayer";
        }

        private void Click_Jogar(object sender, EventArgs e)
        {
            plFases.Hide();
            plFase.Show();

            this.Modo = "jogar";

            Button btn = (Button)sender;
            if (btn == BtnFase1)
                IniciarFase(1);
            else if (btn == BtnFase2)
                IniciarFase(2);
            else if (btn == BtnFase3)
                IniciarFase(3);
            else if (btn == BtnFase4)
                IniciarFase(4);
            else if (btn == BtnFase5)
                IniciarFase(5);
            else if (btn == BtnFase6)
                IniciarFase(6);
        }

        // Eventos de retorno a algum painel
        ////////////////////////////////////////////////////////////////

        private void BtnVoltarFases_Click(object sender, EventArgs e)
        {
            if (this.Fase != null && this.Fase.Sair())
            {
                if (this.Modo == "jogar")
                    PrepararControlesJogar();
                else if (this.Modo == "multiplayer")
                    PrepararControlesMultiplayer();

                plFase.Hide();
                plFases.Show();
            }
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            plFases.Hide();
            plMenu.Show();
            this.Modo = "";
        }

        // Eventos extras do menu
        //////////////////////////////////////////////////////////////////

        private void BtnAchievement_Click(object sender, EventArgs e)
        {
            plAchievement.Show();
            plMenu.Enabled = false;
        }

        private void BtnVoltarAchievement_Click(object sender, EventArgs e)
        {
            plAchievement.Hide();
            plMenu.Enabled = true;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            plSettings.Show();
            plMenu.Enabled = false;
        }

        private void BtnVoltarSettings_Click(object sender, EventArgs e)
        {
            plSettings.Hide();
            plMenu.Enabled = true;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            plAbout.Show();
            plMenu.Enabled = false;
        }

        private void BtnVoltarAbout_Click(object sender, EventArgs e)
        {
            plAbout.Hide();
            plMenu.Enabled = true;
        }

        // Eventos botões do frame
        ////////////////////////////////////////////////////////////////
         
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ////////////////////////////////////////////////////////////////

        private void FrmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void FrmMenu_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void FrmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}