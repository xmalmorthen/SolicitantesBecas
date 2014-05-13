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
        private static wsSolicitanteBecas.SolicitantesBecas servicio = new wsSolicitanteBecas.SolicitantesBecas();

        public static List<strCaUsuarios> caUsuarios()
        {
            try
            {
                servicio.Url = SolicitantesBecas.Properties.Settings.Default.wsSolicitantesBecas;

                var request = servicio.caUsuarios();

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = "SolicitantesBecas.Models.getData.caUsuarios() - " + request.statusResponse.message;
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
                err.setError = "SolicitantesBecas.Models.getData.caUsuarios() - " + e.Message;
                return null;
            }            
        }

        public static List<strCaEscuelas> caEscuelas()
        {
            try
            {
                servicio.Url = SolicitantesBecas.Properties.Settings.Default.wsSolicitantesBecas;

                var request = servicio.caEscuelas();

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = "SolicitantesBecas.Models.getData.caEscuelas() - " + request.statusResponse.message;
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
                err.setError = "SolicitantesBecas.Models.getData.caEscuelas() - " + e.Message;
                return null;
            }            
        }

        public static strCURP getInfoCURP(string CURP)
        {
            try
            {
                var client = new RestClient(SolicitantesBecas.Properties.Settings.Default.wsCURP);
                client.Authenticator = new HttpBasicAuthenticator(SolicitantesBecas.Properties.Settings.Default.usuarioCURP, SolicitantesBecas.Properties.Settings.Default.contraseniaCURP);
                var request = new RestRequest("getInfo/" + CURP, Method.GET);
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK) { 
                    throw new Exception ("No se encontró el servicio de CURP activo...");
                }

                var content = response.Content; // raw content as string

                strCURP data = new strCURP();

                if (content.Trim().ToLower().IndexOf("curp no encontrada") != -1)
                {
                    data.Response.statusOper = "NO EXITOSO";
                    data.Response.message = "CURP no encontrada";
                }
                else {
                    data = JsonConvert.DeserializeObject<strCURP>(content);
                }

                return data;
            }
            catch (Exception e)
            {
                err.setError = "SolicitantesBecas.Models.getData.getInfoCURP() - " + e.Message;
                return null;                
            }
        }

        public static List<strMpios> getMpios(ref Boolean error, int idEstado = 6)
        {
            error = true;
            try
            {
                var client = new RestClient(SolicitantesBecas.Properties.Settings.Default.wsFwrkDom);
                var request = new RestRequest("ListaMunicipios/" + idEstado.ToString().Trim(), Method.GET);
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("No se encontró el servicio de Framework de Domicilios activo...");
                }

                var content = response.Content; // raw content as string

                if (content.Trim().ToLower().IndexOf("parámetros incorrectos...!!!") != -1)
                {
                    error = false;
                    return null;
                }

                List<strMpios> data = JsonConvert.DeserializeObject<List<strMpios>>(content);
                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "SolicitantesBecas.Models.getData.getMpios() - " + e.Message;
                return null;
            }
        }

        public static List<strLoc> getLoc(string idMpio, ref Boolean error)
        {
            error = true;
            try
            {
                var client = new RestClient(SolicitantesBecas.Properties.Settings.Default.wsFwrkDom);
                var request = new RestRequest("ListaLocalidades/" + idMpio, Method.GET);
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("No se encontró el servicio de Framework de Domicilios activo...");
                }

                var content = response.Content; // raw content as string

                if (content.Trim().ToLower().IndexOf("parámetros incorrectos...!!!") != -1)
                {
                    error = false;
                    return null;
                }

                List<strLoc> data = JsonConvert.DeserializeObject<List<strLoc>>(content);
                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "SolicitantesBecas.Models.getData.getMpios() - " + e.Message;
                return null;
            }
        }

        public static List<strCol> getCol(string idLoc, ref Boolean error)
        {
            error = true;
            try
            {
                var client = new RestClient(SolicitantesBecas.Properties.Settings.Default.wsFwrkDom);
                var request = new RestRequest("ListaColonias/" + idLoc, Method.GET);
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("No se encontró el servicio de Framework de Domicilios activo...");
                }

                var content = response.Content; // raw content as string

                if (content.Trim().ToLower().IndexOf("parámetros incorrectos...!!!") != -1)
                {
                    error = false;
                    return null;
                }

                List<strCol> data = JsonConvert.DeserializeObject<List<strCol>>(content);
                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "SolicitantesBecas.Models.getData.getCol() - " + e.Message;
                return null;
            }
        }


        public static List<strCall> getCall(string idCol, ref Boolean error)
        {
            error = true;
            try
            {
                var client = new RestClient(SolicitantesBecas.Properties.Settings.Default.wsFwrkDom);
                var request = new RestRequest("ListaCalles/" + idCol, Method.GET);
                request.AddHeader("Accept", "application/json");

                // execute the request
                IRestResponse response = client.Execute(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("No se encontró el servicio de Framework de Domicilios activo...");
                }

                var content = response.Content; // raw content as string

                if (content.Trim().ToLower().IndexOf("parámetros incorrectos...!!!") != -1)
                {
                    error = false;
                    return null;
                }

                List<strCall> data = JsonConvert.DeserializeObject<List<strCall>>(content);
                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "SolicitantesBecas.Models.getData.getCol() - " + e.Message;
                return null;
            }
        }

    }
}