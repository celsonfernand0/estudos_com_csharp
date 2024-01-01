namespace fibonacci;

public static class Program
{
    public static void Main(){
        System.Console.WriteLine("Informe o valor inicial");
        decimal n = Convert.ToDecimal(Console.ReadLine());
        decimal n0, n1;
         
          System.Console.WriteLine("A sequência é:");
        for (int i = 0; i <= 10; i++)
        {
            n0 = n;
            n1 = n+1;
            n = n0+n1;
            System.Console.WriteLine($"{n0} {n1} {n}"); 
            n++;
        }

    }
}