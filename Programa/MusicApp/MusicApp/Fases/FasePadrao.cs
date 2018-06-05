using MusicApp.Narradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Fases
{
    public abstract class FasePadrao
    {
        protected Panel pl;
        protected Player player;
        protected Narrador narrador;

        protected int idJogador;

        protected string nome;
        protected int score;

        public void Terminar()
        {
            this.Encerrar();
        }

        protected void Encerrar()
        {
            if (this.player != null)
                this.player.Dispose();

            this.player = null;
            this.pl = null;
            this.narrador = null;
            this.nome = null;
        }

        public bool Sair()
        {
            if (MessageBox.Show("Todo o progresso não salvo será perdido!", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return false;

            this.Encerrar();

            return true;
        }

        public void SairFechandoForm(object sender, FormClosingEventArgs e)
        {
            if (!this.Sair())
                e.Cancel = true;
        }

        abstract public void Jogar();
    }
}
