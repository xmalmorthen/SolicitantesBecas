﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultaSolicitudes.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smtp.gmail.com")]
        public string smtpAddress {
            get {
                return ((string)(this["smtpAddress"]));
            }
            set {
                this["smtpAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("587")]
        public int portNumber {
            get {
                return ((int)(this["portNumber"]));
            }
            set {
                this["portNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool enableSSL {
            get {
                return ((bool)(this["enableSSL"]));
            }
            set {
                this["enableSSL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("erroresdevelopc@gmail.com")]
        public string emailFrom {
            get {
                return ((string)(this["emailFrom"]));
            }
            set {
                this["emailFrom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..121212qw")]
        public string password {
            get {
                return ((string)(this["password"]));
            }
            set {
                this["password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("erroresdevelopc@gmail.com")]
        public string emailTo {
            get {
                return ((string)(this["emailTo"]));
            }
            set {
                this["emailTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int numErrAntesdeEnviarCorreo {
            get {
                return ((int)(this["numErrAntesdeEnviarCorreo"]));
            }
            set {
                this["numErrAntesdeEnviarCorreo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://wsrenapo.col.gob.mx/curp2/CURP")]
        public string wsCURP {
            get {
                return ((string)(this["wsCURP"]));
            }
            set {
                this["wsCURP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xmalmorthen")]
        public string usuarioCURP {
            get {
                return ((string)(this["usuarioCURP"]));
            }
            set {
                this["usuarioCURP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("b16f550d147bf92e9455074d9edfe013")]
        public string contraseniaCURP {
            get {
                return ((string)(this["contraseniaCURP"]));
            }
            set {
                this["contraseniaCURP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ocurrió un problema relacionado a")]
        public string errGeneral {
            get {
                return ((string)(this["errGeneral"]));
            }
            set {
                this["errGeneral"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Base de datos")]
        public string errBD {
            get {
                return ((string)(this["errBD"]));
            }
            set {
                this["errBD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("favor de ponerse en contacto con el administrador del sistema...")]
        public string errAdmin {
            get {
                return ((string)(this["errAdmin"]));
            }
            set {
                this["errAdmin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Servicio de CURP")]
        public string errWSCURP {
            get {
                return ((string)(this["errWSCURP"]));
            }
            set {
                this["errWSCURP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://proveedores.col.gob.mx/REST_Services/FrameWork/index.php/localizacion/serv" +
            "erlocalizacion")]
        public string wsFwrkDom {
            get {
                return ((string)(this["wsFwrkDom"]));
            }
            set {
                this["wsFwrkDom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Servicio de Framework de Domicilios")]
        public string errWSFwrkDomicilios {
            get {
                return ((string)(this["errWSFwrkDomicilios"]));
            }
            set {
                this["errWSFwrkDomicilios"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Registro de solicitudes")]
        public string tituloVentana {
            get {
                return ((string)(this["tituloVentana"]));
            }
            set {
                this["tituloVentana"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Servicio de Solicitantes de Becas")]
        public string errWSSolicitantesBecas {
            get {
                return ((string)(this["errWSSolicitantesBecas"]));
            }
            set {
                this["errWSSolicitantesBecas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool sendEmailErrors {
            get {
                return ((bool)(this["sendEmailErrors"]));
            }
            set {
                this["sendEmailErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Lista de registros capturados")]
        public string tituloVentanaLista {
            get {
                return ((string)(this["tituloVentanaLista"]));
            }
            set {
                this["tituloVentanaLista"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\\Modelos\\dataBase\\dbSolicitudes.sdf")]
        public string dbSolicitudesConnectionString {
            get {
                return ((string)(this["dbSolicitudesConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:4866/CapturaBECAS.asmx")]
        public string wsSolicitantesBecas {
            get {
                return ((string)(this["wsSolicitantesBecas"]));
            }
            set {
                this["wsSolicitantesBecas"] = value;
            }
        }
    }
}
