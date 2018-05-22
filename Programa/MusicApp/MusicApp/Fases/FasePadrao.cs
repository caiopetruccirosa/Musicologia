using MusicApp.Narradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Fases
{
    public class FasePadrao
    {
        protected Panel pl;
        protected Player player;
        protected NarradorPadrao narrador;

        public bool Sair()
        {
            if (MessageBox.Show("Todo o progresso não salvo será perdido!", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return false;

            this.player.Dispose();

            this.player = null;
            this.pl = null;
            this.narrador = null;

            return true;
        }

        public void SairFechandoForm(object sender, FormClosingEventArgs e)
        {
            if (this.player != null)
            {
                if (!this.Sair())
                    e.Cancel = true;
            }
        }
    }
}
