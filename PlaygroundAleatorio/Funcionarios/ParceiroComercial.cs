using PlaygroundAleatorio.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundAleatorio.Funcionarios
{
    public class ParceiroComercial : iAutenticavel
    {
        public string Senha { get; set; }
        public string Nome { get; set; }

        public ParceiroComercial (string nome, string senha)
        {
            Nome = nome;
            Console.WriteLine("Nome: Rafa");
            Senha = senha;
            Console.WriteLine();
        }

        public bool Autenticar(string senha)
        {
            if (Senha == senha)
            {                
                return true;
            }
            else
            {                
                return false;
            }
        }
    }
}
