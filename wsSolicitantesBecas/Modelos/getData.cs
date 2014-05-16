using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsSolicitantesBecas.Modelos
{
    public static class getData
    {
        private static string errMesagge = "Error al obtener información de la base de datos";

        public static StcCaEscuelas getCaEscuelas()
        {
            BdCapturaBECASDataContext bd = new BdCapturaBECASDataContext();

            StcCaEscuelas response = new StcCaEscuelas();
            
            response.statusResponse.statusOper = false;
            response.statusResponse.message = messages.fallo;
            response.data = null; 

            try 
	        {
                List<caEscuelas> query = bd.GetTable<caEscuelas>().ToList();

                response.statusResponse.statusOper = query.Count > 0 ? true : false;
                response.statusResponse.message = query.Count > 0 ? messages.exito : messages.fallo;
                response.data = query.Count > 0 ? query : null; 

                return response;
	        }
	        catch (Exception e)
	        {
                return response;
	        }            
        }

        public static StcCaUsuarios getCaUsuarios()
        {
            BdCapturaBECASDataContext bd = new BdCapturaBECASDataContext();

            StcCaUsuarios response = new StcCaUsuarios();

            response.statusResponse.statusOper = false;
            response.statusResponse.message = messages.fallo;
            response.data = null;

            try
            {
                List<caUsuarios> query = bd.GetTable<caUsuarios>().ToList();

                response.statusResponse.statusOper = query.Count > 0 ? true : false;
                response.statusResponse.message = query.Count > 0 ? messages.exito : messages.fallo;
                response.data = query.Count > 0 ? query : null;

                return response;
            }
            catch (Exception e)
            {
                return response;
            }
        }

        public static StcisInserted isInserted(int idUsuario, string CURP)
        {
            BdCapturaBECASDataContext bd = new BdCapturaBECASDataContext();

            StcisInserted response = new StcisInserted();
            response.statusResponse.statusOper = false;
            response.statusResponse.message = messages.fallo;
            
            try
            {
                maSolicitantes query = bd.maSolicitantes.SingleOrDefault(e => e.curp == CURP && e.idUsuario == idUsuario);

                response.statusResponse.statusOper = true;
                response.statusResponse.message = messages.exito;
                
                response.data.CURP = CURP;
                response.data.idUsuario = idUsuario;
                response.data.inserted = query == null ? false : true;
                response.data.message = query == null ? "CURP no encontrada" : "CURP encontrada";

                return response;
            }
            catch (Exception e)
            {
                response.data = null;
                return response;
            }

        }

        public static StcListaRegistrosReducida getListaReducida(int idUsuario)
        {
            BdCapturaBECASDataContext bd = new BdCapturaBECASDataContext();

            StcListaRegistrosReducida response = new StcListaRegistrosReducida();

            response.statusResponse.statusOper = false;
            response.statusResponse.message = messages.fallo;
            response.data = null;

            try
            {
                List<paListaRegistrosReducidaResult> query = bd.paListaRegistrosReducida(idUsuario).ToList();

                response.statusResponse.statusOper = query.Count > 0 ? true : false;
                response.statusResponse.message = query.Count > 0 ? messages.exito : messages.fallo;
                response.data = query.Count > 0 ? query : null;

                return response;
            }
            catch (Exception e)
            {
                return response;
            }
        }

        public static StcListaRegistrosExtendida getListaExtendida(int idUsuario)
        {
            BdCapturaBECASDataContext bd = new BdCapturaBECASDataContext();

            StcListaRegistrosExtendida response = new StcListaRegistrosExtendida();

            response.statusResponse.statusOper = false;
            response.statusResponse.message = messages.fallo;
            response.data = null;

            try
            {
                List<paListaRegistrosExtendidaResult> query = bd.paListaRegistrosExtendida(idUsuario).ToList();

                response.statusResponse.statusOper = query.Count > 0 ? true : false;
                response.statusResponse.message = query.Count > 0 ? messages.exito : messages.fallo;
                response.data = query.Count > 0 ? query : null;

                return response;
            }
            catch (Exception e)
            {
                return response;
            }
        }


    }
}