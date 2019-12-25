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

        static CriadorIds()
        {
            ColaboradorId = 1;
            ClienteId = 1;
            ComandaId = 1;
        }
        public static int CriarNovoId(int tipoId)
        {
            if (tipoId == 1)
            {
                int idcliente = ClienteId;
                ClienteId++;
                return idcliente;
            }
            else
            if (tipoId == 2)
            {
                int idcolaborador = ColaboradorId;
                ColaboradorId++;
                return idcolaborador;
            }
            else
            if
            (tipoId == 3)
            {
                int idcomanda = ComandaId;
                ComandaId++;
                return idcomanda;
            }
            else
            {
                throw new Exception("Operação Inválida");
            }
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