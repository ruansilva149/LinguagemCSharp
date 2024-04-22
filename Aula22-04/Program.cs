using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Jeferson",1000);
            //p.Nome = "Jeferson";
            Console.WriteLine("Nome:{0}", p.Nome);
            p.Salario = 1000;
            p.Salario = 900;
            p.Salario = 1100;
            Console.WriteLine("Salario: {0}", p.salario);
            Console.ReadKey();


        }
    }
}
