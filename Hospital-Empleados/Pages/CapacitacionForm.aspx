<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CapacitacionForm.aspx.cs" Inherits="Hospital_Empleados.Pages.CapacitacionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />

    <title>Capacitacion</title>
</head>
<body>
        <div>
            <body>
        <div>
     <form id="CapacitacionForm" runat="server" method="post" action="CapacitacionForm.aspx">
    <h2>Formulario Capacitacion</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Curso:</label>
    <input type="text" id="curso" name="curso" class="input" required /><br />
    <label>Fecha Inicio:</label>
    <input type="datetime" id="inicio" name="inicio" class="input" required /><br />
    <label>Fecha Fin:</label>
    <input type="datetime" id="fin" name="fin" class="input" required /><br />
    <label>Certificacion:</label>
    <input type="text" id="certificacion" name="certificacion" class="input" required /><br />
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
