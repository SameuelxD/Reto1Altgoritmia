internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero Entero para mostrar en secuencia");
        int numberN = int.Parse(Console.ReadLine());
        int fa = 1;
        int fb = 0;
        for (int i = 0; i <=numberN; i++)
        {
            int fc = fa + fb;
            fa=fb;
            fb=fc;
            Console.WriteLine($"POSICION {i}: {fa}");
        }
    }
}