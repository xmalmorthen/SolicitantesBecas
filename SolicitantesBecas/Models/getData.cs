using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RestSharp;
using Newtonsoft.Json;

namespace SolicitantesBecas.Models
{
    static class getData
    {
        private static wsSolicitanteBecas.SolicitantesBecasSoapClient servicio = new wsSolicitanteBecas.SolicitantesBecasSoapClient();

        public static List<strCaUsuarios> caUsuarios()
        {
            try
            {
                var request = servicio.caUsuarios();

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = request.statusResponse.message;
                    return null;
                }

                List<strCaUsuarios> Lista = new List<strCaUsuarios>();
                foreach (var item in request.data)
                {
                    Lista.Add(new strCaUsuarios()
                    {
                        id = item.id,
                        cveUsuario = item.cveUsuario,
                        usuario = item.usuario
                    });
                }
                return Lista;
            }
            catch (Exception e)
            {
                err.setError = e.Message;
                return null;
            }            
        }

        public static List<strCaEscuelas> caEscuelas()
        {
            try
            {
                var request = servicio.caEscuelas();

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = request.statusResponse.message;
                    return null;
                }

                List<strCaEscuelas> Lista = new List<strCaEscuelas>();
                foreach (var item in request.data)
                {
                    Lista.Add(new strCaEscuelas()
                    {
                        id = item.id,
                        institucion = item.institucion,
                        municipio = item.municipio,
                        nivel = item.nivel,
                        plantel = item.plantel
                    });
                }
                return Lista;
            }
            catch (Exception e)
            {
                err.setError = e.Message;
                return null;
            }            
        }

        public static void getInfoCURP(string CURP) {
            var client = new RestClient(SolicitantesBecas.Properties.Settings.Default.CURPBaseURL);
            client.Authenticator = new HttpBasicAuthenticator(SolicitantesBecas.Properties.Settings.Default.usuarioCURP, SolicitantesBecas.Properties.Settings.Default.contraseniaCURP);
            var request = new RestRequest("getInfo/" + CURP, Method.GET);
            request.AddHeader("Accept", "application/json");

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            strCURP data = JsonConvert.DeserializeObject<strCURP>(content);
        }

    }
}