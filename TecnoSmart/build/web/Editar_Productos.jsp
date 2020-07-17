<%-- 
    Document   : Editar_Productos
    Created on : 16-jul-2020, 22:32:40
    Author     : oscar medina
--%>


<%@page import="dao.EstadoDAO"%>
<%@page import="modelos.Estado"%>
<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
        <%--<link href="css/estilos.css" rel="stylesheet" type="text/css"/>--%>
        <link href="css/Estilo_Producto.css" rel="stylesheet" type="text/css"/>
        <title>TecnoSmart</title>
    </head>
    <body class="Body">
    
           <body class="Body">
        <div class="navbar">
  <a href="index.jsp">Salir sesion</a>
  <a href="tecnosmart.jsp">Detalle de servicios</a>
 
  </div> 
        <h1>Ingreso de Reparacion</h1>
        <center> <div class="container">
                <table><td>
                <h2>Datos Clientes</h2>
  <form action="ControladorProducto" method="post">
    <label for="fname">Nombre Cliente</label>
    <input type="text" name="nombreCliente"/>

    <label for="lname">Email</label>
    <input type="text" name="emailCliente"/>
    <label for="lname">Rut</label>
    <input type="text" name="rutCliente"/>
    <label for="lname">Telefono</label>
    <input type="text" name="telefonoCliente"/>
                    </td> </table>
                <table><td>
    <h2> Datos Reparaciones</h2>
    <table><td>
<label>Codigo de Cliente:</label>
    <input type="number" name="codigo"/>
                    </td></table><label >Tipo de Productos</label>
    <input type="text" name="tipoProducto"/>
       
   <label for="lname">Modelo de Producto</label>
    <input type="text" name="modeloProducto"/>

 <label for="subject">Descripcion del Problema</label>
   <textarea cols="20" rows="5" name="descripcionProblema"></textarea>


    
    <label for="country">Estado</label>
   <select name="estado">
                            <option value="0">Seleccione</option>
                            <% ArrayList<Estado> estados = new EstadoDAO().obtenerEstados(); 
                            for(Estado e:estados){%>
                            <option value="<%= e.getId() %>"><%= e %></option>
                            <% } %>
                        </select>

    <label for="lname">Precios</label>
    <input type="number" name="precio"/>
                    </td></table>
<table>
  <td><input type="reset" value="Limpiar"/>
   <input type="submit" value="Guardar"/>
   <input type="hidden" name="accion" value="1"/></td></table>
 
  </form>
</div>
                        <% if(request.getParameter("msj")!= null){%>
        <h4><%= request.getParameter("msj") %></h4>
        <%}%>
    
    
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    </body>
</html>