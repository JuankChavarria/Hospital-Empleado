<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VacantesForm.aspx.cs" Inherits="Hospital_Empleados.Pages.Vacantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />

    <title>Vacantes</title>
</head>
<body>
               <div>
     <form id="VacanteForm" runat="server" method="post" action="VacanteForm.aspx">
    <h2>Formulario Vacantes</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>Puesto:</label>
    <input type="text" id="puesto" name="puesto" class="input" required /><br />
    <label>Fecha Departamento:</label>
    <input type="datetime" id="departamento" name="departamento" class="input" required /><br />
    <label>Descripcion:</label>
    <input type="text" id="descripcion" name="descripcion" class="input" required /><br />
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
