using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundAleatorio.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public static int TotalDesenvolvedor { get; private set; }

        public Desenvolvedor(string nome, string cpf) : base(nome, cpf, 2000)
        {            
            Console.WriteLine("Nome: " + nome);            
            Console.WriteLine("Cpf: " + cpf);            
            Console.WriteLine("Salário: " + base.Salario);
            Console.WriteLine();
            TotalDesenvolvedor++;            
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.25;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
