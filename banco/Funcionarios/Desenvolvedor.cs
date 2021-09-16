using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string cPF, double salario) : base(nome, cPF, salario)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
        public override void AumentarSalario()
        {
            Salario *= 0.15;

        }
    }
}
