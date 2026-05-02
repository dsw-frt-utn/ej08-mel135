namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var p2 = new Problema2();

            string resultado = p2.CrearResumenVenta(1001, "Mouse", 2, 1500);

            Console.WriteLine(resultado);
        }
    }
}
