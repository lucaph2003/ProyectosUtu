package capa_logica;

import static javafx.scene.input.KeyCode.N;

public class Empleado extends Persona {
    
    private Fecha antiguedad;
    private int categoria;
    
    public Empleado (String unApellido,String unci, String unNom,Fecha unAntiguedad,int unaCategoria){
        this.setantiguedad(unAntiguedad);
        this.setcategoria(unaCategoria);
        this.setApe(unApellido);
        this.setci(unci);
        this.setNom(unNom);
    }
    
    public void setantiguedad(Fecha unAntiguedad){
        antiguedad=unAntiguedad;
    }
     
    public void setcategoria(int unaCategoria){
        categoria=unaCategoria;
    }
    
     public Fecha getantiguedad(){
        return antiguedad;
    }
     
      public int getcategoria(){
        return categoria;
    }
    
    public String toString() {
        String nombrecat = "";
       switch(categoria){
           case 0:
               nombrecat="Jefe de vendedores";
               break;
               
           case 1:
               nombrecat="Vendedor senior";
               break;
               
           case 2:
               nombrecat="Vendedor junior";
               break;
               
           case 3:
               nombrecat="Cadete";
               break;
       }
        
        return " Nombre: "+super.getNom()+ 
                "\n"+" Apellido: " + super.getApe()+ 
                "\n"+" CI: "+super.getci()+ 
                "\n"+" Antiguedad: "+ antiguedad + 
                "\n"+" Categoria: " + nombrecat;
    }  
}

    
