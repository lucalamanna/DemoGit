internal class Program
{
    private static void Main(string[] args)
    {
        MostrarMenu();
    }

    public static void MostrarMenu()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear(); // Limpia la pantalla
            Console.WriteLine("---- CALCULADORA UBA ----");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("\nSeleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                continuar = false;
                Console.WriteLine("Saliendo del programa... ¡Hasta luego!");
                continue;
            }

            // Pedimos los números
            Console.Write("Ingrese el primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            // Procesamos la opción
            switch (opcion)
            {
                case "1":
                    Sumar(n1, n2);
                    break;

                case "2":
                    Restar(n1, n2);
                    break;

                case "3":
                    Multiplicar(n1, n2);
                    break;

                case "4":
                    Dividir(n1, n2);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    public static void Sumar(double a, double b)
    {
        double resultado = a + b;
        Console.WriteLine($"Suma: {a} + {b} = {resultado}");
    }

    public static void Restar(double a, double b)
    {
        double resultado = a - b;
        Console.WriteLine($"Resta: {a} - {b} = {resultado}");
    }

    public static void Multiplicar(double a, double b)
    {
        double resultado = a * b;
        Console.WriteLine($"Multiplicación: {a} * {b} = {resultado}");
    }

    public static void Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        else
        {
            double resultado = a / b;
            Console.WriteLine($"División: {a} / {b} = {resultado}");
        }
    }
}