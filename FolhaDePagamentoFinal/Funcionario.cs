using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Funcionario : Pessoa
    {

        protected string matricula;
        protected double salBase;
        protected double gratProd;
        protected int numDependentes;

        public Funcionario() : base()
        {
            matricula = " ";
            salBase = 0;
            gratProd = 0;
            numDependentes = 0;
        }



        public Funcionario(string matricula, double salBase, double gratProd, int numDependentes, string nome, int idade, string sexo) : base(nome,idade,sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
            this.matricula = matricula;
            this.salBase = salBase;
            this.gratProd = gratProd;
            this.numDependentes = numDependentes;
        }

        public string Matricula 
        {
            get => matricula;
            set => matricula = value;
        }
        public double SalBase
        { 
            get => salBase; 
            set => salBase = value; 
        }
        public double GratProd
        { 
            get => gratProd; 
            set => gratProd = value; 
        }
        public int NumDependentes
        { 
            get => numDependentes; 
            set => numDependentes = value;
        }

        public virtual double fornecaSalarioBruto()
        {
            return salBase + gratProd;
        }

        public virtual double fornecaDesconto()
        {
            if (this.fornecaSalarioBruto() > 0 && this.fornecaSalarioBruto() <= 1000)
                return 0;
            else if (this.fornecaSalarioBruto() > 1000 && this.fornecaSalarioBruto() <= 1800)
                return this.fornecaSalarioBruto() - ((this.fornecaSalarioBruto() * 0.10) + (this.fornecaSalarioBruto() * 0.10) + 100);
            else if (this.fornecaSalarioBruto() > 1800)
                return this.fornecaSalarioBruto() - ((this.fornecaSalarioBruto() * 0.25) + (this.fornecaSalarioBruto() * 0.10) + 370);
            else
                return 0;
        }

        public virtual double fornecaSalarioLiquido()
        {
            return (this.fornecaSalarioBruto() - this.fornecaDesconto());
        }






    }
}
