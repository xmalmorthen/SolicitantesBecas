using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolicitantesBecas.Models
{
    public class strCaUsuarios
    {
        private int _id;
        private string _cveUsuario;
        private string _usuario;
        private System.DateTime _fIns;
        private System.Nullable<System.DateTime> _fAct;

        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {                    
                    this._id = value;                    
                }
            }
        }

        public string cveUsuario
        {
            get
            {
                return this._cveUsuario;
            }
            set
            {
                if ((this._cveUsuario != value))
                {
                    this._cveUsuario = value;
                }
            }
        }


        public string usuario
        {
            get
            {
                return this._usuario;
            }
            set
            {
                if ((this._usuario != value))
                {
                    this._usuario = value;
                }
            }
        }
    }

    public class strCaEscuelas
    {
        private int _id;
        private string _municipio;
        private string _institucion;
        private string _nivel;
        private string _plantel;
        private System.DateTime _fIns;
        private System.Nullable<System.DateTime> _fAct;

        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this._id = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_municipio", DbType = "VarChar(50)")]
        public string municipio
        {
            get
            {
                return this._municipio;
            }
            set
            {
                if ((this._municipio != value))
                {
                    this._municipio = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_institucion", DbType = "VarChar(60)")]
        public string institucion
        {
            get
            {
                return this._institucion;
            }
            set
            {
                if ((this._institucion != value))
                {
                    this._institucion = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_nivel", DbType = "VarChar(50)")]
        public string nivel
        {
            get
            {
                return this._nivel;
            }
            set
            {
                if ((this._nivel != value))
                {
                    this._nivel = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_plantel", DbType = "VarChar(100)")]
        public string plantel
        {
            get
            {
                return this._plantel;
            }
            set
            {
                if ((this._plantel != value))
                {
                    this._plantel = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_fIns", DbType = "DateTime NOT NULL", IsDbGenerated = true)]
        public System.DateTime fIns
        {
            get
            {
                return this._fIns;
            }
            set
            {
                if ((this._fIns != value))
                {
                    this._fIns = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_fAct", DbType = "DateTime")]
        public System.Nullable<System.DateTime> fAct
        {
            get
            {
                return this._fAct;
            }
            set
            {
                if ((this._fAct != value))
                {
                    this._fAct = value;
                }
            }
        }
    }

    public class strMaSolicitantes
    {
        private string _curp;
        private string _primerApellido;
        private string _segundoApellido;
        private string _nombres;
        private int _edad;
        private int _idSexo;
        private string _correo;
        private string _telCel;
        private string _telPart;
        private string _domIdMpio;
        private string _domIdLocalidad;
        private string _domIdColonia;
        private string _domIdCalle;
        private System.Nullable<int> _domNumExt;
        private System.Nullable<int> _domNumInt;
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

        public int edad
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

        public int idSexo
        {
            get
            {
                return this._idSexo;
            }
            set
            {
                if ((this._idSexo != value))
                {
                    this._idSexo = value;
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

        public System.Nullable<int> domNumExt
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

        public System.Nullable<int> domNumInt
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

    public class strCURPResponse {
        private string _statusOper;
        public string statusOper { get { return _statusOper; } set { _statusOper = value; } }

        private string _message;
        public string message { get { return _message; } set { _message = value; } }

        private string _TipoError;
        public string TipoError { get { return _TipoError; } set { _TipoError = value; } }

        private string _CodigoError;
        public string CodigoError { get { return _CodigoError; } set { _CodigoError = value; } }

        private string _SessionID;
        public string SessionID { get { return _SessionID; } set { _SessionID = value; } }

        private string _Fuente;
        public string Fuente { get { return _Fuente; } set { _Fuente = value; } }

    }

    public class strCURP {
        private strCURPResponse _Response = new strCURPResponse();
        public strCURPResponse Response { get { return _Response; } set { _Response = value; } }

        private string _CURP;
        public string CURP { get { return _CURP; } set { _CURP = value; } }

        private string _Nombre;
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }

        private string _Apellido1;
        public string Apellido1 { get { return _Apellido1; } set { _Apellido1 = value; } }

        private string _Apellido2;
        public string Apellido2 { get { return _Apellido2; } set { _Apellido2 = value; } }

        private string _Entidad;
        public string Entidad { get { return _Entidad; } set { _Entidad = value; } }

        private string _Fecha_Nac;
        public string Fecha_Nac { get { return _Fecha_Nac; } set { _Fecha_Nac = value; } }

        private string _Sexo;
        public string Sexo { get { return _Sexo; } set { _Sexo = value; } }

        private string _Nacionalidad;
        public string Nacionalidad { get { return _Nacionalidad; } set { _Nacionalidad = value; } }

        private string _CveDP;
        public string CveDP { get { return _CveDP; } set { _CveDP = value; } }

        private string _DOCUMPROBANIOREGISTRO;
        public string DOCUMPROBANIOREGISTRO { get { return _DOCUMPROBANIOREGISTRO; } set { _DOCUMPROBANIOREGISTRO = value; } }

        private string _DOCUMPROBACTAFOJA;
        public string DOCUMPROBACTAFOJA { get { return _DOCUMPROBACTAFOJA; } set { _DOCUMPROBACTAFOJA = value; } }

        private string _DOCUMPROBACTATOMO;
        public string DOCUMPROBACTATOMO { get { return _DOCUMPROBACTATOMO; } set { _DOCUMPROBACTATOMO = value; } }

        private string _DOCUMPROBACTALIBRO;
        public string DOCUMPROBACTALIBRO { get { return _DOCUMPROBACTALIBRO; } set { _DOCUMPROBACTALIBRO = value; } }

        private string _DOCUMPROBNUM;
        public string DOCUMPROBNUM { get { return _DOCUMPROBNUM; } set { _DOCUMPROBNUM = value; } }

        private string _DOCUMPROBACTACRIP;
        public string DOCUMPROBACTACRIP { get { return _DOCUMPROBACTACRIP; } set { _DOCUMPROBACTACRIP = value; } }

        private string _DOCUMPROBACTAENTIDREGIS;
        public string DOCUMPROBACTAENTIDREGIS { get { return _DOCUMPROBACTAENTIDREGIS; } set { _DOCUMPROBACTAENTIDREGIS = value; } }

        private string _DOCUMPROBACTAMUNICREGIS;
        public string DOCUMPROBACTAMUNICREGIS { get { return _DOCUMPROBACTAMUNICREGIS; } set { _DOCUMPROBACTAMUNICREGIS = value; } }

        private string _Folio;
        public string Folio { get { return _Folio; } set { _Folio = value; } }

        private string _FechaAlta;
        public string FechaAlta { get { return _FechaAlta; } set { _FechaAlta = value; } }

        private string _Estatus;
        public string Estatus { get { return _Estatus; } set { _Estatus = value; } }



    }

}
