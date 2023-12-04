internal class Program
{
    private static void Main(string[] args)
    {
        //1. Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-ésimo número de Fibonacci:      
        Console.WriteLine("Ingrese un numero Entero para mostrar su valor en esa posicion");
        int numberN = int.Parse(Console.ReadLine());
        int fa = 1;
        int fb = 0;
        for (int i = 0; i <=numberN; i++)
        {
            int fc = fa + fb;
            fa=fb;
            fb=fc;
        }
        Console.WriteLine($"POSICION {numberN}:{fa}");
    }
}