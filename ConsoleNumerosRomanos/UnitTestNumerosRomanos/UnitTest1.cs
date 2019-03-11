using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleNumerosRomanos;

namespace UnitTestNumerosRomanos
{
    [TestClass]
    public class UnitTest1
    {
        CTiposNumeros numero;
        string result;

        [TestInitialize]
        public void TestInitialize()
        {
            numero = new CTiposNumeros();
            result = string.Empty;
        }

        [TestMethod]
        public void Numeros_simples()
        {
            int num = 1;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("I", result);

            num = 5;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("V", result);

            num = 10;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("X", result);

            num = 50;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("L", result);

            num = 100;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("C", result);

            num = 500;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("D", result);

            num = 1000;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void Numeros_duplicados()
        {
            int num = 2;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("II", result);

            num = 20;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XX", result);

            num = 200;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("CC", result);
        }

        [TestMethod]
        public void Numeros_triplicados()
        {
            int num = 3;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("III", result);

            num = 30;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XXX", result);

            num = 300;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("CCC", result);
        }

        [TestMethod]
        public void Numeros_compuestos()
        {
            int num = 4;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("IV", result);

            num = 9;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("IX", result);

            num = 13;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XIII", result);

            num = 14;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XIV", result);

            num = 19;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XIX", result);

            num = 24;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XXIV", result);

            num = 89;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("LXXXIX", result);
        }

        [TestMethod]
        public void Numeros_cuarenta()
        {
            int num = 40;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XL", result);

            num = 49;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XLIX", result);
        }

        [TestMethod]
        public void Numeros_noventa()
        {
            int num = 90;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XC", result);

            num = 91;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XCI", result);

            num = 98;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("XCVIII", result);
        }

        [TestMethod]
        public void Numeros_cuatrocientos()
        {
            int num = 400;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("CD", result);

            num = 444;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("CDXLIV", result);

            num = 496;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("CDXCVI", result);
        }

        [TestMethod]
        public void Numeros_novecientos()
        {
            int num = 900;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("CM", result);

            num = 999;
            result = numero.ConvierteARomano(ref num);
            Assert.AreEqual("CMXCIX", result);
        }


        [TestMethod]
        public void Romano_a_numero()
        {
            string romano = "";
            int result = 0;
            int num = 0;

            for (int i = 1; i < 1000; i++)
            {
                num = i;
                romano = numero.ConvierteARomano(ref num);
                result = numero.ConvierteAArabico(romano);
                Assert.AreEqual(i, result);
            }
        }

        [TestMethod]
        public void Romano_a_mil()
        {
            int result = numero.ConvierteAArabico("L");
            Assert.AreEqual(50, result);
        }
    }
}
