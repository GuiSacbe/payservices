using System;
namespace payservices.Util
{
    public class Saldo
    {
        public string Monto { get; set; }
        public int MontoNumerico { get; set; }

        public Saldo(string monto,int montoNumerico)
        {
            Monto = monto;
            MontoNumerico = montoNumerico;
        }

        public Saldo()
        {

        }
    }
}
