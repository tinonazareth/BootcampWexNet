using System.Data;
using BootcampWexNet.Models;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {   //Instâncianado a classe Pessoa
        Pessoa p = new Pessoa();
        p.Nome = "Valtino";
        p.Idade = 47;
        p.Bootcamp = "Bootcamp";
        p.Valor = 59.90M;
        p.Altura = 1.72;
        p.Apresentar();
        
    }

}