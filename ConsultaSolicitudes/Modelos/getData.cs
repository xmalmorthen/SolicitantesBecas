using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RestSharp;
using Newtonsoft.Json;

namespace ConsultaSolicitudes.Models
{
    static class getData
    {
        private static wsSolicitanteBecas.SolicitantesBecas servicio = new wsSolicitanteBecas.SolicitantesBecas();

        public static List<strCaUsuarios> caUsuarios()
        {
            try
            {
                servicio.Url = ConsultaSolicitudes.Properties.Settings.Default.wsSolicitantesBecas;

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
                servicio.Url = ConsultaSolicitudes.Properties.Settings.Default.wsSolicitantesBecas;

                var request = servicio.caEscuelas();

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = "ConsultaSolicitudes.Models.getData.caEscuelas() - " + request.statusResponse.message;
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
                err.setError = "ConsultaSolicitudes.Models.getData.caEscuelas() - " + e.Message;
                return null;
            }            
        }
        
        public static Boolean? isCURPInserted(int idUsuario, string CURP, int idEscuela)
        {
            try
            {
                servicio.Url = ConsultaSolicitudes.Properties.Settings.Default.wsSolicitantesBecas;

                var request = servicio.verificaCURPInsertado(idUsuario, CURP, idEscuela);

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = "ConsultaSolicitudes.Models.getData.isCURPInserted() - " + request.statusResponse.message;
                    return null;
                }

                return request.data.inserted;
            }
            catch (Exception e)
            {
                err.setError = "ConsultaSolicitudes.Models.getData.isCURPInserted() - " + e.Message;
                return null;
            }
        }

        public static strCURP getInfoCURP(string CURP)
        {
            try
            {
                var client = new RestClient(ConsultaSolicitudes.Properties.Settings.Default.wsCURP);
                client.Authenticator = new HttpBasicAuthenticator(ConsultaSolicitudes.Properties.Settings.Default.usuarioCURP, ConsultaSolicitudes.Properties.Settings.Default.contraseniaCURP);
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
                err.setError = "ConsultaSolicitudes.Models.getData.getInfoCURP() - " + e.Message;
                return null;                
            }
        }

        public static List<strMpios> getMpios(ref Boolean error, int idEstado = 6)
        {
            error = true;
            try
            {
                var client = new RestClient(ConsultaSolicitudes.Properties.Settings.Default.wsFwrkDom);
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
                data.Insert(0, new strMpios() { 
                    cve_Municipios = null,
                    cveEntidades_Municipios = null,
                    descrip_Entidades = null,
                    descrip_Municipios = " "
                });

                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "ConsultaSolicitudes.Models.getData.getMpios() - " + e.Message;
                return null;
            }
        }

        public static List<strLoc> getLoc(string idMpio, ref Boolean error)
        {
            error = true;
            try
            {
                var client = new RestClient(ConsultaSolicitudes.Properties.Settings.Default.wsFwrkDom);
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
                data.Insert(0, new strLoc()
                {
                    cve_Localidades = null,
                    cveMunicipios_Localidades = null,
                    nombre_Localidades = " "
                });
                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "ConsultaSolicitudes.Models.getData.getMpios() - " + e.Message;
                return null;
            }
        }

        public static List<strCol> getCol(string idLoc, ref Boolean error)
        {
            error = true;
            try
            {
                var client = new RestClient(ConsultaSolicitudes.Properties.Settings.Default.wsFwrkDom);
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
                data.Insert(0, new strCol()
                {
                    nombre_Localidades = " "
                });
                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "ConsultaSolicitudes.Models.getData.getCol() - " + e.Message;
                return null;
            }
        }

        public static List<strCall> getCall(string idCol, ref Boolean error)
        {
            error = true;
            try
            {
                var client = new RestClient(ConsultaSolicitudes.Properties.Settings.Default.wsFwrkDom);
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
                data.Insert(0, new strCall()
                {
                    nombre_NombresCalles = " "
                });
                error = false;
                return data;
            }
            catch (Exception e)
            {
                err.setError = "ConsultaSolicitudes.Models.getData.getCol() - " + e.Message;
                return null;
            }
        }

        public static List<strPaListaRegistrosReducida> ListaReducida(int idUsuario)
        {
            try
            {
                servicio.Url = ConsultaSolicitudes.Properties.Settings.Default.wsSolicitantesBecas;

                var request = servicio.listaReducida(idUsuario);

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = "ConsultaSolicitudes.Models.getData.ListaReducida() - " + request.statusResponse.message;
                    return null;
                }

                List<strPaListaRegistrosReducida> Lista = new List<strPaListaRegistrosReducida>();
                foreach (var item in request.data)
                {
                    Lista.Add(new strPaListaRegistrosReducida()
                    {
                        curp = item.curp,
                        fIns = item.fIns,
                        idEscuela = item.idEscuela,
                        institucion = item.institucion,
                        municipio = item.municipio,
                        nivel = item.nivel,
                        nombres = item.nombres,
                        plantel = item.plantel,
                        primerApellido = item.primerApellido,
                        segundoApellido = item.segundoApellido
                    });
                }
                return Lista;
            }
            catch (Exception e)
            {
                err.setError = "ConsultaSolicitudes.Models.getData.ListaReducida() - " + e.Message;
                return null;
            }
        }

        public static List<strVwSolicitudes> ListaCompleta()
        {
            try
            {
                servicio.Url = ConsultaSolicitudes.Properties.Settings.Default.wsSolicitantesBecas;

                var request = servicio.listaCompleta();

                if (request.statusResponse.statusOper == false)
                {
                    err.setError = "ConsultaSolicitudes.Models.getData.ListaCompleta() - " + request.statusResponse.message;
                    return null;
                }

                List<strVwSolicitudes> Lista = new List<strVwSolicitudes>();
                foreach (var item in request.data)
                {
                    Lista.Add(new strVwSolicitudes()
                    {
                        calles = item.calles,
                        colonia = item.colonia,
                        correo = item.correo,
                        curp = item.curp,
                        domDesc = item.domDesc,
                        domIdCalle = item.domIdCalle,
                        domIdColonia = item.domIdColonia,
                        domIdLocalidad = item.domIdLocalidad,
                        domIdMpio = item.domIdMpio,
                        domLetra = item.domLetra,
                        domNumExt = item.domNumExt,
                        domNumInt = item.domNumInt,
                        edad = item.edad,
                        fIns = item.fIns,
                        localidad = item.localidad,
                        mamaNombres = item.mamaNombres,
                        mamaPrimerApellido = item.mamaPrimerApellido,
                        mamaSegundoApellido = item.mamaSegundoApellido,
                        municipio = item.municipio,
                        nombres = item.nombres,
                        papaNombres = item.papaNombres,
                        papaPrimerApellido = item.papaPrimerApellido,
                        papaSegundoApellido = item.papaSegundoApellido,
                        primerApellido = item.primerApellido,
                        segundoApellido = item.segundoApellido,
                        sexo = item.sexo,
                        telCel = item.telCel,
                        telPart = item.telPart,
                        idEscuela = item.idEscuela,
                        institucion = item.institucion,
                        nivel = item.nivel,
                        plantel = item.plantel,
                        idUsuario = item.idUsuario,
                        usuario = item.usuario
                    });
                }
                return Lista;
            }
            catch (Exception e)
            {
                err.setError = "ConsultaSolicitudes.Models.getData.ListaReducida() - " + e.Message;
                return null;
            }
        }



    }
}