using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
   public  abstract class Funcionario 
    {
       
        public int TotalFuncionarios { get; private set; }
        public string nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cPF, double salario)
        {
            this.nome = nome;
            CPF = cPF;
            Salario = salario;
            TotalFuncionarios++;
        }
            

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
       
            
        }
    }
