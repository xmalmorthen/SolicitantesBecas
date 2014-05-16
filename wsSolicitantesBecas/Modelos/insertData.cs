using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace wsSolicitantesBecas.Modelos
{
    public static class insertData
    {
        public static StcInsertaSolicitud Solicitud(int idUsuario, string xmlData)
        {
            BdCapturaBECASDataContext bd = new BdCapturaBECASDataContext();
            StcInsertaSolicitud response = new StcInsertaSolicitud();

            response.statusResponse.statusOper = false;
            response.statusResponse.message = messages.fallo;

            try
            {                
                var consulta = from solicitud in XElement.Parse(xmlData).Elements("solicitud")
                               select new strMaSolicitantes
                               {
                                    curp = solicitud.Element("curp").Value,
                                    primerApellido  = solicitud.Element("primerApellido").Value,
                                    segundoApellido  = solicitud.Element("segundoApellido").Value,
                                    nombres  = solicitud.Element("nombres").Value,
                                    edad  = solicitud.Element("edad").Value,
                                    sexo = solicitud.Element("sexo").Value,
                                    correo = solicitud.Element("correo").Value,
                                    telCel = solicitud.Element("telCel").Value,
                                    telPart = solicitud.Element("telPart").Value,
                                    domIdMpio = solicitud.Element("domIdMpio").Value,
                                    domIdLocalidad = solicitud.Element("domIdLocalidad").Value,
                                    domIdColonia = solicitud.Element("domIdColonia").Value,
                                    domIdCalle = solicitud.Element("domIdCalle").Value,
                                    domMpio = solicitud.Element("domMpio").Value,
                                    domLocalidad = solicitud.Element("domLocalidad").Value,
                                    domColonia = solicitud.Element("domColonia").Value,
                                    domCalle = solicitud.Element("domCalle").Value,
                                    domNumExt =   solicitud.Element("domNumExt").Value,
                                    domNumInt =  solicitud.Element("domNumInt").Value,
                                    domLetra = solicitud.Element("domLetra").Value,
                                    idEscuela = Convert.ToInt32(solicitud.Element("idEscuela").Value),
                                    papaPrimerApellido = solicitud.Element("papaPrimerApellido").Value,
                                    papaSegundoApellido = solicitud.Element("papaSegundoApellido").Value,
                                    papaNombres = solicitud.Element("papaNombres").Value,
                                    mamaPrimerApellido = solicitud.Element("mamaPrimerApellido").Value,
                                    mamaSegundoApellido = solicitud.Element("mamaSegundoApellido").Value,
                                    mamaNombres = solicitud.Element("mamaNombres").Value,
                                    domDesc = solicitud.Element("domDesc").Value,
                                    idUsuario = idUsuario,
                               };

                List<strMaSolicitantes> solicitudes = consulta.ToList<strMaSolicitantes>();

                foreach (strMaSolicitantes solicitud in solicitudes)
                {
                    if (!string.IsNullOrEmpty(solicitud.domIdMpio))
                    {
                        if (bd.caMunicipios.SingleOrDefault(query => query.id == new Guid(solicitud.domIdMpio)) == null)
                        {
                            caMunicipios municipio = new caMunicipios();
                            municipio.id = new Guid(solicitud.domIdMpio);
                            municipio.municipio = solicitud.domMpio;
                            bd.caMunicipios.InsertOnSubmit(municipio);
                        }
                    }

                    if (!string.IsNullOrEmpty(solicitud.domIdLocalidad))
                    {
                        if (bd.caLocalidades.SingleOrDefault(query => query.id == new Guid(solicitud.domIdLocalidad)) == null)
                        {
                            caLocalidades localidad = new caLocalidades();
                            localidad.id = new Guid(solicitud.domIdLocalidad);
                            localidad.localidad = solicitud.domLocalidad;
                            bd.caLocalidades.InsertOnSubmit(localidad);
                        }
                    }

                    if (!string.IsNullOrEmpty(solicitud.domIdColonia))
                    {
                        if (bd.caColonias.SingleOrDefault(query => query.id == new Guid(solicitud.domIdColonia)) == null)
                        {
                            caColonias colonia = new caColonias();
                            colonia.id = new Guid(solicitud.domIdColonia);
                            colonia.colonia = solicitud.domColonia;
                            bd.caColonias.InsertOnSubmit(colonia);
                        }
                    }

                    if (!string.IsNullOrEmpty(solicitud.domIdCalle))
                    {
                        if (bd.caCalles.SingleOrDefault(query => query.id == new Guid(solicitud.domIdCalle)) == null)
                        {
                            caCalles calle = new caCalles();
                            calle.id = new Guid(solicitud.domIdCalle);
                            calle.calles = solicitud.domCalle;
                            bd.caCalles.InsertOnSubmit(calle);
                        }
                    }

                    maSolicitantes main = new maSolicitantes();
                    main.curp = solicitud.curp;
                    main.primerApellido = solicitud.primerApellido;
                    main.segundoApellido  = solicitud.segundoApellido;
                    main.nombres  = solicitud.nombres;                    
                    main.edad  = Convert.ToInt32(solicitud.edad);
                    main.sexo = solicitud.sexo;
                    if (!string.IsNullOrEmpty(solicitud.correo))
                    {
                        main.correo = solicitud.correo;
                    }
                    if (!string.IsNullOrEmpty(solicitud.telCel))
                    {
                        main.telCel = solicitud.telCel;
                    }
                    if (!string.IsNullOrEmpty(solicitud.telPart))
                    {
                        main.telPart = solicitud.telPart;
                    }
                    if (!string.IsNullOrEmpty(solicitud.domIdMpio))
                    {
                        main.domIdMpio = new Guid(solicitud.domIdMpio);
                    }
                    if (!string.IsNullOrEmpty(solicitud.domIdLocalidad))
                    {
                        main.domIdLocalidad = new Guid(solicitud.domIdLocalidad);
                    }
                    if (!string.IsNullOrEmpty(solicitud.domIdColonia))
                    {
                        main.domIdColonia = new Guid(solicitud.domIdColonia);
                    }
                    if (!string.IsNullOrEmpty(solicitud.domIdCalle))
                    {
                        main.domIdCalle = new Guid(solicitud.domIdCalle);
                    }
                    if (!String.IsNullOrEmpty(solicitud.domNumExt))
                    {
                        main.domNumExt = Convert.ToInt32(solicitud.domNumExt);
                    }
                    if (!String.IsNullOrEmpty(solicitud.domNumInt))
                    {
                        main.domNumInt = Convert.ToInt32(solicitud.domNumInt);
                    }
                    if (!String.IsNullOrEmpty(solicitud.domLetra))
                    {
                        main.domLetra = solicitud.domLetra;
                    }
                    main.idEscuela = solicitud.idEscuela;

                    if (!String.IsNullOrEmpty(solicitud.papaPrimerApellido))
                    {
                        main.papaPrimerApellido = solicitud.papaPrimerApellido;
                    }
                    
                    if (!String.IsNullOrEmpty(solicitud.papaSegundoApellido))
                    {
                        main.papaSegundoApellido = solicitud.papaSegundoApellido;
                    }

                    if (!String.IsNullOrEmpty(solicitud.papaNombres))
                    {
                        main.papaNombres = solicitud.papaNombres;
                    }

                    if (!String.IsNullOrEmpty(solicitud.mamaPrimerApellido))
                    {
                        main.mamaPrimerApellido = solicitud.mamaPrimerApellido;
                    }

                    if (!String.IsNullOrEmpty(solicitud.mamaSegundoApellido))
                    {
                        main.mamaSegundoApellido = solicitud.mamaSegundoApellido;
                    }

                    if (!String.IsNullOrEmpty(solicitud.mamaNombres))
                    {
                        main.mamaNombres = solicitud.mamaNombres;
                    }

                    if (!String.IsNullOrEmpty(solicitud.domDesc))
                    {
                        main.domDesc = solicitud.domDesc;
                    }

                    main.idUsuario = solicitud.idUsuario;

                    bd.maSolicitantes.InsertOnSubmit(main);
                    
                }
                bd.SubmitChanges();
                bd.Dispose();                

                response.statusResponse.statusOper = true;
                response.statusResponse.message = messages.exito;
                
                return response;
            }
            catch (Exception e)
            {
                response.statusResponse.message = e.Message;
                return response;
            }
        }

    }
}