using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinica.Helpers
{
    public static class CriadorDeIds
    {
        private static int IdPaciente { get; set; } //Propridade privada IdPaciente. Não é possível acessar este valor diretamente de fora desta classe.
        private static int IdProfissional { get; set; } //Propridade privada IdProfissional. Não é possível acessar este valor diretamente de fora desta classe.
        private static int IdConsulta { get; set; } //Propridade privada IdConsulta. Não é possível acessar este valor diretamente de fora desta classe.

        //Construtor estático da classe CriadorDeIds. Utilize-o para inicializar as propriedades IdPaciente, IdProfissional e IdConsulta
        //com o valor "1", ou seja, o menor ID que pode ser atribuído.
        static CriadorDeIds()
        {
            IdPaciente = 1;                                                      //Inicializar o valor da propriedade IdPaciente
            IdProfissional = 1;                                              //Inicializar o valor da propriedade IdProfissional
            IdConsulta = 1;                                                      //Inicializar o valor da propriedade IdConsulta
        }

        public static int CriarNovoIdPaciente()
        {
            int idpaciente = IdPaciente;                                                                          //Retornar o valor atual da propriedade IdPaciente e somar 1 à propriedade para que 
            IdPaciente++;
            return idpaciente;                                                                                  //da próxima vez que o método for chamado ele dê um novo ID
        }

        public static int CriarNovoIdProfissional()
        {
            int idprofissional = IdProfissional;                                                                             //Retornar o valor atual da propriedade IdProfissional e somar 1 à propriedade para que 
            IdProfissional++;
            return idprofissional;                                                          //da próxima vez que o método for chamado ele dê um novo ID
        }

        public static int CriarNovoIdConsulta()
        {
            int idconsulta = IdConsulta;                                                                           //Retornar o valor atual da propriedade IdConsulta e somar 1 à propriedade para que 
            IdConsulta++;
            return idconsulta;                                                                          //da próxima vez que o método for chamado ele dê um novo ID
        }
    }
}