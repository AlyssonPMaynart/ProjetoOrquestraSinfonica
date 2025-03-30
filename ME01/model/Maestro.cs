using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Maestro
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especialidade { get; set; } // Ex: Música clássica, Jazz
        public int AnosExperiencia { get; set; }
        public double Salario { get; set; }
        public string Nacionalidade { get; set; }

        public Maestro(string nome, int idade, string especialidade, int anosExperiencia, double salario, string nacionalidade)
        {
            Nome = nome;
            Idade = idade;
            Especialidade = especialidade;
            AnosExperiencia = anosExperiencia;
            Salario = salario;
            Nacionalidade = nacionalidade;
        }

        public void DirigirOrquestra()
        {
            Console.WriteLine($"{Nome} está dirigindo a orquestra.");
        }
    }
}
