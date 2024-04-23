using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22_04
{
    class Pessoa
    {
        private string nome;
        public double salario;
        public string senha;
        public string Senha
        {
            set
            {
                senha = value;
            }
        }
        public double Salario
        {
            get
            {
                return this.salario;
            }

            set
            {
                if (this.salario > value)
                {
                    Console.WriteLine("Salario atual maior que o informado");
                } else
                {
                    this.salario = value;
                    Console.WriteLine("Salario atualizado");
                }
            }
        }

        public Pessoa() 
        {
        }
        
        public Pessoa(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                this.nome = value;
            }
        }

        public string Email { get; set; }
    }

}
