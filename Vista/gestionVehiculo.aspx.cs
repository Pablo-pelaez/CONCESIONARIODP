using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controlador.Vehiculo;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            int anio = Int32.Parse(txtAnio.Text);
            int id_tv = Int32.Parse(txtid_tv.Text);

            logicaControladorVehiculo negocioAgregarTipoVehiculo = new logicaControladorVehiculo();

            //ATV (Agregar Vehiculo)
            int resultadoATV = negocioAgregarTipoVehiculo.negociarInsertTipoVehiculo(id, marca, modelo,placa,anio,id_tv);

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
            GridView.DataSource = logicaControladorVehiculo.negociarSelectTipoVehiculo();

            GridView.DataBind();

            txtId.Text = txtModelo.Text = txtPlaca.Text = txtMarca.Text = txtAnio.Text = txtid_tv.Text = "";
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            {
                int id = Int32.Parse(txtId.Text);
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string placa = txtPlaca.Text;
                int anio = Int32.Parse(txtAnio.Text);
                int id_tv = Int32.Parse(txtid_tv.Text);

                logicaControladorVehiculo negocioModificarVehiculo = new logicaControladorVehiculo();

                //ATV (Modificar Tipo Vehiculo)
                int resultadoMTV = negocioModificarVehiculo.negociarUpdateVehiculo(id, marca, modelo, placa,anio,id_tv);

                if (resultadoMTV > 0)
                {
                    lblMensaje.Text = "Registro modificado correctamente";
                }
                else
                {
                    lblMensaje.Text = "Error al modificar registro";
                }

                negocioModificarVehiculo = null;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            int anio = Int32.Parse(txtAnio.Text);
            int id_tv = Int32.Parse(txtid_tv.Text);

            logicaControladorVehiculo negocioEliminarVehiculo = new logicaControladorVehiculo();

            //ATV (Modificar Tipo Vehiculo)
            int resultadoMTV = negocioEliminarVehiculo.negociarDeleteVehiculo(id);

            if (resultadoMTV > 0)
            {
                lblMensaje.Text = "Registro eliminado correctamente";
            }
            else
            {
                lblMensaje.Text = "Error al eliminar registro";
            }

            negocioEliminarVehiculo = null;
        }
    }
}