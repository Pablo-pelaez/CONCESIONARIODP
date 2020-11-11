using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controlador.Ruta;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            {
                int id = Int32.Parse(txtId.Text);
                string estacion = txtestacion.Text;
                int id_vehiculo = Int32.Parse(txtid_vehiculo.Text);




                logicaControladorRuta NegocioAgregarContrato = new logicaControladorRuta();


                //ATV (Agregar Vehiculo)
                int resultadoATV = NegocioAgregarContrato.negociarInsertgestionRUTA(id, estacion, id_vehiculo);

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
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorRuta.negociarSelectContrato();

            GridView.DataBind();

            txtId.Text = txtestacion.Text = txtid_vehiculo.Text = "";
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = txtestacion.Text;
            int id_vehiculo = Int32.Parse(txtid_vehiculo.Text);

            logicaControladorRuta negocioModificargestionRuta = new logicaControladorRuta();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioModificargestionRuta.negociarUpdateTipoContrato(id, estacion, id_vehiculo);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro modificado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al modificar registro";
            }

            negocioModificargestionRuta = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = txtestacion.Text;
            int id_vehiculo = Int32.Parse(txtid_vehiculo.Text);

            logicaControladorRuta negocioEliminargestionRuta = new logicaControladorRuta();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioEliminargestionRuta.negociarDeleteTipoContrato(id);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro eliminado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al eliminar registro";
            }

            negocioEliminargestionRuta = null;
        }
    }
}