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
	
}
