using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Musicas
    {
        public string Nome { get; set; }
        public string Compositor { get; set; }
        public TimeSpan Duracao { get; set; }
        public int AnoComposicao { get; set; }
        public string Genero { get; set; } // Ex: Clássico, Barroco
        public string Instrumentos { get; set; } // Lista de instrumentos usados

        public Musicas(string nome, string compositor, TimeSpan duracao, int anoComposicao, string genero, string instrumentos)
        {
            Nome = nome;
            Compositor = compositor;
            Duracao = duracao;
            AnoComposicao = anoComposicao;
            Genero = genero;
            Instrumentos = instrumentos;
        }

        public void Tocar()
        {
            Console.WriteLine($"A música {Nome} está sendo tocada.");
        }
    }
}
