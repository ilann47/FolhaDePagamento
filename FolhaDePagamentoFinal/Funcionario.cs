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
        protected char cargo;

        public Funcionario() : base()
        {
            matricula = " ";
            salBase = 0;
            gratProd = 0;
            numDependentes = 0;
            cargo = 'F';
        }



        public Funcionario(char cargo, string matricula, double salBase, double gratProd, int numDependentes, string nome, int idade, string sexo) : base(nome,idade,sexo)
        {
            this.matricula = matricula;
            this.salBase = salBase;
            this.gratProd = gratProd;
            this.numDependentes = numDependentes;
            this.cargo = cargo;
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
        public char Cargo
        {
            get => cargo;
            set => cargo = value;
        }

        public virtual double fornecaSalarioBruto()
        {
            return salBase + gratProd;
        }

        public double fornecaDesconto()
        {
            double salBruto = this.fornecaSalarioBruto();
            double INSS, IR;
            if (salBruto > 0 && salBruto <= 1000)
                IR = 0;
            else if (salBruto > 1000 && salBruto <= 1800)
                IR = (salBruto * 0.10) - 100;
            else if (salBruto > 1800)
                IR = salBruto * 0.25 - 370;
            else
                IR = 0;
            INSS = salBruto * 0.10;
            return IR + INSS;
        }

        public virtual double fornecaSalarioLiquido()
        {
            return (this.fornecaSalarioBruto() - this.fornecaDesconto());
        }






    }
}
