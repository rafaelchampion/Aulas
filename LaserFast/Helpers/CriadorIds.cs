using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserFast.Helpers
{
    public static class CriadorIds
    {
        public static int ColaboradorId { get; set; }
        public static int ClienteId { get; set; }
        public static int ComandaId { get; set; }
        public static int TratamentoId { get; set; }

        static CriadorIds()
        {
            ColaboradorId = 1;
            ClienteId = 1;
            ComandaId = 1;
            TratamentoId = 1;
        }

        public static void InicializarClienteId(int id)
        {
            ClienteId = id;
        }
        public static void InicializarColaboradorId(int id)
        {
            ColaboradorId = id;
        }
        public static void InicializarComandaId(int id)
        {
            ComandaId = id;
        }

        public static void InicializarTratamentoId(int id)
        {
            TratamentoId = id;
        }

        public static int CriarNovoId(TipoBancoDeDados tipo)
        {
            switch (tipo)
            {
                case TipoBancoDeDados.Cliente:
                    int idcliente = ClienteId;
                    ClienteId++;
                    return idcliente;
                case TipoBancoDeDados.Colaborador:
                    int idcolaborador = ColaboradorId;
                    ColaboradorId++;
                    return idcolaborador;
                case TipoBancoDeDados.Comanda:
                    int idcomanda = ComandaId;
                    ComandaId++;
                    return idcomanda;
                case TipoBancoDeDados.Tratamento:
                    int idtratamento = TratamentoId;
                    TratamentoId++;
                    return idtratamento;
            }
            return 0;
            //    int idtratamento = TratamentoId;
            //    TratamentoId++;
            //    return idtratamento;
            //    int idtratamento = TratamentoId;
            //    TratamentoId++;
            //    return idtratamento;
            //if (tipoId == 1)
            //{
            //    int idcliente = ClienteId;
            //    ClienteId++;
            //    return idcliente;
            //}
            //else
            //if (tipoId == 2)
            //{
            //    int idcolaborador = ColaboradorId;
            //    ColaboradorId++;
            //    return idcolaborador;
            //}
            //else
            //if
            //(tipoId == 3)
            //{
            //    int idcomanda = ComandaId;
            //    ComandaId++;
            //    return idcomanda;
            //}
            //else if(tipoId == 4)
            //{
            //    int idtratamento = TratamentoId;
            //    TratamentoId++;
            //    return idtratamento;
            //}
            //{
            //    throw new Exception("Operação Inválida");
            //}
        }
    }
}
////         3 Metodos sem parametros.

////        public static int CriarNovoIdColaborador()
////        {
////            int idcolaborador = ColaboradorId;
////            ColaboradorId++;
////            return idcolaborador;
////        }
////        public static int CriarNovoIdCliente()
////        {
////            int idcliente = ClienteId;
////            ClienteId++;
////            return idcliente;
////        }
////        public static int CriarNovoIdComanda()
////        {
////            int idcomanda = ComandaId;
////            ComandaId++;
////            return idcomanda;
////        }
////}
// Um metodo para as 3 propriedades.
// Necessário informar ao método a propriedade que eu quero.