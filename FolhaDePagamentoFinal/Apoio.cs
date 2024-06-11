using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Apoio : Funcionario
    {
        public Apoio() : base()
        {

        }
        public Apoio(string matricula, double salBase, double gratProd, int numDependentes, string sexo, int idade, string nome) : base(matricula, salBase, gratProd, numDependentes, sexo, idade, nome)
        {

        }



        public double fornecaAuxEduc()
        {
            if (numDependentes > 5)
                return 300;
            else
                return numDependentes * 60;
        
        }


        public override double fornecaSalarioBruto()
        {
            return this.fornecaDesconto() + this.fornecaAuxEduc();
        }


        public override double fornecaDesconto()
        {
            double brutoBase;

            brutoBase = salBase + gratProd;

            if (brutoBase > 0 && brutoBase <= 1000)
                return 0;
            else if (brutoBase > 1000 && brutoBase <= 1800)
                return brutoBase - ((brutoBase * 0.10) + (brutoBase * 0.10) + 100);
            else if (brutoBase > 1800)
                return brutoBase - ((brutoBase * 0.25) + (brutoBase * 0.10) + 370);
            else
                return 0;
        }

        public override double fornecaSalarioLiquido()
        {
            return base.fornecaSalarioLiquido() + this.fornecaAuxEduc();
        }
    }
}
