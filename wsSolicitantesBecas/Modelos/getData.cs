using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsSolicitantesBecas.Modelos
{
    public static class getData
    {
        private static string errMesagge = "Error al obtener información de la base de datos";
        private static BdCapturaBECASDataContext bd = new BdCapturaBECASDataContext();

        public static StcCaEscuelas getCaEscuelas()
        {
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

    }
}