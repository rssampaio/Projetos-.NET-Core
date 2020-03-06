using System;

namespace ControleBanco
{
    class ContaBancaria
    {
        private string _titular;
        public int NroConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public String Titular
        {
            get { return _titular; }

            set
            {
                if ( value == null || value == "")
                {
                    _titular  = "<Não Info>";
                }
                else
                {
                    _titular = value;
                }
            }
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= (valor + 5);
        }
        public override string ToString()
        {
            return "\n"
            + "Dados da Conta: \n"
            + "Conta: "
            + NroConta.ToString()
            + ", Titular: "
            + _titular
            + ", Saldo: "
            + Saldo.ToString();
        }

    }
}
