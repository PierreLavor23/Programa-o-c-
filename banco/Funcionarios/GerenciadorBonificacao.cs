using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    public class GerenciadorBonificacao
    {
     

        public double totalBonificacao { get;  private set; }
        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return totalBonificacao;
        }
    }
}
