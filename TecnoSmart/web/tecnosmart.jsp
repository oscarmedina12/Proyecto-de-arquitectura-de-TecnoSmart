
<%@page import="dao.UsuarioDAO"%>
<%@page import="util.UsuarioUtil"%>
<%@page import="java.util.ArrayList"%>
<%@page import="modelos.Usuario"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
        <%--<link href="css/estilos.css" rel="stylesheet" type="text/css"/>--%>
        <link href="css/Estilode_bar.css" rel="stylesheet" type="text/css"/>
        <title>TecnoSmart</title>
    </head>
    <body class="Body">
        <div class="navbar">
  <a href="index.jsp">Salir session</a>
  <a href="crudProductos.jsp">Ingresar un servicio</a>
 
  </div> 
</div>
    <center>
        
        <h1>Bienvenido
            <% if(session.getAttribute("usuario")!= null){
             Usuario u = (Usuario) session.getAttribute("usuario");
            %>
        <h3><%= u.getNombre()+" "+u.getApellido() %></h3>
        <%}else{response.sendRedirect("index.jsp?msj=acceso denegado");}%>
       
        <h2>Detalledes de servicios</h2> 
 <table>
  <tr>
    <th>Codigo de cliente</th>
    <th>Nombre</th>
    <th>Estado</th>
    <th>  modificar   </th>
  </tr>
  <tr>
    <td>03</td>
    <td>Smith</td>
    <td>arreglado</td>
    <td> 
   <a href="Editar_Productos.jsp" class="btn success">Editar</a>
       <input type="submit" class="btn info" value="Eliminar"/>
  </tr>
  <tr>
    <td>25</td>
    <td>Jackson</td>
    <td>cambio de pantalla</td>
     <td> <input type="submit" class="btn success" value="Editar"/>
       <input type="submit" class="btn info" value="Eliminar"/>
  </tr>
  <tr>
    <td>01</td>
    <td>Johnson</td>
    <td>arreglado</td>
    <td> <input type="submit" class="btn success" value="Editar"/>
       <input type="submit" class="btn info" value="Eliminar"/>
  </tr>
</table>
       
  
        
        <% if(request.getParameter("msj")!= null){%>
        <h3><%= request.getParameter("msj") %></h3>
        <%}%>
        
      </center>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    </body>
</html>
