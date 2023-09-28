using System;
using Cadastro;
namespace App;

public static class Program
{

    public static void Main()
    {
        Alunos CadastraAluno = new Alunos()
        {


        };
        string op = "";
        bool cond = true;

        while (cond)
        {

            System.Console.WriteLine("Sejá Bem-Vindo ao Sistema de Cadastro\n Caso deseja se cadastrar com um Estudante digite 1\n Caso deseja se Cadastrar com Professor digite 0");
            op = Console.ReadLine();
            Console.Clear();

            if (op == "1")
            {
                CadastraAluno.CadastrarAluno();
                cond = false;

            }
            else if (op == "0")
            {
                cond = false;
            }


        }






    }
}