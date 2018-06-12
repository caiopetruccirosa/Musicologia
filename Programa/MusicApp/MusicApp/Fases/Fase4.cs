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
    public class Fase4 : FasePadrao
    {
        public Fase4(Panel panel, PictureBox pbnarrador, Label lblfalas, int id, float volume)
        {
            if (panel == null || pbnarrador == null || lblfalas == null)
                throw new Exception("Objeto nulo");

            this.pl = panel;
            this.narrador = new Narrador("BRAHMS", pbnarrador, lblfalas);

            this.Id = id;
            this.score = 0;

            this.player = new Player(volume);
            this.player.TocarMusicaDeFundo(4);

            this.ComecarExplicacao();
        }

        protected override void Jogar()
        {
            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(4, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(4, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(4, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(4, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(4, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(4, 6);
            Engine.BDActions.GuardarScore(this.Id, 4, this.score);
        }
    }
}
