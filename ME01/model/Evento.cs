using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Evento
    {
        public string Nome { get; set; }
        public string Tipo { get; set; } // Ex: Concerto, Evento Especial
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descricao { get; set; }
        public LocalDeApresentacao Local { get; set; }

        public Evento(string nome, string tipo, DateTime data, TimeSpan hora, string descricao, LocalDeApresentacao local)
        {
            Nome = nome;
            Tipo = tipo;
            Data = data;
            Hora = hora;
            Descricao = descricao;
            Local = local;
        }

        public void IniciarEvento()
        {
            Console.WriteLine($"O evento {Nome} começará às {Hora} no {Local.Nome}.");
        }
    }
}
