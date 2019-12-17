using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria
{
    class Program //Classe principal de uma console application a qual o .NetFramework vai procurar para iniciar a execução da aplicação
    {
        static void Main(string[] args) //Método principal obrigatório para execução de um console application.
        {
            /*Criação de uma instância da classe "ContaBancaria", passando como parâmetro o nome do titular da conta.
            O resultado é atribuido à uma variável do tipo "ContaBancaria". Diz-se então que "contaDoSolano" é um objeto 
            do tipo "ContaBancaria", ou uma instância da classe "ContaBancaria".
            A conta bancária é iniciada com R$100,00 na propriedade "saldo" pois o construtor que criamos - que é o método que é invocado
            toda vez que um objeto é instanciado - realiza esta operação.*/
            ContaBancaria contaDoSolano = new ContaBancaria("Solano");

            /*Realizando um saque de R$25,50 no saldo do objeto "contaDoSolano". O sufixo "m" no valor é necessário pois é necessário
            especificar o tipo de números com casas decimais - float(f), double(d) ou decimal(m) */
            contaDoSolano.Sacar(25.50m);

            /*Invocando o método "ConsultarSaldo" que imprime no console o valor atual da propriedade "Saldo" do objeto*/
            contaDoSolano.ConsultarSaldo();
        }
    }
}
