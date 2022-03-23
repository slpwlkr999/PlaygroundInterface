using PlaygroundAleatorio.Funcionarios;
using PlaygroundAleatorio.Sistema;
using System;

namespace PlaygroundAleatorio
{
    public class Program
    {
        static void Main(string[] args)
        {
            LogInAutenticavel();            
            LogInFuncionario();
            Console.ReadLine();
        }

        private static void LogInFuncionario()
        {
            Funcionario lucas = new Desenvolvedor("Lucas", "999");
            Console.WriteLine("Bonificação: " + lucas.GetBonificacao());
            lucas.AumentarSalario();
            Console.WriteLine("Novo Salário: " + lucas.Salario);
        }

        private static void LogInAutenticavel()
        {
            Diretoria damiao = new Diretoria("Damião", "777");
            damiao.Senha = "1234";
            Login sistema = new Login();
            sistema.Acesso(damiao, "1234");
            ParceiroComercial tioRafa = new ParceiroComercial("Tio Rafa", "2345");            
            sistema.Acesso(tioRafa, "2346");
        }
    }
}
