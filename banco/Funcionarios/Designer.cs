using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class Designer : Funcionario
    {
        public Designer(string nome, string cPF, double salario) : base(nome, cPF, salario)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.11);

        }
    }
}
