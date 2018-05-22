using MusicApp.Narradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Fases
{
    public class Fase1 : FasePadrao
    {        
        public Fase1(Panel panel, PictureBox pbnarrador, PictureBox pbfalas, int volume)
        {
            if (panel == null || pbnarrador == null || pbfalas == null)
                throw new Exception("Objeto nulo");

            this.pl = panel;
            this.narrador = new Mozart(pbnarrador, pbfalas);

            this.player = new Player();
            this.player.Volume = (float)volume/100;
            this.player.Tocar("Ode a Alegria.mp3");
        }
    }
}
