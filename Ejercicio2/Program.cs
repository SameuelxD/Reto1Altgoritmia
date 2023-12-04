internal class Program
{
    private static void Main(string[] args)
    {
        //2. Escriba un programa que reciba como entrada un número entero e indique si es o no un número de Fibonacci:
        Console.WriteLine("Ingrese un numero Entero para buscar");
        int numberN = int.Parse(Console.ReadLine());
        int fa = 1;
        int fb = 0;
        var estado=false;
        while(fb<=numberN)
        {
            int fc = fa + fb;
            fa=fb;
            fb=fc;
            estado= fa == numberN ? true:false;
        }
        if(estado){
            Console.WriteLine($"El numero {numberN} es un numero de fibbonacci");
        }
        else{
            Console.WriteLine($"El numero {numberN} no es un numero de fibbonacci");
        }
    }
}