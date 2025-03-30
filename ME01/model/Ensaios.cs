using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Ensaios
    {
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public TimeSpan Duracao { get; set; }
        public LocalApresentacao Local { get; set; }
        public string Repertorio { get; set; }
        public string Maestro { get; set; }

        public Ensaios(DateTime data, TimeSpan hora, TimeSpan duracao, LocalApresentacao local, string repertorio, string maestro)
        {
            Data = data;
            Hora = hora;
            Duracao = duracao;
            Local = local;
            Repertorio = repertorio;
            Maestro = maestro;
        }

        public void RealizarEnsaio()
        {
            Console.WriteLine($"Ensaio de {Repertorio} com {Maestro} no local {Local.Nome}.");
        }
    }
}
