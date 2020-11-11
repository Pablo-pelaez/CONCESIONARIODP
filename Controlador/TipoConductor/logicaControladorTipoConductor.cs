using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.tipoConductor;
using System.Threading.Tasks;
using System.Data;

namespace Controlador.TipoConductor
{
    public class logicaControladorTipoConductor
    {
        //Negociar INSERT
        public int negociarInsertTipoConductor(int idTipoConductor, string nombre)
        {
            accesoMetodosCRUDTipoConductor negociarAcceso = new accesoMetodosCRUDTipoConductor();

            return negociarAcceso.insertTipoConductor(idTipoConductor, nombre);
        }

        //Negociar SELECT
        public static DataTable negociarSelectTipoConductor()
        {
            return accesoMetodosCRUDTipoConductor.listTipoConductor();
        }

        //Negociar UPDATE
        public int negociarUpdateTipoConductor(int idTipoConductor, string nombre)
        {
            accesoMetodosCRUDTipoConductor negociarAcceso = new accesoMetodosCRUDTipoConductor();

            return negociarAcceso.updateTipoConductor(idTipoConductor, nombre);
        }

        //Negociar DELETE
        public int negociarDeleteTipoConductor(int idTipoConductor)
        {
            accesoMetodosCRUDTipoConductor negociarAcceso = new accesoMetodosCRUDTipoConductor();

            return negociarAcceso.deleteTipoConductor(idTipoConductor);
        }
    }
}