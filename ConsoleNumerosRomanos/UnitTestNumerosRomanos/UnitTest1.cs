using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleNumerosRomanos;

namespace UnitTestNumerosRomanos
{
    [TestClass]
    public class UnitTest1
    {
        CNumeroRomano romano;
        string result;

        [TestInitialize]
        public void TestInitialize()
        {
            romano = new CNumeroRomano();
            result = string.Empty;
        }

        [TestMethod]
        public void Numeros_simples()
        {
            int num = 1;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("I", result);

            num = 5;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("V", result);

            num = 10;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("X", result);

            num = 50;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("L", result);

            num = 100;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("C", result);

            num = 500;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("D", result);

            num = 1000;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void Numeros_duplicados()
        {
            int num = 2;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("II", result);

            num = 20;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XX", result);

            num = 200;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("CC", result);
        }

        [TestMethod]
        public void Numeros_triplicados()
        {
            int num = 3;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("III", result);

            num = 30;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XXX", result);

            num = 300;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("CCC", result);
        }

        [TestMethod]
        public void Numeros_compuestos()
        {
            int num = 4;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("IV", result);

            num = 9;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("IX", result);

            num = 13;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XIII", result);

            num = 14;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XIV", result);

            num = 19;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XIX", result);

            num = 24;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XXIV", result);

            num = 89;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("LXXXIX", result);
        }

        [TestMethod]
        public void Numeros_cuarenta()
        {
            int num = 40;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XL", result);

            num = 49;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XLIX", result);
        }

        [TestMethod]
        public void Numeros_noventa()
        {
            int num = 90;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XC", result);

            num = 91;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XCI", result);

            num = 98;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("XCVIII", result);
        }

        [TestMethod]
        public void Numeros_cuatrocientos()
        {
            int num = 400;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("CD", result);

            num = 444;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("CDXLIV", result);

            num = 496;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("CDXCVI", result);
        }

        [TestMethod]
        public void Numeros_novecientos()
        {
            int num = 900;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("CM", result);

            num = 999;
            result = romano.ImprimeRomano(ref num);
            Assert.AreEqual("CMXCIX", result);
        }
    }
}
