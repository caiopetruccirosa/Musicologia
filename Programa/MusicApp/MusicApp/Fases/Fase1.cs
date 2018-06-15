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

            this.Id = id;
            this.score = 0;

            this.player = new Player(volume);
            this.player.TocarMusicaDeFundo(1);
        
            this.ComecarExplicacao();
        }

        protected override void Jogar()
        {
            this.narrador.Perguntar();

            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(1, 6);

            this.Finalizar();
        }
    }
}
