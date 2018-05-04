using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Narradores
{
    public class NarradorPadrao
    {
        public string nome;
        public string[] falas;
        
        public NarradorPadrao (string nome, string[] falas)
        {
            this.nome = nome;
            this.falas = falas;
        }
    }
}
