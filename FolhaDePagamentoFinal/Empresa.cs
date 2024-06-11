using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Empresa
    {
        protected string razaoSocial;
        protected string cnpj;
        protected int NF;
        protected double total;

        public Empresa()
        {
        }

        public Empresa(string VRS, int VNF, string cnpj)
        {
            this.razaoSocial = VRS;
            this.cnpj = cnpj;
            this.NF = VNF;
            if(VNF < 0)
                this.NF = 0;
            this.total = 0;
        }

        public string informeRazaoSocial()
        {
            return razaoSocial;
        }

        public int informeNF()
        {
            return NF;
        }

        public double informeTotal()
        {
            return total;
        }

        public void processeFolha(Interfaces interfaces)
        {
            Funcionario funcionario;
            int cont = 0;
            int tipo = 0;
            int numDependentes = 0;
            int idade  = 0;
            string sexo = "";
            string nome = "";
            string matricula = "";
            double salBase = 0.0;
            double gratProd = 0.0;
            double gratChefia = 0.0;

            cont = 0;
            while (cont < NF)
            {
                interfaces.pecaDadosFuncionario(ref nome, ref sexo, ref idade, ref matricula, ref salBase, ref gratProd, ref numDependentes, ref tipo, ref gratChefia); 
                if (tipo == 3)
                {
                    funcionario = new Funcionario(matricula, salBase, gratProd, numDependentes, nome, idade, sexo);
                    total = total + funcionario.fornecaSalarioBruto();
                    interfaces.mostraDadosFuncionario(funcionario);
                    interfaces.mostraEmpresa(razaoSocial, cnpj, NF);
                    cont++;


                }
                else if (tipo == 2)
                {
                    funcionario = new Chefe(gratChefia, matricula, salBase, gratProd, numDependentes, sexo, idade, nome);
                    ((Chefe)funcionario).GratChefia = gratChefia;
                    total = total + funcionario.fornecaSalarioBruto();
                    interfaces.mostraDadosFuncionario(funcionario);
                    interfaces.mostraEmpresa(razaoSocial, cnpj, NF);
                    cont++;

                }
                else if (tipo == 1)
                {
                    funcionario = new Apoio(matricula, salBase, gratProd, numDependentes, nome, idade, sexo);
                    total = total + funcionario.fornecaSalarioBruto();
                    interfaces.mostraDadosFuncionario(funcionario);
                    interfaces.mostraEmpresa(razaoSocial, cnpj, NF);
                    cont++;


                }
            }
        }
        public string RazaoSocial
        {
            get => razaoSocial;
            set => razaoSocial = value;
        }
        public int VNF
        {
            get => NF;
            set => NF = value;
        }

    }
}
