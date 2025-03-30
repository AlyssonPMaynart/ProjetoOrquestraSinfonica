using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Concerto
    {
        public DateTime Data { get; set; }
        public TimeSpan Duracao { get; set; }
        public LocalApresentacao Local { get; set; }
        public string Repertorio { get; set; } // Lista de músicas a serem tocadas
        public string Maestro { get; set; }
        public int IngressosDisponiveis { get; set; }
        public int EspectadoresPresentes { get; set; }

        public Concerto(DateTime data, TimeSpan duracao, LocalApresentacao local, string repertorio, string maestro, int ingressosDisponiveis, int espectadoresPresentes)
        {
            Data = data;
            Duracao = duracao;
            Local = local;
            Repertorio = repertorio;
            Maestro = maestro;
            IngressosDisponiveis = ingressosDisponiveis;
            EspectadoresPresentes = espectadoresPresentes;
        }

        public void IniciarConcerto()
        {
            Console.WriteLine($"Concerto {Repertorio} iniciado no {Local.Nome}.");
        }
    }
}
