/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controladores;

import dao.EstadoDAO;
import dao.ProductoDAO;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import modelos.Producto;
import java.util.Scanner;
/**
 *
 * @author DellPC
 */
@WebServlet(name = "ControladorProducto", urlPatterns = {"/ControladorProducto"})
public class ControladorProducto extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
         if(request.getParameter("accion")!=null){
        String accion = request.getParameter("accion");
        switch(accion){
            case "1": registrar(request,response);
                break;
        }
         }else{
             response.sendRedirect("crudProductos.jsp?msj=No te pases");
         }
    }
    
    private void registrar(HttpServletRequest request, HttpServletResponse response) throws IOException{
           try{
            long codigo =Long.parseLong(request.getParameter("codigo").trim());
            String tipoProducto = request.getParameter("tipoProducto").trim();
            String modeloProducto = request.getParameter("tipoProducto").trim();
            String descripcionProblema = request.getParameter("descripcionProblema").trim();
            int precio = Integer.parseInt(request.getParameter("precio").trim());
            String nombreCliente = request.getParameter("nombreCliente").trim();
            String emailCliente = request.getParameter("emailCliente").trim();
            String rutCliente = request.getParameter("rutCliente").trim();
            String telefonoCliente = request.getParameter("telefonoCliente").trim();
            int estado = Integer.parseInt( request.getParameter("estado").trim());
            if(codigo<1||tipoProducto.equals("")||modeloProducto.equals("")||descripcionProblema.equals("")||precio<1||
                    nombreCliente.equals("")||emailCliente.equals("")||rutCliente.equals("")||telefonoCliente.equals("")||
                    estado<1) // que hace aqui 
            {
                response.sendRedirect("crudProductos.jsp?msj=datos incorrectos");
            }else{
                EstadoDAO ed = new EstadoDAO();
                //crea nueva variable, pregunta
                Producto nuevoProducto = new Producto (codigo,tipoProducto,modeloProducto,descripcionProblema,
                        precio,nombreCliente,emailCliente,rutCliente,telefonoCliente,ed.obtenerEstado(estado));
                
                ProductoDAO pd = new ProductoDAO();
                
                if(pd.obtenerProducto(nuevoProducto.getCodigo())==null){
                    int respuesta = pd.registrar(nuevoProducto);
                    if(respuesta==1){
                    response.sendRedirect("crudProductos.jsp?msj=Reparacion registrada");
                    }else{
                    response.sendRedirect("crudProductos.jsp?msj=La reparacion no se pudo ingresar"); // For input String: ""
                    }
                }else{
                    response.sendRedirect("crudProductos.jsp?msj=El Codigo ya existe");
                }
            }
           }catch(Exception e){
               response.sendRedirect("crudProductos.jsp?msj="+e.getMessage());
           }
        }
    
    public class validacionrut {
    private int run;
    private char dv;
    
    public validacionrut()
    {}
    
    public validacionrut(int run, char dv)
    {
        this.setRun(run);
        this.setDv(dv);
    }

    /**
     * @return the run
     */
    public int getRun() {
        return run;
    }

    /**
     * @param run the run to set
     */
    public void setRun(int run) {
        try {
            if(run>=1 && run<99999999){
                System.out.println("run guardado.");
                this.run =run;
            }else{
                System.out.println("ERROR: run no valido");
                System.out.println("ingrese un rut valido");
                Scanner leerRun = new Scanner(System.in);
                int nuevoRun = leerRun.nextInt();
               
                if(nuevoRun>=1 && nuevoRun<=99999999){
                    System.out.println("rut guardado");
                    this.run = nuevoRun;
                }else{
                    this.setRun(run);
                }       
            }
        } catch (Exception e) {
            System.out.println("Error no identificado");
        }
    }

    /**
     * @return the dv
     */
    public char getDv() {
        return dv;
    }

    /**
     * @param dv the dv to set
     */
    public void setDv(char dv) {
        try {
            if(dv=='0'|| dv=='1'|| dv=='2' || dv=='3' || dv=='4' || dv=='5' || dv=='6' || dv=='7' || dv=='8'|| dv=='9'|| dv=='k' || dv=='K'){
                System.out.println("DV guardado.");
                this.dv = dv;
            }else{
                System.out.println("ERROR: DV no valido");
                System.out.println("ingrese DV valido");
                Scanner LeerDV = new Scanner (System.in);
                char nuevoDV = LeerDV.nextLine().charAt(0);
                if(nuevoDV=='0'  || nuevoDV=='1' || nuevoDV=='2' || nuevoDV=='3' || nuevoDV=='4' || nuevoDV=='5' || nuevoDV=='6' ||
                   nuevoDV=='7'  || nuevoDV=='8' || nuevoDV=='9' || nuevoDV=='k' || nuevoDV=='K'){
                    System.out.println("DV guardado");
                    this.dv = nuevoDV;
                }else{
                    this.setDv(dv);
                }
            }
        } catch (Exception e) {
            System.out.println("ERROR! error no entendido.");
        }
    }
}


    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
