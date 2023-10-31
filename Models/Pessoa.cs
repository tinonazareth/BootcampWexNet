using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampWexNet.Models
{
    public class Pessoa
    {   //Propiedade da classe Pessoa
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Bootcamp { get; set; }
        public decimal Valor { get; set; }
        public double Altura { get; set; }
        DateTime  dataAtual = DateTime.Now;

        // Metodo da classe Pessoa
        public void Apresentar()
        {   
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
            Console.WriteLine($"Estou estudando este {Bootcamp} na Dio.me, com mensalidade de R$ {Valor}");
            Console.WriteLine($"Tenho {Altura.ToString("0.00")} metros de altura");

        }
    }
}