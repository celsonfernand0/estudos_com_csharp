using static System.Console;
namespace separador_de_nome;
class Program
{
    public static void Main()
    {
       WriteLine("Informe o seu nome completo");
       string? nome = ReadLine();
       
       string[] nomes = nome.Split(@" ");
       Clear();
       foreach (var item in nomes)
       {
         WriteLine(item);
       }



    }
}