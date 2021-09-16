using banco;

namespace banco
{
  
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
            


        public banco.Cliente titular { get; set; }
        private int _agencia;
        public int Agencia {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    System.Console.WriteLine("ERRO NO PROGRAMA");
                    return; //para o programa
                }
                _agencia = value;
            }
                
        }
        public int Numero { get; set; }
        private double _saldo;
        public double Saldo {
            get
            {
                return _saldo;
            }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("ERRO NO PROGRAMA");
                    return;
                }
                 _saldo = value;
            }
        }


        public ContaCorrente(Cliente titular, int agencia, int numero, double saldo)
        {
            this.titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            this.Saldo = saldo;
            TotalDeContasCriadas++;
        }


       
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine("SAQUE EFETUADO");

            }
            else
            {
                System.Console.WriteLine("SALDO INSUFICIENTE");
            }

        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            System.Console.WriteLine("VALOR DEPOSITADO");

        }
        public double Transferir(double valor, double conta)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                conta += valor;
                System.Console.WriteLine("TRANSFÊNCIA EFETUADA.");
            }
            else
            {
                System.Console.WriteLine("SALDO INSUFICIENTE");
            }
            return 1;
        }
    }
}