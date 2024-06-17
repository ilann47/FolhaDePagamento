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
        public Apoio(char cargo, string matricula, double salBase, double gratProd, int numDependentes, string sexo, int idade, string nome) : base(cargo, matricula, salBase, gratProd, numDependentes, sexo, idade, nome)
        {

        }

        public double fornecaAuxEduc()
        {
            if (numDependentes > 5)
                return 300;
            else
                return numDependentes * 60;
        
        }

        public override double fornecaSalarioLiquido()
        {
            return base.fornecaSalarioLiquido() + this.fornecaAuxEduc();
        }
    }
}
