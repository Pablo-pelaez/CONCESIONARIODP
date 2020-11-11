using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.gestionContrato;
using System.Threading.Tasks;
using System.Data;

namespace Controlador.Contrato
{
    public class logicaControladorContrato
    {
        //Negociar INSERT
        public int negociarInsertContrato(int idContrato, int Id_Vehiculo, int id_tipo_conductor)
        {
            accesoMetodosCRUDTipoContrato negociarAcceso = new accesoMetodosCRUDTipoContrato();

            return negociarAcceso.insertTipoContrato(idContrato, Id_Vehiculo, id_tipo_conductor);
        }

        //Negociar SELECT
        public static DataTable negociarSelectContrato()
        {
            return accesoMetodosCRUDTipoContrato.listTipoContrato();
        }

        //Negociar UPDATE
        public int negociarUpdateTipoContrato(int idContrato, int Id_Vehiculo, int id_tipo_conductor)
        {
            accesoMetodosCRUDTipoContrato negociarAcceso = new accesoMetodosCRUDTipoContrato();

            return negociarAcceso.updateTipoConductor(idContrato, Id_Vehiculo, id_tipo_conductor);
        }

        //Negociar DELETE
        public int negociarDeleteTipoContrato(int idContrato)
        {
            accesoMetodosCRUDTipoContrato negociarAcceso = new accesoMetodosCRUDTipoContrato();

            return negociarAcceso.deleteTipoConductor(idContrato);
        }
    }
}
