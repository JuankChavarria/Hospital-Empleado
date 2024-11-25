<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteForm.aspx.cs" Inherits="Hospital_Empleados.Pages.ReporteForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />
    <title>Reporte</title>
</head>
<body>
 
        <div>
     <form id="ReporteForm" runat="server" method="post" action="ReporteForm.aspx">
    <h2>Formulario Capacitacion</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Titulo:</label>
    <input type="text" id="titulo" name="titulo" class="input" required /><br />
          <label>Descripcion:</label>
 <input type="text" id="descripcion" name="descripcion" class="input" required /><br />
    <label>Fecha Generacion:</label>
    <input type="datetime" id="generacion" name="generacion" class="input" required /><br />
    <label>Autor:</label>
    <input type="text" id="autor" name="autor" class="input" required /><br />
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
