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

                float proporcao = value - this.Volume;
                this._Volume = value;

                this.playlist.ForEach((w) => {
                    w.Volume = (float) w.Volume + proporcao;
                });
            }
        }

        private void Remover(WasapiOut w)
        {
            if (w == null)
                throw new Exception("Som nulo");

            if (w.PlaybackState != PlaybackState.Stopped)
                w.Stop();

            try
            {
                this.playlist.Remove(w);
                w.Dispose();
            }
            catch (Exception)
            { }
        }

        public Player(float volume)
        {
                if (volume < 0)
                    throw new ArgumentOutOfRangeException();

                if (volume > 1)
                    throw new ArgumentOutOfRangeException();

            this.playlist = new List<WasapiOut>();
            this.Volume = volume;
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

        public void TocarMusicaDeFundo(int n)
        {
            try
            {
                WasapiOut som = new WasapiOut();
                switch (n)
                {
                    case 0:
                        som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/MusicasDeFundo/Cello Suite n1.mp3"));
                        break;
                    case 1:
                        som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/MusicasDeFundo/Ode to Joy.mp3"));
                        break;
                    case 2:
                        som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/MusicasDeFundo/Symphony n40.mp3"));
                        break;
                    case 3:
                        som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/MusicasDeFundo/Cello Suite n1.mp3"));
                        break;
                    case 4:
                        som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/MusicasDeFundo/Hungarian Dance.mp3"));
                        break;
                    case 5:
                        som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/MusicasDeFundo/Spring Allegro n1.mp3"));
                        break;
                    case 6:
                        som.Initialize(CodecFactory.Instance.GetCodec("../../../../../Sons/MusicasDeFundo/Swan Lake Act II.mp3"));
                        break;
                }
                som.Volume = this.Volume;
                som.Play();

                this.playlist.Add(som);
                som.Stopped += (sender, e) => {
                    this.Remover(som);
                    if (this.playlist != null)
                        this.TocarMusicaDeFundo(n);
                };
            }
            catch (Exception)
            { }
        }

        public void Pause()
        {
            try
            {
                this.playlist.ForEach((w) => {
                    w.Pause();
                });
            }
            catch (Exception) { }
        }

        public void Resume()
        {
            this.playlist.ForEach((w) => {
                w.Resume();
            });
        }

        public void Dispose()
        {
            try
            {
                this.playlist.ForEach(this.Remover);
            }
            catch (Exception) { }

            this.Volume = 0;
            this.playlist = null;
        }
    }
}
