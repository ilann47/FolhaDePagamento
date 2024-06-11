using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Chefe : Funcionario
    {
        private double gratChefia;

        public Chefe() 
        { 
            gratChefia = 0;
        }

        public Chefe(double gratChefia, string matricula, double salBase, double gratProd, int numDependentes, string sexo, int idade, string nome) : base(matricula, salBase, gratProd, numDependentes, sexo, idade, nome)
        {
            this.gratChefia = gratChefia;
        }



        public override double fornecaSalarioBruto()
        {
            return this.gratChefia +  base.fornecaSalarioBruto();
        }





        public double GratChefia
        {
            get => gratChefia;
            set => gratChefia = value;
        }
    }
}
