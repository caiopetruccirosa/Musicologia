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

        protected Queue<string> falas;
        protected Queue<string> perguntas;

        public bool estaFalando;
        public bool podeFalar;
        public bool pararDeFalar;

        public Narrador(string nome, PictureBox pbdesenho, Label lblfalas)
        {
            this.nome = nome;

            this.pbdesenho = pbdesenho;
            this.lblfalas = lblfalas;

            this.falas = new Queue<string>();
            this.perguntas = new Queue<string>();

            this.estaFalando = false;
            this.podeFalar = true;
            this.pararDeFalar = false;

            this.pbdesenho.Image = null;
            this.lblfalas.Text = "";

            try
            {
                switch (nome)
                {
                    case "BEETHOVEN":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Beethoven.png");

                        this.falas.Enqueue("Olá! Meu nome é Ludwig Van Beethoven. Mas pode me chamar só de Beethoven, ou Beto.");
                        this.falas.Enqueue("Fui um músico alemão, e sou famoso até hoje pela minha obra, a qual você está escutando agora :)");
                        this.falas.Enqueue("Estou aqui para ensinar para você sobre a história da música e como ela está presente nas nossas vidas!");
                        this.falas.Enqueue("O que acha de aprender mais sobre essa fantástica arte?");
                        this.falas.Enqueue("A humanidade faz música desde sua origem, há 40 mil anos atrás! Incrível, não?");

                        this.falas.Enqueue("Vamos descobrir o que você aprendeu agora.");

                        this.perguntas.Enqueue("");

                        break;
                    case "MOZART":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Mozart.png");

                        this.falas.Enqueue("Ah você é a pessoa que o Beto me falou que quer aprender música!");
                        this.falas.Enqueue("Meu nome é Wolfgang Amadeus Mozart, conhecido apenas como Mozart.");
                        this.falas.Enqueue("Fui um compositor austríaco muito influente e famoso. Está gostando da minha música?");
                        this.falas.Enqueue("Estou aqui para ensinar para você sobre o que é música");
                        this.falas.Enqueue("Bom, se você quer aprender sobre música deve saber do que ela é feita, lá vem!");
                        this.falas.Enqueue("MELODIA, HARMONIA e RITMO!");
                        this.falas.Enqueue("MELODIA é a combinação de SONS SUCESSIVOS (tocados uns depois outros)");
                        this.falas.Enqueue("HARMONIA é a combinação de SONS SIMULTÂNEOS (tocados ao mesmo tempo)");
                        this.falas.Enqueue("RITMO é a combinação de valores de tempo.");
                        this.falas.Enqueue("Parece meio confuso agora, mas calma!");
                        this.falas.Enqueue("Você viu que a melodia e a harmonia são combinações de sons. Mas, o que é som?");
                        this.falas.Enqueue("SOM é tudo o que causa impressão ao ouvido.");
                        this.falas.Enqueue("Mas como o Beto falou, nem todo som é música. Por isso falamos em som musical.");
                        this.falas.Enqueue("O som musical é composto por 4 partes:");
                        this.falas.Enqueue("ALTURA, DURAÇÃO, INTENSIDADE e TIMBRE!");
                        this.falas.Enqueue("ALTURA é o que classifica os sons em GRAVE, MÉDIOS e AGUDOS.");
                        this.falas.Enqueue("DURAÇÃO é o tempo que se prolonga o som.");
                        this.falas.Enqueue("INTENSIDADE é o que nos permite distinguir o som de FRACO ou FORTE.");
                        this.falas.Enqueue("TIMBRE é o que nos faz diferenciar os sons e suas características.");
                        this.falas.Enqueue("Ufa! Essa foi sua segunda aula sobre música! Agora vamos ver se você realmente aprendeu...");

                        this.perguntas.Enqueue("");

                        break;
                    case "BACH":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Bach.png");

                        this.falas.Enqueue("Olá! Eu sou Johann Sebastian Bach(que se pronuncia bá)!");
                        this.falas.Enqueue("Fui um compositor e violinista importante da Alemanha.");
                        this.falas.Enqueue("Estou aqui para te ensinar o que são pautas, ");
                        this.falas.Enqueue("quais e o que sao NOTAS MUSICAIS e o que é ESCALA!");
                        this.falas.Enqueue("Bom, vamos começar com pauta:");
                        this.falas.Enqueue("PAUTA são 5 linhas(que formam 4 espaços entre si) onde se escrevem as notas.");
                        this.falas.Enqueue("NOTAS MUSICAIS são sons musicais. As notas são:");
                        this.falas.Enqueue("DÓ RÉ MI FÁ SOL LÁ SI");
                        this.falas.Enqueue("As sete notas ouvidas sucessivamente formam uma série de sons");
                        this.falas.Enqueue("que se dá o nome de ESCALA.");

                        this.perguntas.Enqueue("");

                        break;
                    case "BRAHMS":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Brahms.png");

                        this.falas.Enqueue("brahms");

                        this.perguntas.Enqueue("");

                        break;
                    case "VIVALDI":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Vivaldi.png");

                        this.falas.Enqueue("");

                        this.perguntas.Enqueue("");

                        break;
                    case "TCHAIKOSKY":
                        this.pbdesenho.Image = Image.FromFile("../../../../../Fotos/Imagens/Tchaikovsky.png");

                        this.falas.Enqueue("");

                        this.perguntas.Enqueue("");

                        break;
                }
            }
            catch (Exception) { }

            this.pbdesenho.Refresh();
            this.lblfalas.Refresh();
        }

        public void Falar()
        {
            if (this.falas.Count > 0)
            {
                if (!this.estaFalando)
                {
                    this.estaFalando = true;

                    this.lblfalas.Text = "";
                    this.lblfalas.Refresh();

                    string fala = this.falas.Dequeue();
                    for (int i = 0; i < fala.Length; i++)
                    {
                        if (this.pararDeFalar)
                        {
                            this.lblfalas.Text = fala;
                            break;
                        }
                        this.lblfalas.Text += fala[i];
                        Thread.Sleep(50);
                        this.lblfalas.Refresh();
                    }

                    this.estaFalando = false;
                }
            }
            else
                throw new Exception();
        }

        public void Perguntar()
        {
            if (this.perguntas.Count > 0)
            {
                if (!this.estaFalando)
                {
                    this.estaFalando = true;

                    this.lblfalas.Text = "";
                    this.lblfalas.Refresh();

                    string pergunta = this.perguntas.Dequeue();
                    for (int i = 0; i < pergunta.Length; i++)
                    {
                        if (this.pararDeFalar)
                        {    
                            this.lblfalas.Text = pergunta;
                            break;
                        }
                        this.lblfalas.Text += pergunta[i];
                        Thread.Sleep(70);
                        this.lblfalas.Refresh();
                    }

                    this.estaFalando = false;
                }
            }
            else
                throw new Exception();
        }
    }
}
