using System;
using Login.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace Login.Pages;
public class PageLogin
{
    ControllerLogin Action = new ControllerLogin();
    bool cond = true;
    public void Logar()
    {

        while (cond)
        {
            System.Console.WriteLine("Informe o nome");
            Action.name = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Informe a password");
            Action.password = Console.ReadLine();
            Console.Clear();

            if (Action.ActionController() == true)
            {
                System.Console.WriteLine($"Usuário {Action.Acessname} Logado com Sucesso");
                cond = false;
            }
            else
            {

                System.Console.WriteLine("ERRO");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }




        }





    }
}