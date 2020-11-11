<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestionRuta.aspx.cs" Inherits="Vista.gestionRuta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
</head>
<body>

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a href="index.html" class="navbar-brand">Concesionario</a>
    </nav>

    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="collapse navbar-collapse" id="navbarNavegacion">

                 <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="gestionTipoVehiculos.aspx">Tipo de Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionVehiculo.aspx">Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionTipoConductor.aspx">Tipo Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionConductor.aspx">Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionContrato.aspx">Contrato</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionRuta.aspx">Ruta</a>
                </li>
            </ul>

        </div>
    </nav>


    <div class="container">

        <br />
        <h1>Gestión de Ruta</h1>
        <br />

        <form id="form1" runat="server">

            <div class="form-group">
                <label for="txtId">Id</label>
                <asp:TextBox ID="txtId" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtestacion">Estacion</label>
                <asp:TextBox ID="txtestacion" runat="server" class="form-control"></asp:TextBox>
            </div>
          
            <div class="form-group">
                <label for="txtid_vehiculo">Id vehiculo</label>
                <asp:TextBox ID="txtid_vehiculo" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-row">

                <div class="px-2">
                    <asp:Button ID="btnAdd" runat="server" Text="Agregar" class="btn btn-success" OnClick="btnAdd_Click"/>  
                </div>

                <div class="px-2">
                    <asp:Button ID="btnList" runat="server" Text="Listar" class="btn btn-primary" OnClick="btnList_Click"/>  
                </div>

                <div class="px-2">
                    <asp:Button ID="btnModify" runat="server" Text="Modificar" class="btn btn-warning" OnClick="btnModify_Click"/>  
                </div>

                <div class="px-2">
                    <asp:Button ID="btnDelete" runat="server" Text="Eliminar" class="btn btn-secondary" OnClick="btnDelete_Click"/>  
                </div>

            </div>

            <div class="form-row">
                 <asp:Label ID="lblMensaje" runat="server" ForeColor="#009933" EnableViewState="false"></asp:Label>
            </div>

            <table class="table mt-3">
                <tr>
                    <th>
                        <asp:GridView runat="server" ID="GridView" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="Id"/>
                                <asp:BoundField DataField="estacion" HeaderText="Estacion"/>
                                <asp:BoundField DataField="id_vehiculo" HeaderText="Id vehiculo"/>
                            </Columns>
                        </asp:GridView>
                    </th>
                </tr>
            </table>
        </form>

    </div>



     <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
</body>
</html>

