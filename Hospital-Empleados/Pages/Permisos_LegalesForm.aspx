<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Permisos_LegalesForm.aspx.cs" Inherits="Hospital_Empleados.Pages.Permisos_LegalesForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />

    <title></title>
</head>
<body>
        <div>
     <form id="PermisosForm" runat="server" method="post" action="PermisosForm.aspx">
    <h2>Formulario Capacitacion</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Tipo:</label>
    <input type="text" id="tipo" name="tipo" class="input" required /><br />
    <label>Fecha Inicio:</label>
    <input type="datetime" id="inicio" name="inicio" class="input" required /><br />
    <label>Fecha Fin:</label>
    <input type="datetime" id="fin" name="fin" class="input" required /><br />
    <label>Descripcion:</label>
    <input type="text" id="descripcion" name="descripcion" class="input" required /><br />
    <label>Adicionado Por:</label>
    <input type="text" id="por" name="por" class="input" required /><br />
    <label>Fecha Adicion:</label>
    <input type="datetime" id="adicion" name="adicion" class="input" required /><br />
    <label>Modificado Por:</label>
    <input type="text" id="modificado" name="modificado" class="input" required /><br />
    <label>Fecha Modificacion:</label>
    <input type="datetime" id="modificacion" name="modificacion" class="input" required /><br />
    <input type="submit" value="Cancelar" class="button" />
    <input type="submit" value="Guardar" class="button" />
</form>   

        </div>
</body>
</html>
