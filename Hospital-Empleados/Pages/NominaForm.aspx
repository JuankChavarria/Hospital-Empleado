<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NominaForm.aspx.cs" Inherits="Hospital_Empleados.Pages.Nomina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />

    <title>Nomina</title>
</head>
<body>
        <div>
     <form id="NominaForm" runat="server" method="post" action="NominaForm.aspx">
    <h2>Formulario Nomina</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Mes:</label>
    <input type="text" id="mes" name="mes" class="input" required /><br />
    <label>Salario Base:</label>
    <input type="number" id="base" name="base" class="input" required /><br />
    <label>Horas Extras:</label>
    <input type="number" id="horas" name="horas" class="input" required /><br />
    <label>Deducciones:</label>
    <input type="number" id="deducciones" name="deducciones" class="input" required /><br />
    <label>Salario Neto:</label>
    <input type="number" id="neto" name="neto" class="input" required /><br />
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
