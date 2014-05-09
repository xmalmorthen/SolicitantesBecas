using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SolicitantesBecas.Models
{
    static class getData
    {
        private static wsSolicitanteBecas.SolicitantesBecasSoapClient servicio = new wsSolicitanteBecas.SolicitantesBecasSoapClient();

        public static List<strCaUsuarios> caUsuarios()
        {
            
            var request = servicio.caUsuarios();

            if (request.statusResponse.statusOper == false) {
                return null;
            }

            List<strCaUsuarios> Lista = new List<strCaUsuarios>();
            foreach (var item in request.data)
            {
                Lista.Add(new strCaUsuarios() {
                    id = item.id,
                    cveUsuario = item.cveUsuario,
                    usuario = item.usuario                
                });
            }
            return Lista;
        }

        public static List<strCaEscuelas> caEscuelas()
        {
            
            var request = servicio.caEscuelas();

            if (request.statusResponse.statusOper == false) {
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

    }
}
