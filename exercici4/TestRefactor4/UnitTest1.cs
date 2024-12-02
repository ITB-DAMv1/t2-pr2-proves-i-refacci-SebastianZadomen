using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PruebasGeometria
{
    [TestMethod]
    public void TestCalcularAreaRectangulo()
    {
    
        double ancho = 5;
        double alto = 10;

        double resultado = Program.CalcularAreaRectangulo(ancho, alto);

        Assert.AreEqual(50, resultado, "El cálculo del área del rectángulo es incorrecto");
    }

    [TestMethod]
    public void TestCalcularCircunferenciaCirculo()
    {

        double radio = 7;

        double resultado = Program.CalcularCircunferencia(radio);

        Assert.AreEqual(2 * Math.PI * 7, resultado, "El cálculo de la circunferencia del círculo es incorrecto");
    }

    [TestMethod]
    public void TestImprimirMensajeArea_Mayor50()
    {
     
        double area = 60;

        Assert.AreEqual("El área es mayor a 50", ObtenerMensajeArea(area));
    }

    [TestMethod]
    public void TestImprimirMensajeArea_Entre20y50()
    {
 
        double area = 30;


        Assert.AreEqual("El área está entre 20 y 50", ObtenerMensajeArea(area));
    }

    [TestMethod]
    public void TestImprimirMensajeArea_Menor20()
    {

        double area = 10;

        Assert.AreEqual("El área es menor o igual a 20", ObtenerMensajeArea(area));
    }

    private string ObtenerMensajeArea(double area)
    {
        if (area > 50)
        {
            return "El área es mayor a 50";
        }
        else if (area > 20)
        {
            return "El área está entre 20 y 50";
        }
        else
        {
            return "El área es menor o igual a 20";
        }
    }
}