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
    public class Fase6 : FasePadrao
    {
        public Fase6(Panel panel, PictureBox pbnarrador, Label lblfalas, int id, float volume)
        {
            if (panel == null || pbnarrador == null || lblfalas == null)
                throw new Exception("Objeto nulo");

            this.pl = panel;
            this.narrador = new Narrador("TCHAIKOSKY", pbnarrador, lblfalas);

            this.Id = id;
            this.score = 0;

            this.player = new Player(volume);
            this.player.TocarMusicaDeFundo(6);

            this.ComecarExplicacao();
        }

        protected override void Jogar()
        {
            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 6);
            Engine.BDActions.GuardarScore(this.Id, 6, this.score);
        }
    }
}
