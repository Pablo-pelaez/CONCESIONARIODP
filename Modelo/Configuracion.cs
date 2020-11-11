using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Configuracion
    {
        static string cadenaConexion = @"Data Source=DESKTOP-F5HOT1E;Initial Catalog=concesionarioWH; Trusted_Connection=true";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
