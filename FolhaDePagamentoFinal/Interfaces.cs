using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamentoFinal
{
    internal class Interfaces
    {
        public Interfaces()
        {

        }

        public void pecaEmpresa(ref string razaoSocial, ref string cnpj, ref int NF)
        {
            Console.WriteLine("Entre com a razão social: ");
            razaoSocial = Console.ReadLine();

            Console.WriteLine("Entre com o CNPJ: ");
            cnpj = Console.ReadLine();

            Console.WriteLine("Entre com o numero de funcionarios: ");
            NF = Convert.ToInt32(Console.ReadLine());
        }

        public void pecaDadosFuncionario(ref string nome,ref string sexo, ref int idade, ref string matricula, ref double salBase, ref double gratProd, ref int numDependentes, ref char cargo, ref double gratChefia)
        {
            Console.WriteLine("Digite o nome do funcionario");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do funcionario");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o sexo do funcionario");
            sexo = Console.ReadLine();
            Console.WriteLine("Digite a matricula do funcionario");
            matricula = Console.ReadLine();
            Console.WriteLine("Digite o Tipo de funcionario, (C)chefe, (A)Apoio, (F)Funcionario Normal");
            cargo = Console.ReadKey().KeyChar;
            Console.WriteLine("\nDigite o Salario Base do funcionario");
            salBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a gratificacao de producao do funcionario");
            gratProd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dependentes do funcionario");
            numDependentes = Convert.ToInt32(Console.ReadLine());

            if (cargo == 'C')
            {
                Console.WriteLine("Digite o valor da gratificacao de chefia");
                gratChefia = Convert.ToDouble(Console.ReadLine());
            }

        }

        public void mostraEmpresa(string razaoSocial, string cnpj, int total, double totalBruto, double totalDescontos, double totalLiquido)
        {
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("Razao social: " + razaoSocial);
            Console.WriteLine("CNPJ: " + cnpj);
            Console.WriteLine("Numero de funcionarios: " + total);
            Console.WriteLine("Total de salarios bruto pagos pela empresa: " + totalBruto);
            Console.WriteLine("Total de salarios Liquidos pagos pela empresa: " + totalLiquido);
            Console.WriteLine("Total de descontos: " + totalDescontos);
            Console.WriteLine("--------------------------------------------------------------");


        }

        public void mostraDadosFuncionario(Funcionario funcionario)
        {
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Idade: " + funcionario.Idade);
            Console.WriteLine("Sexo: " + funcionario.Sexo);
            Console.WriteLine("Matricula: " + funcionario.Matricula);
            Console.WriteLine("Salario liquido: " + funcionario.fornecaSalarioLiquido());
            Console.WriteLine("--------------------------------------------------------------\n");

        }
    }
}
