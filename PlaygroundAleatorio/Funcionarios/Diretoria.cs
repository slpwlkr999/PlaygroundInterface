using PlaygroundAleatorio.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundAleatorio.Funcionarios
{
    public class Diretoria : FuncionarioAutenticavel, iAutenticavel
    {
        public static int TotalDiretoria { get; private set; }

        public Diretoria(string nome, string cpf) : base(nome, cpf, 5000)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Cpf: " + cpf);
            Console.WriteLine("Salário: " + base.Salario);
            Console.WriteLine();
            TotalDiretoria++;
        }

        public override void AumentarSalario()
        {
            Salario += Salario *= 0.50;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.75;
        }

        public bool Autenticar()
        {
            if (true)
                return true;
            else
                return false;
        }
    }
}
