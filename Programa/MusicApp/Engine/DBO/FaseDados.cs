using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FaseDados
    {
        public int Numero { get; private set; }
        public int Pontuacao { get; private set; }

        public FaseDados(int numero, int pontuacao)
        {
            if (numero < 1 || numero > 6)
                throw new ArgumentOutOfRangeException();

            if (pontuacao < 0 || pontuacao > 3)
                throw new ArgumentOutOfRangeException();

            this.Numero = numero;
            this.Pontuacao = pontuacao;
        }
    }
}
