<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SolicitanteForm.aspx.cs" Inherits="Hospital_Empleados.Pages.SolicitanteForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />

    <title>Solicitantes</title>
</head>
<body>
              <div>
     <form id="SolicitanteForm" runat="server" method="post" action="SolicitanteForm.aspx">
    <h2>Formulario Solicitantes</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>Nombre:</label>
    <input type="text" id="nombre" name="nombre" class="input" required /><br />
    <label>Curriculo:</label>
    <input type="text" id="curriculo" name="curriculo" class="input" required /><br />
    <label>Correo</label>
    <input type="text" id="correo" name="correo" class="input" required /><br />
    <label>Telefono:</label>
    <input type="text" id="telefono" name="telefono" class="input" required /><br />
    <label>Sexo:</label>
    <input type="text" id="sexo" name="sexo" class="input" required /><br />
    <label>Direccion:</label>
    <input type="text" id="direccion" name="direccion" class="input" required /><br />
    <label>IdVacante: </label>
    <input type="number" id="idVacante" name="idVacante" class="input" required /><br />
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
</body>
</html>
