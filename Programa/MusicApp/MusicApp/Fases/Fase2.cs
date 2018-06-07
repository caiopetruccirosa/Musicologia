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
    public class Fase2 : FasePadrao
    {
        public Fase2(Panel panel, PictureBox pbnarrador, Label lblfalas, int id, float volume)
        {
            if (panel == null || pbnarrador == null || lblfalas == null)
                throw new Exception("Objeto nulo");

            this.pl = panel;
            this.narrador = new Narrador("MOZART", pbnarrador, lblfalas);

            this.idJogador = id;
            this.score = 0;

            this.player = new Player(volume);

            this.pl.Refresh();

            this.Jogo = new Thread(new ThreadStart(this.Jogar));
            this.Jogo.Start();
        }

        protected override void Jogar()
        {
            this.player.TocarMusicaDeFundo(2);

            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 6);
            //Engine.BDActions.GuardarScore(this.idJogador, 2, this.score);
        }
    }
}
