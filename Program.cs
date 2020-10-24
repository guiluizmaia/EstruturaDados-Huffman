using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodificacaoHuffman
{
    /*
     IComparable: tem a função de fornecer um método de comparação
     de dois ou mais objetos. Disponibiliza a capacidade de ordenação 
     dos objetos
     */
    class No : IComparable<No>
    {
        public int frequencia;
        public string caractere;
        public No esquerda;
        public No direita;
        public No pai;

        public No(string valor_no, int freq)
        {
            frequencia = freq;
            caractere = valor_no;
        }

        public int CompareTo(No no)
        {
            return this.frequencia.CompareTo(no.frequencia);
        }
        public override string ToString()
        {
            return caractere;
        }
    }

    class Program
    {
        static string palavra;

        static void Main(string[] args)
        {
            Console.WriteLine("Informe a palavra para codificação: ");
            palavra = Console.ReadLine().ToLower();
            //ToLower, tudo em caixa baixa
        }
    }
}
