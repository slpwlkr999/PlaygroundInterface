using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundAleatorio.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public bool Autenticar(string senha)
        {
            if (Senha == senha)
                return true;
            else
                return false;
        }
    }
}
