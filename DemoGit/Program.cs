internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static void Sumar(double a, double b)
    {
        double resultado = a + b;
        Console.WriteLine($"Suma: {a} + {b} = {resultado}");
    }

    public static void Multiplicar(double a, double b)
    {
        double resultado = a * b;
        Console.WriteLine($"Multiplicación: {a} * {b} = {resultado}");
    }
}