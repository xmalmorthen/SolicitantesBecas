using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsSolicitantesBecas.Modelos
{
    public static class messages {
        public static string exito = "Operación realizada con ÉXITO";
        public static string fallo = "Operación fallida";
    }

    public class structBase
    {
        private Boolean _statusOper;
        public Boolean statusOper { get { return _statusOper; } set { _statusOper = value; } }

        private string _message;
        public string message { get { return _message; } set { _message = value; } }

    }

    public class StcCaEscuelas {
        private structBase _statusResponse = new structBase();
        public structBase statusResponse { get { return _statusResponse; } set { _statusResponse = value; } }

        private List<caEscuelas> _data = new List<caEscuelas>();
        public List<caEscuelas> data { get { return _data; } set { _data = value; } }
    }

    public class StcCaUsuarios
    {
        private structBase _statusResponse = new structBase();
        public structBase statusResponse { get { return _statusResponse; } set { _statusResponse = value; } }

        private List<caUsuarios> _data = new List<caUsuarios>();
        public List<caUsuarios> data { get { return _data; } set { _data = value; } }
    }

}