﻿using MusicApp.Narradores;
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

            this.idJogador = id;
            this.score = 0;

            this.player = new Player(volume);

            this.pl.Refresh();

            this.Jogo = new Thread(new ThreadStart(this.Jogar));
            this.Jogo.Start();
        }

        protected override void Jogar()
        {
            this.player.TocarMusicaDeFundo(6);

            //string[] alternativas;
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 1);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 2);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 3);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 4);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 5);
            //string[] alternativas = Engine.BDActions.CarregarAlternativas(6, 6);
            //Engine.BDActions.GuardarScore(this.idJogador, 6, this.score);
        }
    }
}
