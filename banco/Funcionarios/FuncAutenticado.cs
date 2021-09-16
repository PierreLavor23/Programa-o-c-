using banco.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace banco.Funcionarios
{
    public  abstract  class FuncAutenticado : Funcionario, IAutenticavel
    {
        protected FuncAutenticado(string nome, string cPF, double salario) : base(nome, cPF, salario)
        {
        }

        public string Senha { get; set; }
        
      
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
 