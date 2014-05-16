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

    public class strMaSolicitantes
    {
        private string _curp;
        private string _primerApellido;
        private string _segundoApellido;
        private string _nombres;
        private string _edad;
        private string _sexo;
        private string _correo;
        private string _telCel;
        private string _telPart;
        private string _domIdMpio;
        private string _domMpio;
        private string _domIdLocalidad;
        private string _domLocalidad;
        private string _domIdColonia;
        private string _domColonia;
        private string _domIdCalle;
        private string _domCalle;
        private string _domNumExt;
        private string _domNumInt;
        private string _domLetra;
        private int _idEscuela;
        private string _papaPrimerApellido;
        private string _papaSegundoApellido;
        private string _papaNombres;
        private string _mamaPrimerApellido;
        private string _mamaSegundoApellido;
        private string _mamaNombres;
        private string _domDesc;
        private int _idUsuario;

        public string curp
        {
            get
            {
                return this._curp;
            }
            set
            {
                if ((this._curp != value))
                {
                    this._curp = value;
                }
            }
        }

        public string primerApellido
        {
            get
            {
                return this._primerApellido;
            }
            set
            {
                if ((this._primerApellido != value))
                {
                    this._primerApellido = value;
                }
            }
        }

        public string segundoApellido
        {
            get
            {
                return this._segundoApellido;
            }
            set
            {
                if ((this._segundoApellido != value))
                {
                    this._segundoApellido = value;
                }
            }
        }

        public string nombres
        {
            get
            {
                return this._nombres;
            }
            set
            {
                if ((this._nombres != value))
                {
                    this._nombres = value;
                }
            }
        }

        public string edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                if ((this._edad != value))
                {
                    this._edad = value;
                }
            }
        }

        public string sexo
        {
            get
            {
                return this._sexo;
            }
            set
            {
                if ((this._sexo != value))
                {
                    this._sexo = value;
                }
            }
        }

        public string correo
        {
            get
            {
                return this._correo;
            }
            set
            {
                if ((this._correo != value))
                {
                    this._correo = value;
                }
            }
        }

        public string telCel
        {
            get
            {
                return this._telCel;
            }
            set
            {
                if ((this._telCel != value))
                {
                    this._telCel = value;
                }
            }
        }

        public string telPart
        {
            get
            {
                return this._telPart;
            }
            set
            {
                if ((this._telPart != value))
                {
                    this._telPart = value;
                }
            }
        }

        public string domIdMpio
        {
            get
            {
                return this._domIdMpio;
            }
            set
            {
                if ((this._domIdMpio != value))
                {
                    this._domIdMpio = value;
                }
            }
        }

        public string domMpio
        {
            get
            {
                return this._domMpio;
            }
            set
            {
                if ((this._domMpio != value))
                {
                    this._domMpio = value;
                }
            }
        }

        public string domIdLocalidad
        {
            get
            {
                return this._domIdLocalidad;
            }
            set
            {
                if ((this._domIdLocalidad != value))
                {
                    this._domIdLocalidad = value;
                }
            }
        }

        public string domLocalidad
        {
            get
            {
                return this._domLocalidad;
            }
            set
            {
                if ((this._domLocalidad != value))
                {
                    this._domLocalidad = value;
                }
            }
        }

        public string domIdColonia
        {
            get
            {
                return this._domIdColonia;
            }
            set
            {
                if ((this._domIdColonia != value))
                {
                    this._domIdColonia = value;
                }
            }
        }

        public string domColonia
        {
            get
            {
                return this._domColonia;
            }
            set
            {
                if ((this._domColonia != value))
                {
                    this._domColonia = value;
                }
            }
        }

        public string domIdCalle
        {
            get
            {
                return this._domIdCalle;
            }
            set
            {
                if ((this._domIdCalle != value))
                {
                    this._domIdCalle = value;
                }
            }
        }

        public string domCalle
        {
            get
            {
                return this._domCalle;
            }
            set
            {
                if ((this._domCalle != value))
                {
                    this._domCalle = value;
                }
            }
        }

        public string domNumExt
        {
            get
            {
                return this._domNumExt;
            }
            set
            {
                if ((this._domNumExt != value))
                {
                    this._domNumExt = value;
                }
            }
        }

        public string domNumInt
        {
            get
            {
                return this._domNumInt;
            }
            set
            {
                if ((this._domNumInt != value))
                {
                    this._domNumInt = value;
                }
            }
        }

        public string domLetra
        {
            get
            {
                return this._domLetra;
            }
            set
            {
                if ((this._domLetra != value))
                {
                    this._domLetra = value;
                }
            }
        }

        public int idEscuela
        {
            get
            {
                return this._idEscuela;
            }
            set
            {
                if ((this._idEscuela != value))
                {
                    this._idEscuela = value;
                }
            }
        }

        public string papaPrimerApellido
        {
            get
            {
                return this._papaPrimerApellido;
            }
            set
            {
                if ((this._papaPrimerApellido != value))
                {
                    this._papaPrimerApellido = value;
                }
            }
        }

        public string papaSegundoApellido
        {
            get
            {
                return this._papaSegundoApellido;
            }
            set
            {
                if ((this._papaSegundoApellido != value))
                {
                    this._papaSegundoApellido = value;
                }
            }
        }

        public string papaNombres
        {
            get
            {
                return this._papaNombres;
            }
            set
            {
                if ((this._papaNombres != value))
                {
                    this._papaNombres = value;
                }
            }
        }

        public string mamaPrimerApellido
        {
            get
            {
                return this._mamaPrimerApellido;
            }
            set
            {
                if ((this._mamaPrimerApellido != value))
                {
                    this._mamaPrimerApellido = value;
                }
            }
        }

        public string mamaSegundoApellido
        {
            get
            {
                return this._mamaSegundoApellido;
            }
            set
            {
                if ((this._mamaSegundoApellido != value))
                {
                    this._mamaSegundoApellido = value;
                }
            }
        }

        public string mamaNombres
        {
            get
            {
                return this._mamaNombres;
            }
            set
            {
                if ((this._mamaNombres != value))
                {
                    this._mamaNombres = value;
                }
            }
        }

        public string domDesc
        {
            get
            {
                return this._domDesc;
            }
            set
            {
                if ((this._domDesc != value))
                {
                    this._domDesc = value;
                }
            }
        }

        public int idUsuario
        {
            get
            {
                return this._idUsuario;
            }
            set
            {
                if ((this._idUsuario != value))
                {
                    this._idUsuario = value;
                }
            }
        }
    }

    public class Inserted {
        private Boolean _inserted;
        public Boolean inserted { get { return _inserted; } set { _inserted = value; } }

        private string _message;
        public string message { get { return _message; } set { _message = value; } }

        private string _CURP;
        public string CURP { get { return _CURP; } set { _CURP = value; } }

        private int _idUsuario;
        public int idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
    }

    public class StcisInserted
    {
        private structBase _statusResponse = new structBase();
        public structBase statusResponse { get { return _statusResponse; } set { _statusResponse = value; } }

        private Inserted _data = new Inserted();
        public Inserted data { get { return _data; } set { _data = value; } }
    }

    public class StcInsertaSolicitud
    {
        private structBase _statusResponse = new structBase();
        public structBase statusResponse { get { return _statusResponse; } set { _statusResponse = value; } }
    }

    public class StcListaRegistrosReducida {
        private structBase _statusResponse = new structBase();
        public structBase statusResponse { get { return _statusResponse; } set { _statusResponse = value; } }

        private List<paListaRegistrosReducidaResult> _data = new List<paListaRegistrosReducidaResult>();
        public List<paListaRegistrosReducidaResult> data { get { return _data; } set { _data = value; } }    
    }

    public class StcListaRegistrosExtendida
    {
        private structBase _statusResponse = new structBase();
        public structBase statusResponse { get { return _statusResponse; } set { _statusResponse = value; } }

        private List<paListaRegistrosExtendidaResult> _data = new List<paListaRegistrosExtendidaResult>();
        public List<paListaRegistrosExtendidaResult> data { get { return _data; } set { _data = value; } }
    }



}