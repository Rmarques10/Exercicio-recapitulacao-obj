using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_recapitulacao_obj
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }
        public override string ToString()
        {
            return "Numero: " 
                + Numero
                +", Nome do titular: "
                + Titular
                +", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}