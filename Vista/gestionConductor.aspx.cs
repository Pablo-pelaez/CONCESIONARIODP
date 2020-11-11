using System;
using System.Collections.Generic;
using System.Linq;
using Controlador.Conductor;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;
            string licencia = txtLicencia.Text;
            int Id_Vehiculo = Int32.Parse(txtIdvehiculo.Text);
            int id_tipo_conductor = Int32.Parse(txtTipconductor.Text);
           
           logicaControladorConductor  negocioAgregarConductor = new logicaControladorConductor();
            

            //ATV (Agregar Vehiculo)
            int resultadoATV = negocioAgregarConductor.negociarInsertConductor(id, nombre, licencia, Id_Vehiculo, id_tipo_conductor);

            if (resultadoATV > 0)
            {
                lblMensaje.Text = "Registro agregado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al agregar registro";
            }

            negocioAgregarConductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorConductor.negociarSelectConductor();

            GridView.DataBind();

            txtId.Text = txtName.Text = txtLicencia.Text = txtIdvehiculo.Text = txtTipconductor.Text =  "";
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;
            string licencia = txtLicencia.Text;
            int Id_Vehiculo = Int32.Parse(txtIdvehiculo.Text);
            int id_tipo_conductor = Int32.Parse(txtTipconductor.Text);

            logicaControladorConductor negocioModificarConductor = new logicaControladorConductor();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioModificarConductor.negociarUpdateTipoConductor(id, nombre, licencia, Id_Vehiculo, id_tipo_conductor);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro modificado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al modificar registro";
            }

            negocioModificarConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;
            string licencia = txtLicencia.Text;
            int Id_Vehiculo = Int32.Parse(txtIdvehiculo.Text);
            int id_tipo_conductor = Int32.Parse(txtTipconductor.Text);

            logicaControladorConductor negocioEliminarConductor = new logicaControladorConductor();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioEliminarConductor.negociarDeleteTipoConductor(id);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro eliminado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al eliminar registro";
            }

            negocioEliminarConductor = null;
        }
    }
}