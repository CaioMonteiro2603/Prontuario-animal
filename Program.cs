using Prontuario;
using System;

namespace TrabalhoMentoria
{
    class Program
    {
        static void Main()
        {
            Pessoa main = new Pessoa();
            Dono tutor = new Dono('M', "488.545.748-65", 1025);
            Animal cachorro = new Animal("SRD", "Macho", true, new Dono('F', "487.588.789-20", 1455));

            tutor.Nome = "Marcelo Ribas Souza!";
            tutor.Idade = 31;
            cachorro.Nome = "Fred";
            cachorro.Idade = 4;

             string resposta = (cachorro.getVacinado() == true) ? "Sim" : "Não";
            Console.WriteLine(resposta); 
            
            


            tutor.Apresentar();

            cachorro.Apresentar(); 

        }
    }
}
