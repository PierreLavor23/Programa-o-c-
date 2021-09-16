using System;
using System.Collections.Generic;
using System.Text;

namespace banco.Sistemas
{
    class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool userAutenticado = funcionario.Autenticar(senha);
            if (userAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
