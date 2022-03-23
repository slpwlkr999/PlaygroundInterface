using System;

namespace PlaygroundAleatorio.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionario { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;            
            CPF = cpf;
            Salario = salario;            
            TotalFuncionario++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
