using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Narradores
{
    public class Mozart : NarradorPadrao
    {
        public Mozart(PictureBox pbdesenho, PictureBox pbfalas)
        {
            this.pbdesenho = pbdesenho;
            this.pbdesenho.BackgroundImage = Image.FromFile("../../../../../Fotos/Imagens/Mozart.png");
            this.pbdesenho.BackgroundImageLayout = ImageLayout.Zoom;

            this.pbfalas = pbfalas;
            this.pbfalas.BackgroundImage = Image.FromFile("../../../../../Fotos/Imagens/Clave.png");
            this.pbfalas.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
