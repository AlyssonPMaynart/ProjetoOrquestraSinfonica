using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Musico
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Instrumento { get; set; }
        public int Experiencia { get; set; }
        public double Salario { get; set; }
        public string TipoMusico { get; set; } // Ex: Solista, Sectionista

        public Musico(string nome, int idade, string instrumento, int experiencia, double salario, string tipoMusico)
        {
            Nome = nome;
            Idade = idade;
            Instrumento = instrumento;
            Experiencia = experiencia;
            Salario = salario;
            TipoMusico = tipoMusico;
        }

        public void Tocar()
        {
            Console.WriteLine($"{Nome} está tocando {Instrumento}.");
        }
    }
}
