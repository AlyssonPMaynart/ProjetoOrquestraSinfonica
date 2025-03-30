using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Ingressos
    {
        public string Tipo { get; set; } // Ex: VIP, Normal, Estudante
        public double Preco { get; set; }
        public int Numero { get; set; }
        public string Assento { get; set; }

        public Ingressos(string tipo, double preco, int numero, string assento)
        {
            Tipo = tipo;
            Preco = preco;
            Numero = numero;
            Assento = assento;
        }

        public void Vender()
        {
            Console.WriteLine($"Ingresso {Numero} vendido para o tipo {Tipo}.");
        }
    }
}
