using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Cadastro;
public class Alunos : Props
{

    public void CadastrarAluno()
    {


        System.Console.WriteLine("Informe o seu Nome Completo");
        _Name = Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Informe a sua idade");
        _Old = Decimal.Parse(Console.ReadLine());
        Console.Clear();

        System.Console.WriteLine("Informe a sua altura");
        _Heigh = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        System.Console.WriteLine($"Aluno {_Name} Cadastrado com SUCESSO!");



    }
}


