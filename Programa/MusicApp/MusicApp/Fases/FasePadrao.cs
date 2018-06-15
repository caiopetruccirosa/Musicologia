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

        public event Action FinalizarFase;

        protected int Id;
        protected int score;

        public void Terminar()
        {
            this.Encerrar();
        }

        public void Finalizar()
        {
            Engine.BDActions.GuardarScore(this.Id, 1, this.score);
            this.FinalizarFase();
        }

        public void Encerrar()
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

            this.pl.Click -= this.CliqueProximaFala;

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
            this.pl.Click += this.CliqueProximaFala;

            try
            { this.narrador.Falar(); }
            catch (Exception)
            { }
        }

        protected void CliqueProximaFala(object sender, EventArgs e)
        {
            if (this.narrador != null)
            {
                try
                { this.narrador.Falar(); }
                catch (Exception)
                {
                    this.Jogar();
                    if (this.pl != null)
                        this.pl.Click -= this.CliqueProximaFala;
                }
            }
        }

        abstract protected void Jogar();
    }
}
