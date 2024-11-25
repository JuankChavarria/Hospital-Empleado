<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpleadoForm.aspx.cs" Inherits="Hospital_Empleados.Pages.EmpleadoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Empleado</title>
            <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />

</head>
<body>
        <div>
     <form id="EmpleadoForm" runat="server" method="post" action="EmpleadoForm.aspx">
    <h2>Formulario Empleado</h2>
    <label>ID Empleado: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>Nombre:</label>
    <input type="text" id="nombre" name="nombre" class="input" required /><br />
    <label>Direccion:</label>
    <input type="text" id="direccion" name="direccion" class="input" required /><br />
    <label>Correo</label>
    <input type="text" id="correo" name="correo" class="input" required /><br />
    <label>Telefono:</label>
    <input type="text" id="telefono" name="telefono" class="input" required /><br />
    <label>Fecha Ingreso:</label>
    <input type="datetime" id="ingreso" name="ingreso" class="input" required /><br />
    <label>Cargo:</label>
    <input type="text" id="cargo" name="cargo" class="input" required /><br />
    <label>Departamento:</label>
    <input type="text" id="departamento" name="departamento" class="input" required /><br />
    <label>Salario:</label>
    <input type="number" id="salario" name="salario" class="input" required /><br />
    <label>Estado Laboral:</label>
    <input type="text" id="estado" name="estado" class="input" required /><br />
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
