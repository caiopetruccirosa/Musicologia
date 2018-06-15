using Engine;
using Engine.DBO;
using MusicApp.Fases;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class FrmJogo : Form
    {
        private User Jogador;

        private bool mouseDown;
        private Point lastLocation;

        private Player player;
        private float volume;

        public bool Deslogado { get; private set; }

        private FasePadrao Fase;

        public FrmJogo(User jogador)
        {
            if (jogador == null)
                throw new Exception("Jogador inválido!");

            InitializeComponent();

            this.Jogador = jogador;
            this.Fase = null;
            this.Deslogado = false;

            this.volume = (float)TrackBarVolume.Value / 100;

            this.player = new Player(this.volume);
            this.player.TocarMusicaDeFundo(0);

            plMultiplayer.Hide();
            plFases.Hide();
            plFase.Hide();
            plSettings.Hide();
            plAbout.Hide();
            plAchievement.Hide();
            plMenu.Show();

            LblUsername.Text = this.Jogador.Username;

            plSettings.Location = new Point(
                this.ClientSize.Width / 2 - plSettings.Size.Width / 2,
                this.ClientSize.Height / 2 - plSettings.Size.Height / 2);

            plAbout.Location = new Point(
                this.ClientSize.Width / 2 - plAbout.Size.Width / 2,
                this.ClientSize.Height / 2 - plAbout.Size.Height / 2);

            plAchievement.Location = new Point(
                this.ClientSize.Width / 2 - plAchievement.Size.Width / 2,
                this.ClientSize.Height / 2 - plAchievement.Size.Height / 2);
        }

        private IPAddress LocalIPAddress()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                throw new Exception("Desconectado de uma rede");

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        private void EncerrarFase()
        {
            if (this.Fase != null)
                this.Fase.Encerrar();
            this.Fase = null;

            this.player.Resume();

            PrepararControlesJogar();

            plMenu.Hide();
            plFase.Hide();
            plMultiplayer.Hide();
            plFases.Show();
        }

        private void IniciarFase(int n)
        {       
            if (this.Fase == null)
            {
                this.player.Pause();
                switch (n)
                {
                    case 1:
                        this.Fase = new Fase1(plFase, pbNarrador, LblFalas, this.Jogador.Id, volume);
                        break;
                    case 2:
                        this.Fase = new Fase2(plFase, pbNarrador, LblFalas, this.Jogador.Id, volume);
                        break;
                    case 3:
                        this.Fase = new Fase3(plFase, pbNarrador, LblFalas, this.Jogador.Id, volume);
                        break;
                    case 4:
                        this.Fase = new Fase4(plFase, pbNarrador, LblFalas, this.Jogador.Id, volume);
                        break;
                    case 5:
                        this.Fase = new Fase5(plFase, pbNarrador, LblFalas, this.Jogador.Id, volume);
                        break;
                    case 6:
                        this.Fase = new Fase6(plFase, pbNarrador, LblFalas, this.Jogador.Id, volume);
                        break;
                }
                this.Fase.FinalizarFase += this.EncerrarFase;
            }            
        }

        // Eventos dos botões do menu
        ////////////////////////////////////////////////////////////////

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            PrepararControlesJogar();
            
            plMenu.Hide();
            plMultiplayer.Hide();
            plFase.Hide();
            plFases.Show();
        }

        private void BtnMultiplayer_Click(object sender, EventArgs e)
        {
            PrepararControlesMultiplayer();

            plMenu.Hide();
            plFases.Hide();
            plFase.Hide();
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
            FaseDados[] fasesJogadas = Engine.BDActions.FasesJogadas(this.Jogador.Id);
            
            for (int i = 0; i < fasesJogadas.Length; i++) {
                FaseDados fase = fasesJogadas[i];
                PictureBox[] estrelas = new PictureBox[fase.Pontuacao];

                int offsetX = fases[i].Width - 25;
                int offsetY = fases[i].Height - 25;
                for (int j = 0; j < estrelas.Length; j++)
                {
                    estrelas[j] = new PictureBox();
                    estrelas[j].BackColor = System.Drawing.Color.Transparent;
                    estrelas[j].BackgroundImage = global::MusicApp.Properties.Resources.goldenstar;
                    estrelas[j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    estrelas[j].Size = new System.Drawing.Size(20, 20);
                    estrelas[j].Location = new System.Drawing.Point(offsetX, offsetY);

                    offsetX -= estrelas[j].Width;

                    fases[i].Controls.Add(estrelas[j]);
                }
                fases[i].Refresh();
            }

            for (int i = 0; i < fases.Length; i++)
            {
                if (i < fasesJogadas.Length + 1)
                {
                    fases[i].Enabled = true;
                    fases[i].BackColor = System.Drawing.Color.DarkGoldenrod;
                    fases[i].Click += new System.EventHandler(this.Click_Jogar);
                }
                else
                {
                    fases[i].Enabled = false;
                    fases[i].BackColor = System.Drawing.Color.SandyBrown;
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
                Engine.BDActions.FicarDisponivel(this.Jogador.Id, ip);
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

                this.player.Resume();

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
                Engine.BDActions.FicarIndisponivel(this.Jogador.Id);
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
            this.Deslogado = false;
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

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Fase != null && !this.Fase.Sair())
                e.Cancel = true;

            this.Fase = null;
            if (this.player != null)
                this.player.Dispose();
            this.player = null;
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            this.LblVolume.Text = "Volume: " + TrackBarVolume.Value;

            this.volume = (float)TrackBarVolume.Value / 100;
            if (this.player != null)
                this.player.Volume = this.volume;
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            this.Deslogado = true;
            this.Close();
        }
    }
}