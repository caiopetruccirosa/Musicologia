using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace MusicApp
{
    public class Player
    {
        private int _Volume;
        public int Volume
        {
            get
            {
                return this._Volume;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (value > 100)
                    throw new ArgumentOutOfRangeException();

                this._Volume = value;
            }
        }

        public Player()
        {
            this.Volume = 50;
        }

        private void Tocar(string source)
        {
            WasapiOut som = new WasapiOut();
            som.Initialize(CodecFactory.Instance.GetCodec("../../../../../"+source));
            som.Volume = this.Volume;
            som.Play();
        }

        public void Remover(object sender, EventArgs e)
        {
            Tocar("Sons/PianoNotes/A.mp3");
        }

        public void TocarNota()
        {
            Tocar("Sons/PianoNotes/A.mp3");
        }

        public void Click()
        {
            Tocar("Sons/buttonclick.mp3");
        }
    }
}
