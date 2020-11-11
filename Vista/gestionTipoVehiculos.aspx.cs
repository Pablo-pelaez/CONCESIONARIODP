using Controlador.tipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionTipoVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;

            logicaControladortipoVehiculo negocioAgregarTipoVehiculo = new logicaControladortipoVehiculo();

            //ATV (Agregar Tipo Vehiculo)
            int resultadoATV = negocioAgregarTipoVehiculo.negociarInsertTipoVehiculo(id, nombre);

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
            GridView.DataSource = logicaControladortipoVehiculo.negociarSelectTipoVehiculo();

            GridView.DataBind();

            txtId.Text = txtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;

            logicaControladortipoVehiculo negocioModificarTipoVehiculo = new logicaControladortipoVehiculo();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioModificarTipoVehiculo.negociarUpdateTipoVehiculo(id, nombre);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro modificado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al modificar registro";
            }

            negocioModificarTipoVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;

            logicaControladortipoVehiculo negocioEliminarTipoVehiculo = new logicaControladortipoVehiculo();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioEliminarTipoVehiculo.negociarDeleteTipoVehiculo(id);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro eliminado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al eliminar registro";
            }

            negocioEliminarTipoVehiculo = null;
        }
    }
}