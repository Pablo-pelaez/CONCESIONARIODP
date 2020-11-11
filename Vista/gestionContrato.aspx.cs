using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controlador.Contrato;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int Id_Vehiculo = Int32.Parse(txtIdvehiculo.Text);
            int id_tipo_conductor = Int32.Parse(txtIdconductor.Text);

             logicaControladorContrato NegocioAgregarContrato= new logicaControladorContrato();


            //ATV (Agregar Vehiculo)
            int resultadoATV = NegocioAgregarContrato.negociarInsertContrato(id, Id_Vehiculo, id_tipo_conductor);

            if (resultadoATV > 0)
            {
                lblMensaje.Text = "Registro agregado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al agregar registro";
            }

            NegocioAgregarContrato = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorContrato.negociarSelectContrato(); 

            GridView.DataBind();

            txtId.Text = txtIdvehiculo.Text = txtIdconductor.Text = "";
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int Id_Vehiculo = Int32.Parse(txtIdvehiculo.Text);
            int id_tipo_conductor = Int32.Parse(txtIdconductor.Text);

            logicaControladorContrato negocioModificarContrato = new logicaControladorContrato();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioModificarContrato.negociarUpdateTipoContrato(id, Id_Vehiculo, id_tipo_conductor);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro modificado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al modificar registro";
            }

            negocioModificarContrato = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int Id_Vehiculo = Int32.Parse(txtIdvehiculo.Text);
            int id_tipo_conductor = Int32.Parse(txtIdconductor.Text);

            logicaControladorContrato negocioEliminarContrato = new logicaControladorContrato();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioEliminarContrato.negociarDeleteTipoContrato(id);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro eliminado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al eliminar registro";
            }

            negocioEliminarContrato = null;
        }
    }
}