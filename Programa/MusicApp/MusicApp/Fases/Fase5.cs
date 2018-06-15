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
    public class Fase5 : FasePadrao
    {
        public Fase5(Panel panel, PictureBox pbnarrador, Label lblfalas, int id, float volume)
        {
            if (panel == null || pbnarrador == null || lblfalas == null)
                throw new Exception("Objeto nulo");

            this.pl = panel;
            this.narrador = new Narrador("VIVALDI", pbnarrador, lblfalas);

            this.Id = id;
            this.score = 0;

            this.player = new Player(volume);
            this.player.TocarMusicaDeFundo(5);

            this.ComecarExplicacao();
        }

        protected override void Jogar()
        {
            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(5, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(5, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(5, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(5, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(5, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(5, 6);

            this.Finalizar();
        }
    }
}
