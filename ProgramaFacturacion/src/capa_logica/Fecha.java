package capa_logica;

public class Fecha {

    private int mes,dia ,anio;
    
    public Fecha(int unmes,int undia,int unanio){
        this.setmes(unmes);
        this.setdia(undia);
        this.setanio(unanio);
    }
    
    public Fecha(){
        this.setmes(0);
        this.setdia(0);
        this.setanio(0);
    }
   
    
    public void setmes(int unmes){
        mes = unmes;
    }
    
     public void setdia(int undia){
        dia = undia;
    }
     
      public void setanio(int unanio){
        anio = unanio;
    }
     
    public int getmes(){
        return mes;
               
    }
    
     public int getdia(){
        return dia;
               
    }
     
     public int getanio(){
        return anio;
               
    }
     
     public String toString() {
        return dia+"/" + mes + "/" +anio ;
    } 
     
}
