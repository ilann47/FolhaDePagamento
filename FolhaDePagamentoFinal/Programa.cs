using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Programa
    {
        private Interfaces inter;
        private Empresa empresa;

        public Programa() 
        {
            inter = new Interfaces();        
        }
        public void Run()
        {
            string razaoSocial = "";
            string cnpj = "";
            int NF = 0;


            inter.pecaEmpresa(ref razaoSocial, ref cnpj, ref NF);
            empresa = new Empresa(razaoSocial,NF, cnpj);
            empresa.processeFolha(inter);
            inter.mostraEmpresa(empresa);

        }
    }
}
