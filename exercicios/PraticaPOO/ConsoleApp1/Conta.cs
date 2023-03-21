using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; private set; }

        public Conta()
        {

        }

        public Conta(int numero, decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
            
        }
    }
}
