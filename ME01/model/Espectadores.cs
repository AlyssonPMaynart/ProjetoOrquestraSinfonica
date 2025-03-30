using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Espectadores
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string TipoIngresso { get; set; } // Ex: Normal, VIP, Estudante
        public string Assento { get; set; }
        public double Pagamento { get; set; }

        public Espectadores(string nome, int idade, string tipoIngresso, string assento, double pagamento)
        {
            Nome = nome;
            Idade = idade;
            TipoIngresso = tipoIngresso;
            Assento = assento;
            Pagamento = pagamento;
        }

        public void AssistirConcerto(string concerto)
        {
            Console.WriteLine($"{Nome} está assistindo ao concerto {concerto}.");
        }
    }
}
