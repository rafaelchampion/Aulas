using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria
{
    //Declaração da classe ContaBancaria. Modificador de acesso "public" é necessário para que se possa instanciar um objeto desta classe a partir de outras classes
    public class ContaBancaria
    {
        //Propriedades da classe
        public string nomeTitular { get; set; }
        private decimal saldo { get; set; }

        /*Construtor da classe ContaBancaria. Um construtor é sempre um método público sem retorno com o mesmo nome da classe.
         É possível receber um ou mais parâmetros mas não é obrigatório receber parâmetros.
         A função do método construtor é realizar uma ou mais operações sempre que uma instância da respectiva classe é criada.
         O método construtor da classe "ContaBancaria" recebe um parâmetro do tipo string que será posteriormente vinculado à propriedade "nomeTitular"*/

        public ContaBancaria(string NomeTitular)
        {
            /*Assiciando o parâmetro "NomeTitular" à propriedade "nomeTitular" da classe*/
            nomeTitular = NomeTitular;
            /*Adicionando 100 ao saldo*/
            saldo += 100;
        }


        public void ConsultarSaldo()
        {
            Console.WriteLine("Seu saldo é: " + saldo);
        }


        /*Método Sacar
         Este método implementa um conceito importante de Orientação à Objetos chamado ENCAPSULAMENTO
         Segundo este conceito, deve-se evitar expor propriedades de uma classe sempre que possível
         evitando-se o seu acesso direto, e modificando-as somente por meio de métodos.
         Como exemplo, a propriedade "saldo" é muito sensível para ficar exposta para que qualquer classe
         ou método a modifique - abrindo assim chances para modificação direta do valor.
         O método Sacar valida as regras do negócio antes de permitir a modificação do saldo e evita que
         esta propriedade fique exposta.*/
        public void Sacar(decimal valorSaque)
        {
            if(saldo - valorSaque >= 0)
            {
                saldo -= valorSaque;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void Depositar(decimal valorDeposito)
        {
            saldo += valorDeposito;
        }
    }
}
