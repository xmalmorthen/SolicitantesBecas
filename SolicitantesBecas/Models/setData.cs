using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RestSharp;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace SolicitantesBecas.Models
{
    static class setData
    {
        private static wsSolicitanteBecas.SolicitantesBecas servicio = new wsSolicitanteBecas.SolicitantesBecas();

        public static Boolean? inserSolicitud(strMaSolicitantes data, ref string error)
        {
            try
            {
                servicio.Url = SolicitantesBecas.Properties.Settings.Default.wsSolicitantesBecas;

                XElement solicitudes = new XElement("solicitudes",
                                            new XElement("solicitud",
                                                new XElement("curp",data.curp),
                                                new XElement("primerApellido",data.primerApellido),
                                                new XElement("segundoApellido",data.segundoApellido),
                                                new XElement("nombres",data.nombres),
                                                new XElement("edad",data.edad),
                                                new XElement("sexo",data.sexo),
                                                new XElement("correo", data.correo),
                                                new XElement("telCel",data.telCel),
                                                new XElement("telPart",data.telPart),
                                                new XElement("domIdMpio",data.domIdMpio),
                                                new XElement("domIdLocalidad",data.domIdLocalidad),
                                                new XElement("domIdColonia",data.domIdColonia),
                                                new XElement("domIdCalle",data.domIdCalle),
                                                new XElement("domMpio", data.domMpio),
                                                new XElement("domLocalidad", data.domLocalidad),
                                                new XElement("domColonia", data.domColonia),
                                                new XElement("domCalle", data.domCalle),
                                                new XElement("domNumExt",data.domNumExt),
                                                new XElement("domNumInt",data.domNumInt),
                                                new XElement("domLetra",data.domLetra),
                                                new XElement("idEscuela",data.idEscuela),
                                                new XElement("papaPrimerApellido",data.papaPrimerApellido),
                                                new XElement("papaSegundoApellido",data.papaSegundoApellido),
                                                new XElement("papaNombres",data.papaNombres),
                                                new XElement("mamaPrimerApellido",data.mamaPrimerApellido),
                                                new XElement("mamaSegundoApellido",data.mamaSegundoApellido),
                                                new XElement("mamaNombres",data.mamaNombres),
                                                new XElement("domDesc",data.domDesc)
                                            )
                                       );

                var request = servicio.instertaSolicitud(data.idUsuario, solicitudes.ToString());

                if (request.statusResponse.statusOper == false)
                {
                    error = request.statusResponse.message;
                    return false;
                }

                return request.statusResponse.statusOper;                
            }
            catch (Exception e)
            {
                err.setError = "SolicitantesBecas.Models.setData.inserSolicitud() - " + e.Message;
                return null;
            }            
        }
    }
}