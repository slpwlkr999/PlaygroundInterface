using System;

namespace PlaygroundAleatorio.Sistema
{
    public class Login
    { 
        public bool Acesso (iAutenticavel autenticavel, string senha)
        {
            bool userAut = autenticavel.Autenticar(senha);
            if (userAut == true)
            {
                Console.WriteLine("Acesso Permitido.");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("Acesso Negado.");
                Console.WriteLine();
                return false;
            }                
        }
    }
}
