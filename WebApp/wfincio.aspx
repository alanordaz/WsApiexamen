<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfincio.aspx.cs" Inherits="WebApp.wfincio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Escribe el id del examen"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
             <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txNombre" runat="server" OnTextChanged="txNombre_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />


            <asp:GridView ID="gvdExamenes" runat="server" AutoGenerateColumns="false" DataKeyNames="ClaveExamenes"></asp:GridView>
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="ID" />
                <asp:BoundField DataField="Descipcion" HeaderText="ID" />
            </Columns>
        </div>
        <asp:TextBox ID="lbmensaje" runat="server"></asp:TextBox>
    </form>
</body>
</html>
