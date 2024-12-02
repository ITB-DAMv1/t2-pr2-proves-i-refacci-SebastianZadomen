using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CalculadoraTests
{
    [TestClass]
    public class ProgramTests
    {
        
        [TestMethod]
        [DataRow("5", 5)]
        [DataRow("10", 10)] 
        [DataRow("abc", 0)]
        public void TestSolicitarEntero(string input, int expectedResult)
        {

            int result = Program.SolicitarEntero();

            Assert.AreEqual(expectedResult, result);  
        }

     
        [TestMethod]
        [DataRow("3.14", 3.14)] 
        [DataRow("2.71", 2.71)] 
        [DataRow("abc", 0)] 
        public void TestValidDecimal(string input, double expectedResult)
        {

            double result = Program.ValidDecimal();

            Assert.AreEqual(expectedResult, result);  
        }

        
        [TestMethod]
        [DataRow(60, "El área es mayor a 50")]
        [DataRow(30, "El área está entre 20 y 50")]
        [DataRow(15, "El área es menor o igual a 20")]
        public void TestValidarArea(double area, string expectedMessage)
        {


            Program.ValidarArea(area);

            string output = writer.ToString();
            Assert.IsTrue(output.Contains(expectedMessage));  // Verificamos que el mensaje esperado esté en la salida
        }
    }
}