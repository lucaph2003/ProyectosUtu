package capa_logica;

public class Persona {
    
    private String Nom ,Ape,ci;
   
    public Persona(String unApellido,String unci, String unNom){
        this.setApe(unApellido);
         this.setci(unci);
         this.setNom(unNom);
    }
   
    public Persona(){
        this.setApe("Sin definir");
        this.setci("Sin definir");
        this.setNom("Sin definir");
    }
   
    
    public void setApe(String unApellido){
        Ape = unApellido;
    }
    
    
     public void setci(String unci){
        ci = unci;
    }
     
     public void setNom(String unNom){
        Nom = unNom;
    }
     
    public String getApe(){
        return Ape;
               
    }
    
     public String getci(){
        return ci;
               
    }
     
     public String getNom(){
        return Nom;
               
    }
    
     public String toString() {
        return "Nombre: " +Nom+" ,Apellido: " + Ape + " ,CI:" +ci ;
    } 
     
}
