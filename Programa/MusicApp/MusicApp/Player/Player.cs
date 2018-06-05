using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace MusicApp
{
    public class Player : IDisposable
    {
        private float _Volume;
        private List<WasapiOut> playlist;

        public float Volume
        {
            get
            {
                return this._Volume;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (value > 1)
                    throw new ArgumentOutOfRangeException();

                this._Volume = value;
            }
        }

        private void Remover(WasapiOut w)
        {
            if (w == null)
                throw new Exception("Som nulo");

            if (w.PlaybackState != PlaybackState.Stopped)
                w.Stop();

            this.playlist.Remove(w);
            w.Dispose();
        }

        public Player()
        {
            this.playlist = new List<WasapiOut>();
            this.Volume = (float)0.50;
        }

        public void Tocar(string source)
        {
            WasapiOut som = new WasapiOut();
            som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/"+source));
            som.Volume = this.Volume;
            som.Play();

            this.playlist.Add(som);
            som.Stopped += (sender, e) => this.Remover(som);
        }

        public void Dispose()
        {
            try
            {
                this.playlist.ForEach(this.Remover);
            }
            catch (Exception e) { }
        }
    }
}
