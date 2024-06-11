using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Pessoa
    {
        protected string nome;
        protected int idade;
        protected string sexo;


        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }


        public int Idade
        {
            get => idade;
            set => idade = value; 
        }

        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }
    }
}
