using System;
using System.Collections.Generic;
using System.Linq;
using Modelo.gestionRuta;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Controlador.Ruta
{
    public class logicaControladorRuta
    {
        //Negociar INSERT
        public int negociarInsertgestionRUTA(int id,string estacion, int Id_Vehiculo)
        {
            accesoMetodosCRUDgestionRuta negociarAcceso = new accesoMetodosCRUDgestionRuta();

            return negociarAcceso.insertgestinRuta(id, estacion, Id_Vehiculo);
        }

        //Negociar SELECT
        public static DataTable negociarSelectContrato()
        {
            return accesoMetodosCRUDgestionRuta.listgestionRuta();
        }

        //Negociar UPDATE
        public int negociarUpdateTipoContrato(int id, string estacion, int Id_Vehiculo)
        {
            accesoMetodosCRUDgestionRuta negociarAcceso = new accesoMetodosCRUDgestionRuta();

            return negociarAcceso.updategestionRuta(id, estacion, Id_Vehiculo);
        }

        //Negociar DELETE
        public int negociarDeleteTipoContrato(int id)
        {
            accesoMetodosCRUDgestionRuta negociarAcceso = new accesoMetodosCRUDgestionRuta();

            return negociarAcceso.deletegestionRuta(id);
        }
    }
}

