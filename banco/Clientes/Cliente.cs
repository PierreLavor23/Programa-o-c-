using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    public class Cliente
    {
        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
    }
}
