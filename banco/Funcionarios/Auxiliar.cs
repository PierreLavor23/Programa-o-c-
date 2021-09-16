using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class Auxiliar:Funcionario
    {
        public Auxiliar(string nome, string cPF, double salario) : base(nome, cPF, salario)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.10);

        }
    }
}
