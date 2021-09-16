

using banco.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace banco.Funcionarios
{
    public class Diretor : FuncAutenticado
    {
        public Diretor(string nome, string cPF, double salario) : base(nome, cPF, salario)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.50; 
        }
        
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.15);
           
        }
    }
}
