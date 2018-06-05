using MusicApp.Narradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Fases
{
    public class Fase6 : FasePadrao
    {
        public Fase6(Panel panel, PictureBox pbnarrador, Label lblfalas, int id, int volume)
        {
            if (panel == null || pbnarrador == null || lblfalas == null)
                throw new Exception("Objeto nulo");

            this.pl = panel;
            this.narrador = new Narrador("TCHAIKOSKY", pbnarrador, lblfalas);

            this.idJogador = id;

            this.player = new Player();
            this.player.Volume = (float)volume / 100;

            this.pl.Refresh();
        }

        public override void Jogar()
        {
            this.player.Tocar("Ode a Alegria.mp3");
            this.narrador.Falar("FALAE MEU BOM COMO VC TA");
        }
    }
}
