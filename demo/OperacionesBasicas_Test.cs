using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo
{
    [TestFixture]
    public class OperacionesBasicas_Test
    {
        [Test]
        public void  Sumar_SumaCorrectamente(){
            //Arrenge
            decimal numero1 = 2;
            decimal numero2 = 5;
           

            OperacionesBasicas ob = new OperacionesBasicas();
            // ACT
            decimal resultado =ob.suma(numero1, numero2);
            //Assert

            Assert.AreEqual(7, resultado);
        }

        [Test]
        public void Resta_RestaMayorCero()
        {
            //Arrenge
            decimal numero1 = 1;
            decimal numero2 = 5;


            OperacionesBasicas ob = new OperacionesBasicas();
            // ACT
            decimal resultado = ob.resta(numero1, numero2);
            //Assert

            Assert.LessOrEqual(0, resultado);
        }


        [Test]
        public void Division_DivisorMayorCero()
        {
            //Arrenge
            decimal numero1 = 0;
            decimal numero2 = 0;


            OperacionesBasicas ob = new OperacionesBasicas();
            // ACT
            //decimal resultado = ob.resta(numero1, numero2);
            //Assert

            Assert.Throws<DivideByZeroException>(new TestDelegate(() => ob.division(numero1, numero2)));
        }
    }
}