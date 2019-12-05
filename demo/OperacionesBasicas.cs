using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo
{
    public class OperacionesBasicas

    {

        public decimal suma( Decimal numero1, Decimal numero2)
        {
            return numero1 + numero2;
        }
        public decimal resta(Decimal numero1, Decimal numero2)
        {
            return numero1 -numero2;
        }
        public decimal multiplicacion(Decimal numero1, Decimal numero2)
        {
            return numero1 * numero2;
        }
        public decimal division(Decimal numero1, Decimal numero2)
        {
            return numero1 / numero2;
        }
    }
}