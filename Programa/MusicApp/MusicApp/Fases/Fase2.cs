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

            this.Id = id;
            this.score = 0;

            this.player = new Player(volume);
            this.player.TocarMusicaDeFundo(2);

            this.ComecarExplicacao();
        }

        protected override void Jogar()
        {
            MessageBox.Show("vai se fude vai");
            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(2, 6);

            this.Finalizar();
        }
    }
}
