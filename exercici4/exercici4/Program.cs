using System;

public  class Program
{
    public static void Main(string[] args)
    {
       
        double ancho = ImputNumero("Introduce el ancho del rectángulo:");
        double alto = ImputNumero("Introduce el alto del rectángulo:");

        // Calcula el área
        double area = CalcularAreaRectangulo(ancho, alto);
        Console.WriteLine($"El área del rectángulo es: {area}");

      
        double radio = ImputNumero("Introduce el radio del círculo:");
        double circunferencia = CalcularCircunferencia(radio);
        Console.WriteLine($"La circunferencia del círculo es: {circunferencia}");


        ImprimirMensajeArea(area);
    }

    public static double ImputNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }

    public static double CalcularAreaRectangulo(double ancho, double alto)
    {
        return ancho * alto;
    }

    public static double CalcularCircunferencia(double radio)
    {
        return 2 * Math.PI * radio;
    }

    public static void ImprimirMensajeArea(double area)
    {
        if (area > 50)
        {
            Console.WriteLine("El área es mayor a 50");
        }
        else if (area > 20)
        {
            Console.WriteLine("El área está entre 20 y 50");
        }
        else
        {
            Console.WriteLine("El área es menor o igual a 20");
        }
    }
}