using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prontuario
{
    internal class Animal : Pessoa
    {
        private string Raca;
        private string Sexo;
        private bool Vacinado;
        private Dono tutor; 

        public Animal(string raca, string sexo, bool vacinado, Dono tutor)
        {
            this.Raca = raca;
            this.Sexo = sexo;
            this.Vacinado = vacinado;
            this.tutor = tutor;
        }
        public void setRaca(string Newraca)
        {
            this.Raca = Newraca;
        }
        public string getRaca()
        {
            return this.Raca;
        }
        public void setSexo(string Newsexo)
        {
            this.Sexo = Newsexo; 
        }
        public string getSexo()
        {
            return this.Sexo;
        }
        public void setVacinado(bool Newvacinado)
        {
            this.Vacinado = Newvacinado; 
        }
        public bool getVacinado()
        {
            return this.Vacinado;
        }
        public void setDono(Dono Newtutor)
        {
            this.tutor = Newtutor;
        }
        public Dono getDono()
        {
            return this.tutor;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Dados do animal:\n");
            Console.WriteLine($"Nome : {Nome}");
            Console.WriteLine($"Idade : {Idade}");
            Console.WriteLine($"Raça : {Raca}");
            Console.WriteLine($"Vacinado : {Vacinado}");
            Console.WriteLine($"Sexo : {Sexo}");

        }
    }
}
