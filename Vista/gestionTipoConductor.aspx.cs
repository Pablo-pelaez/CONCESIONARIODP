using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controlador.TipoConductor;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;

            logicaControladorTipoConductor negocioAgregarTipoVehiculo = new logicaControladorTipoConductor();

            //ATV (Agregar Tipo Vehiculo)
            int resultadoATV = negocioAgregarTipoVehiculo.negociarInsertTipoConductor(id, nombre);

            if (resultadoATV > 0)
            {
                lblMensaje.Text = "Registro agregado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al agregar registro";
            }

            negocioAgregarTipoVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorTipoConductor.negociarSelectTipoConductor();

            GridView.DataBind();

            txtId.Text = txtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;

            logicaControladorTipoConductor negocioModificarTipoConductor = new logicaControladorTipoConductor();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioModificarTipoConductor.negociarUpdateTipoConductor(id, nombre);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro modificado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al modificar registro";
            }

            negocioModificarTipoConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;

            logicaControladorTipoConductor NegocioEliminartTipoConductor = new logicaControladorTipoConductor();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = NegocioEliminartTipoConductor.negociarDeleteTipoConductor(id);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro eliminado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al eliminar registro";
            }

            NegocioEliminartTipoConductor = null;
        }
    }
}