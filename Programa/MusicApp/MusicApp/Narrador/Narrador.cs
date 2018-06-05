using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Narradores
{
    public class Narrador
    {
        protected string nome;
        protected PictureBox pbdesenho;
        protected Label lblfalas;


        public Narrador(string nome, PictureBox pbdesenho, Label lblfalas)
        {
            this.nome = nome;

            this.pbdesenho = pbdesenho;
            this.lblfalas = lblfalas;

            this.pbdesenho.Image = null;
            this.lblfalas.Text = "";

            try
            {
                switch (nome)
                {
                    case "MOZART":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Mozart.png");
                        break;
                    case "BACH":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Bach.png");
                        break;
                    case "BEETHOVEN":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Beethoven.png");
                        break;
                    case "BRAHMS":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Brahms.png");
                        break;
                    case "VIVALDI":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Vivaldi.png");
                        break;
                    case "TCHAIKOSKY":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Tchaikovsky.png");
                        break;
                }
            }
            catch (Exception) { }

            this.pbdesenho.Refresh();
            this.lblfalas.Refresh();
        }
        public void Falar(string fala)
        {
            this.lblfalas.Text = "";

            for (int i = 0; i < fala.Length; i++)
            {
                this.lblfalas.Text += fala[i];
                Thread.Sleep(50);
                this.lblfalas.Refresh();
            }
        }
    }
}
