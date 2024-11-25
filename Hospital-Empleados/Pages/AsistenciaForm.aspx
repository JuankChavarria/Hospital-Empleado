<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsistenciaForm.aspx.cs" Inherits="Hospital_Empleados.Pages.AsistenciaForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     
    <title>Asistencia</title>
   <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />
    
</head>
<body>
        <div>
     <form id="asistenciaForm" runat="server" method="post" action="AsistenciaForm.aspx">
    <h2>Formulario Asistencia</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Fecha:</label>
    <input type="datetime" id="fecha" name="fecha" class="input" required /><br />
    <label>Hora Entrada:</label>
    <input type="datetime" id="entrada" name="entrada" class="input" required /><br />
    <label>Hora Salida:</label>
    <input type="datetime" id="salida" name="salida" class="input" required /><br />
    <label>Hora Trabajadas:</label>
    <input type="datetime" id="trbajadas" name="trbajadas" class="input" required /><br />
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
    </form>
</body>
</html>
