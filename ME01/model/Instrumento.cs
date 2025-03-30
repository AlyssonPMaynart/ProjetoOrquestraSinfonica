using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class Instrumento
    {
        public string Nome { get; set; }
        public string Tipo { get; set; } // Ex: Cordas, Sopro, Percussão
        public string Fabricante { get; set; }
        public int AnoFabricacao { get; set; }
        public string Material { get; set; }
        public double Preco { get; set; }

        public Instrumento(string nome, string tipo, string fabricante, int anoFabricacao, string material, double preco)
        {
            Nome = nome;
            Tipo = tipo;
            Fabricante = fabricante;
            AnoFabricacao = anoFabricacao;
            Material = material;
            Preco = preco;
        }

        public void Tocar()
        {
            Console.WriteLine($"O instrumento {Nome} está sendo tocado.");
        }
    }
}
