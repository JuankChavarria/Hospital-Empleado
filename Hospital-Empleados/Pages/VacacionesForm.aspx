﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VacacionesForm.aspx.cs" Inherits="Hospital_Empleados.Pages.Vacaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Vacaciones</title>
    <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />

</head>
<body>
      <div>
     <form id="VacacionesForm" runat="server" method="post" action="VacacionesForm.aspx">
    <h2>Formulario Vacaciones</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Dias Disponibles:</label>
    <input type="text" id="disponibles" name="disponibles" class="input" required /><br />
    <label>Dias Usados:</label>
    <input type="text" id="usados" name="usados" class="input" required /><br />
    <label>Fecha Solicitud:</label>
    <input type="datetime" id="solicitud" name="solicitud" class="input" required /><br />
    <label>Fecha Inicio:</label>
    <input type="datetime" id="inicio" name="inicio" class="input" required /><br />
    <label>Fecha Fin:</label>
    <input type="datetime" id="fin" name="fin" class="input" required /><br />
    <label>Estado:</label>
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
    </form>
</body>
</html>
