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
    public class Fase1 : FasePadrao
    {
        public Fase1(Panel panel, PictureBox pbnarrador, Label lblfalas, int id, float volume)
        {
            if (panel == null || pbnarrador == null || lblfalas == null)
                throw new Exception("Objeto nulo");

            this.pl = panel;
            this.narrador = new Narrador("BEETHOVEN", pbnarrador, lblfalas);

            this.idJogador = id;
            this.score = 0;

            this.player = new Player(volume);

            this.pl.Refresh();
        
            this.Jogar();
        }

        protected override void Jogar()
        {
            this.player.TocarMusicaDeFundo(1);

            this.pl.Click += (sender, args) => { this.narrador.Falar(); };
            this.narrador.Falar();

            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 6);
            //Engine.BDActions.GuardarScore(this.idJogador, 1, this.score);
        }
    }
}
