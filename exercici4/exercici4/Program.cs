using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escoge una opción para calcular \n 1. Rectángulo \n 2. Círculo");
            int opciones = SolicitarEntero();

            switch (opciones)
            {
                case 1:
                    CalculosRectangulo();
                    CalculosCirculo();
                    break;
                case 2:
                    CalculosCirculo();
                    CalculosRectangulo();
                    break;
                default:
                    Console.WriteLine("Selección incorrecta, por favor, elige nuevamente.");
                    break;
            }
        }
    }

    public static void CalculosRectangulo()
    {
        Console.WriteLine("Introduce el ancho del rectángulo:");
        double width = ValidDecimal();
        Console.WriteLine("Introduce la altura del rectángulo:");
        double height = ValidDecimal();

        double area = width * height;
        Console.WriteLine($"El área del rectángulo es: {area}");
        ValidarArea(area);
    }

    public static void CalculosCirculo()
    {
        Console.WriteLine("Introduce el radio del círculo:");
        double radius = ValidDecimal();
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine($"La circunferencia del círculo es: {circumference}");
    }

    public static void ValidarArea(double area)
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

    public static int SolicitarEntero()
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int resultado))
            {
                return resultado;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
            }
        }
    }

   
    public static double ValidDecimal()
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out double resultado))
            {
                return resultado;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número decimal válido.");
            }
        }
    }
}