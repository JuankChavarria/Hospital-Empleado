<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvaluacionesForm.aspx.cs" Inherits="Hospital_Empleados.Pages.EvaluacionesForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Evaluacion</title>
         <link rel="stylesheet" type="text/css" href="../Styles/Styles.css" />
</head>
<body>
        <div>
     <form id="EvaluacionForm" runat="server" method="post" action="EvaluacionForm.aspx">
    <h2>Evaluacion Capacitacion</h2>
    <label>ID: </label>
    <input type="number" id="id" name="id" class="input" required /><br />
    <label>ID Empleado:</label>
    <input type="number" id="idEmpleado" name="idEmpleado" class="input" required /><br />
    <label>Fecha:</label>
    <input type="datetime" id="fecha" name="fecha" class="input" required /><br />
    <label>Indicadores:</label>
    <input type="text" id="indicador" name="indicador" class="input" required /><br />
    <label>Resultado:</label>
    <input type="text" id="resultado" name="resultado" class="input" required /><br />
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
