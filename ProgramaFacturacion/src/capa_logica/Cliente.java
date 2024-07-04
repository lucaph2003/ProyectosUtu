package capa_logica;


public class Cliente extends Persona{
    
    private boolean preferencial;
    
    public Cliente (String unApellido,String unci, String unNom,boolean unPreferencial){
        this.setpreferencial(unPreferencial);
        this.setApe(unApellido);
        this.setci(unci);
        this.setNom(unNom);
    }
      
    public void setpreferencial(boolean unPreferencial){
        preferencial=unPreferencial;
    }
    
    public boolean getpreferencial(){
        return preferencial;
    }
    
    public String toString() {
        String preferencial = "Preferencial: No";
        if (getpreferencial())
        {
            preferencial = "Preferencial: Si";
        } 
        return " Nombre: "+super.getNom()+
                "\n " + "Apellido: "+ super.getApe() +
                "\n " + "CI: "+super.getci() +
                "\n " + preferencial;
    } 
}
