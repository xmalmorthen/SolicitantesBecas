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

}
