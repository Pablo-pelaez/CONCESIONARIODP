using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.gestionConductor;
using System.Threading.Tasks;
using System.Data;

namespace Controlador.Conductor
{
    public class logicaControladorConductor
    {

        //Negociar INSERT
        public int negociarInsertConductor(int idConductor, string nombre, string licencia, int Id_Vehiculo, int id_tipo_conductor)
        {
            accesoMetodosCRUDConductor negociarAcceso = new accesoMetodosCRUDConductor();

            return negociarAcceso.insertConductor(idConductor, nombre, licencia, Id_Vehiculo, id_tipo_conductor);
        }

        //Negociar SELECT
        public static DataTable negociarSelectConductor()
        {
            return accesoMetodosCRUDConductor.listConductor();
        }

        //Negociar UPDATE
        public int negociarUpdateTipoConductor(int idConductor, string nombre, string licencia, int Id_Vehiculo, int id_tipo_conductor)
        {
            accesoMetodosCRUDConductor negociarAcceso = new accesoMetodosCRUDConductor();

            return negociarAcceso.updateConductor(idConductor, nombre, licencia, Id_Vehiculo, id_tipo_conductor);
        }

        //Negociar DELETE
        public int negociarDeleteTipoConductor(int idConductor)
        {
            accesoMetodosCRUDConductor negociarAcceso = new accesoMetodosCRUDConductor();

            return negociarAcceso.deleteConductor(idConductor);
        }
    }
}