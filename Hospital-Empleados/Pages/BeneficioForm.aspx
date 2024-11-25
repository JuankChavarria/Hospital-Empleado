<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BeneficioForm.aspx.cs" Inherits="Hospital_Empleados.Pages.BeneficioForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Beneficios</title>
    <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />
</head>
<body>
        <div>
            <body>
        <div>
     <form id="BeneficioForm" runat="server" method="post" action="BeneficioForm.aspx">
    <h2>Formulario Beneficio</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Tipo:</label>
    <input type="text" id="tipo" name="tipo" class="input" required /><br />
    <label>Valor:</label>
    <input type="number" id="valor" name="valor" class="input" required /><br />
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
    </form>
</body>
        </div>
    </form>
</body>
</html>
