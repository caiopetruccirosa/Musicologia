using MusicApp.Narradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Fases
{
    public abstract class FasePadrao
    {
        protected Panel pl;
        protected Player player;
        protected Narrador narrador;
        protected Thread Jogo;

        protected int idJogador;
        protected int score;

        public void Terminar()
        {
            this.Encerrar();
        }

        protected void Encerrar()
        {
            if (this.player != null)
                this.player.Dispose();

            if (this.Jogo != null)
                if (this.Jogo.ThreadState == ThreadState.Running)
                {
                    this.Jogo.Interrupt();
                    if (!this.Jogo.Join(500))
                        this.Jogo.Abort();
                }

            this.pl.Click -= (sender, args) => this.narrador.Falar();

            this.Jogo = null;
            this.player = null;
            this.pl = null;
            this.narrador = null;
            this.score = 0;
        }

        public bool Sair()
        {
            if (MessageBox.Show("Todo o progresso não salvo será perdido!", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return false;

            this.Encerrar();

            return true;
        }

        protected void ComecarExplicacao()
        {
            this.pl.Refresh();
            this.pl.Click += (sender, args) =>
            {
                if (this.narrador != null)
                {
                    if (!this.narrador.estaFalando)
                    {
                        try
                        {
                            this.narrador.Falar();
                        }
                        catch (Exception)
                        {
                            this.Jogar();
                        }
                    }
                }
            };

            this.narrador.Falar();
        }

        abstract protected void Jogar();
    }
}
