
using banco.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
