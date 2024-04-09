using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL0804
{
    class Cliente:Pessoa
    {
        protected int pontos;
        
        public void mostraPontos()
        {
            Console.WriteLine("\nPontos:{0}", this.pontos);
        }

        public void somaPontos(int pontos)
        {
            if( pontos < 1) {
                Console.WriteLine("Não foi possível somar pontos");
            } else 
            { 
            this.pontos = pontos;
            this.mostraPontos();
            }
        }
    }
}
