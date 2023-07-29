using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prontuario
{
    internal class Dono : Pessoa
    {
        private char Sexo;
        private string CPF;
        private int NumeroAtendimento; 

        public Dono(char sexo, string cpf, int numeroatendimento)
        {
            this.Sexo = sexo;
            this.CPF = cpf;
            this.NumeroAtendimento = numeroatendimento; 
        }
        
        public void setSexo(char Newsexo)
        {
            this.Sexo = Newsexo;
        }
        public char getSexo()
        {
            return this.Sexo;
        }
        public void setCPF(string Newcpf)
        {
            this.CPF = Newcpf;
        }
        public string getCPF()
        {
            return this.CPF;
        }
        public void setNumeroAtendimento(int Newnumeroatendimento)
        {
            this.NumeroAtendimento = Newnumeroatendimento;
        }
        public int getNumeroAtendimento()
        {
            return this.NumeroAtendimento; 
        }

        public override void Apresentar()
        {
            Console.WriteLine("Dados do tutor:\n ");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Número de atendimento: {NumeroAtendimento}");
            Console.WriteLine($"CPF: {CPF}\n"); 
        }

       
    }

}
