using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Empresa
    {
        private string razaoSocial;
        private string cnpj;
        private int NF;
        private int total;
        private double totalLiquido;
        private double totalBruto;
        private double totalDescontos;

        public Empresa()
        {
            razaoSocial = "";
            cnpj = "";
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
        public string RazaoSocial
        {
            get => razaoSocial;
            set => razaoSocial = value;
        }
        public string Cnpj
        {
            get => cnpj;
            set => cnpj = value;    
        }
        public int VNF
        {
            get => NF;
            set => NF = value;
        }
        public double TotalBruto
        {
            get => totalBruto;
            set => totalBruto = value;
        }
        public double TotalDescontos
        {
            get => totalDescontos;
            set => totalDescontos = value;
        }
        public double TotalLiquido
        {
            get => totalLiquido; 
            set => totalLiquido = value;
        }
        public int Total
        {
            get => total; 
            set => total = value;
        }


        public string informeRazaoSocial()
        {
            return razaoSocial;
        }

        public int informeNF()
        {
            return NF;
        }

        public double informeTotalBruto()
        {
            return totalBruto;
        }

        public void processeFolha(Interfaces interfaces)
        {
            Funcionario funcionario;
            int cont = 0;
            int numDependentes = 0;
            int idade  = 0;
            string sexo = "";
            string nome = "";
            string matricula = "";
            double salBase = 0.0;
            double gratProd = 0.0;
            double gratChefia = 0.0;
            char cargo = 'F';

            cont = 0;
            while (cont < NF)
            {
                interfaces.pecaDadosFuncionario(ref nome, ref sexo, ref idade, ref matricula, ref salBase, ref gratProd, ref numDependentes, ref cargo, ref gratChefia);
                if (cargo == 'A')
                {
                    funcionario = new Apoio(cargo, matricula, salBase, gratProd, numDependentes, nome, idade, sexo);
                    cont++;


                }
                else if (cargo == 'C')
                {
                    funcionario = new Chefe(cargo, gratChefia, matricula, salBase, gratProd, numDependentes, sexo, idade, nome);
                    ((Chefe)funcionario).GratChefia = gratChefia;
                    cont++;

                }
                else
                {
                    funcionario = new Funcionario(cargo, matricula, salBase, gratProd, numDependentes, nome, idade, sexo);
                    cont++;


                }

                total = this.informeNF();
                totalBruto += funcionario.fornecaSalarioBruto();
                totalDescontos += funcionario.fornecaDesconto();
                totalLiquido += funcionario.fornecaSalarioLiquido();
                interfaces.mostraDadosFuncionario(funcionario);
            }

        }


    }
}
