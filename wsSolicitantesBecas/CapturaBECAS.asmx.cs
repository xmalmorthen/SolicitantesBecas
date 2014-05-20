using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using wsSolicitantesBecas.Modelos;

namespace wsSolicitantesBecas
{
    /// <summary>
    /// Servicio para el formulario de registro de solicitantes
    /// </summary>
    [WebService(Namespace = "http://wsSolicitantesBecas.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SolicitantesBecas : System.Web.Services.WebService
    {        
        [WebMethod]
        public StcCaEscuelas caEscuelas()
        {
            return getData.getCaEscuelas();
        }

        [WebMethod]
        public StcCaUsuarios caUsuarios()
        {
            return getData.getCaUsuarios();
        }

        [WebMethod]
        public StcisInserted verificaCURPInsertado(int idUsuario, string CURP, int idEscuela)
        {
            return getData.isInserted(idUsuario, CURP, idEscuela);
        }

        [WebMethod]
        public StcInsertaSolicitud instertaSolicitud(int idUsuario, string xmlData)
        {
            return insertData.Solicitud(idUsuario, xmlData);
        }

        [WebMethod]
        public StcListaRegistrosReducida listaReducida(int idUsuario)
        {
            return getData.getListaReducida(idUsuario);
        }

        [WebMethod]
        public StcListaRegistrosExtendida listaExtendida(int idUsuario)
        {
            return getData.getListaExtendida(idUsuario);
        }


        

    }
}