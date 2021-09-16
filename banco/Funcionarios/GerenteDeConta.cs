using banco.Funcionarios;
using banco.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class GerenteDeConta : FuncAutenticado

    {
        public GerenteDeConta(string nome, string cPF, double salario) : base(nome, cPF, salario)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.5);

        }
    }
}
