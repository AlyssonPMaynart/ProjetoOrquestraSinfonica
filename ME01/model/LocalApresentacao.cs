using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME01.model
{
    class LocalApresentacao
    {
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string TipoLocal { get; set; } // Ex: Auditório, Arena
        public int AnoInauguracao { get; set; }

        public LocalApresentacao(string nome, int capacidade, string cidade, string endereco, string tipoLocal, int anoInauguracao)
        {
            Nome = nome;
            Capacidade = capacidade;
            Cidade = cidade;
            Endereco = endereco;
            TipoLocal = tipoLocal;
            AnoInauguracao = anoInauguracao;
        }

        public void Apresentar(string evento)
        {
            Console.WriteLine($"O evento {evento} será realizado no {Nome}.");
        }
    }
}
