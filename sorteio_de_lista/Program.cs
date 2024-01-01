using System;
using System.Collections.Generic;

namespace Sorteio_de_Lista
{
    public class Program
    {
        public static void Main()
        {
            List<string> Alunos = new List<string>
            {
                "Celson Paião",
                "Jessé Inglês",
                "Mateus Abreu",
                "João Carlos",
                "Maurício Santana",
                "Leandro Gonçalves",
                "Eliezer Carlos",
                "Daniel Dala",
                "Igor Cabila",
                "Benjamim Luzolu",
                "Yuane Castro"

            };
             int contador = 1;

            // Shuffle the list randomly
            Random rng = new Random();
            int n = Alunos.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = Alunos[k];
                Alunos[k] = Alunos[n];
                Alunos[n] = value;
            }

            // Create pairs of adjacent elements
            Console.WriteLine("Grupos formados:");
           
            for (int i = 0; i < Alunos.Count; i += 2)
            {
                if (i + 1 < Alunos.Count)
                {
                    Console.WriteLine($"Grupo {contador}: {Alunos[i]}, {Alunos[i + 1]}");
                }
                else
                {
                    Console.WriteLine($"Grupo único: {Alunos[i]}");
                }
                contador ++;
            }
        }
    }
}
