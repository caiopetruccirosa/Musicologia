using CSCore.Codecs;
using CSCore.SoundOut;
using MusicApp.Fases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class FrmMenu : Form
    {
        private int Id;

        private bool mouseDown;
        private Point lastLocation;

        private FasePadrao Fase;

        public FrmMenu(int id)
        {
            InitializeComponent();

            this.Id = id;
            this.Fase = null;

            plMultiplayer.Hide();
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

        private IPAddress LocalIPAddress()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                throw new Exception("Desconectado de uma rede");

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        private void IniciarFase(int n)
        {       
            if (this.Fase == null)
            {
                switch (n)
                {
                    case 1:
                        this.Fase = new Fase1(plFase, pbNarrador, lblFalas, this.Id, TrackBarVolume.Value);
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                        this.Fase.Jogar();
                        this.Fase.Jogar();
                        break;
                    case 2:
                        this.Fase = new Fase2(plFase, pbNarrador, lblFalas, this.Id, TrackBarVolume.Value);
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                        this.Fase.Jogar();
                        break;
                    case 3:
                        this.Fase = new Fase3(plFase, pbNarrador, lblFalas, this.Id, TrackBarVolume.Value);
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                        this.Fase.Jogar();
                        break;
                    case 4:
                        this.Fase = new Fase4(plFase, pbNarrador, lblFalas, this.Id, TrackBarVolume.Value);
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                        this.Fase.Jogar();
                        break;
                    case 5:
                        this.Fase = new Fase5(plFase, pbNarrador, lblFalas, this.Id, TrackBarVolume.Value);
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                        this.Fase.Jogar();
                        break;
                    case 6:
                        this.Fase = new Fase6(plFase, pbNarrador, lblFalas, this.Id, TrackBarVolume.Value);
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fase.SairFechandoForm);
                        this.Fase.Jogar();
                        break;
                }
            }            
        }

        // Eventos dos botões do menu
        ////////////////////////////////////////////////////////////////

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            PrepararControlesJogar();
            
            plMenu.Hide();
            plMultiplayer.Hide();
            plFases.Show();
        }

        private void BtnMultiplayer_Click(object sender, EventArgs e)
        {
            PrepararControlesMultiplayer();

            plMenu.Hide();
            plFases.Hide();
            plMultiplayer.Show();
        }

        // Métodos que preparam e carregam a área de fases
        ////////////////////////////////////////////////////////////////

        private void PrepararControlesMultiplayer()
        {
        }

        private void PrepararControlesJogar()
        {
            Button[] fases = { BtnFase1, BtnFase2, BtnFase3, BtnFase4, BtnFase5, BtnFase6 };

            // carregar a área
            int fase = 6;//Engine.BDActions.FasesJogadas(this.IdJogador);
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

        private void BtnFicarDisponivel_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = this.LocalIPAddress();
                Engine.BDActions.FicarDisponivel(this.Id, ip);
            }
            catch (Exception)
            { }
        }

        private void Click_Jogar(object sender, EventArgs e)
        {
            plMenu.Hide();
            plFases.Hide();
            plMultiplayer.Hide();
            plFase.Show();

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
                this.Fase = null;

                PrepararControlesJogar();

                plMenu.Hide();
                plFase.Hide();
                plMultiplayer.Hide();
                plFases.Show();
            }
        }

        private void BtnVoltarMenuFases_Click(object sender, EventArgs e)
        {
            plFase.Hide();
            plFases.Hide();
            plMultiplayer.Hide();
            plMenu.Show();
        }

        private void BtnVoltarMenuMultiplayer_Click(object sender, EventArgs e)
        {
            try
            {
                Engine.BDActions.FicarIndisponivel(this.Id);
            }
            catch (Exception)
            { }

            plFase.Hide();
            plFases.Hide();
            plMultiplayer.Hide();
            plMenu.Show();
        }

        // Eventos extras do menu
        //////////////////////////////////////////////////////////////////

        private void BtnAchievement_Click(object sender, EventArgs e)
        {
            plSettings.Hide();
            plAbout.Hide();
            plAchievement.Show();
            plMenu.Enabled = false;
        }

        private void BtnVoltarAchievement_Click(object sender, EventArgs e)
        {
            plSettings.Hide();
            plAbout.Hide();
            plAchievement.Hide();
            plMenu.Enabled = true;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            plAbout.Hide();
            plAchievement.Hide();
            plSettings.Show();
            plMenu.Enabled = false;
        }

        private void BtnVoltarSettings_Click(object sender, EventArgs e)
        {
            plSettings.Hide();
            plAbout.Hide();
            plAchievement.Hide();
            plMenu.Enabled = true;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            plSettings.Hide();
            plAchievement.Hide();
            plAbout.Show();
            plMenu.Enabled = false;
        }

        private void BtnVoltarAbout_Click(object sender, EventArgs e)
        {
            plSettings.Hide();
            plAbout.Hide();
            plAchievement.Hide();
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