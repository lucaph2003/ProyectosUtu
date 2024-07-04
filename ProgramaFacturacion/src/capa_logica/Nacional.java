package capa_logica;

public class Nacional extends Articulo{
    
    private String departamento;
    private boolean subsidiado;
    
    public Nacional(String unNombrearticulo, double unCosto, int unaUnidades, int unCodigo, String unDepartamento, boolean unSubsidiado){
        this.setdepartamento(unDepartamento);
        this.setsubsidiado(unSubsidiado);
        this.setnombrearticulo(unNombrearticulo);
        this.setprecioCosto(unCosto);
        this.setunidades(unaUnidades);
        this.setcodigo(unCodigo);
    }
    
    public Nacional(){
        this.setdepartamento("sin determinar");
        this.setsubsidiado(true);
    }
    
    public void setdepartamento(String unDepartamento){
        departamento=unDepartamento;
    }
     
    public void setsubsidiado(boolean unSubsidiado){
        subsidiado=unSubsidiado;
    }
      
    public String departamento (){
        return departamento;
    }
    
    public boolean subsidiado (){
        return subsidiado;
    }
       
    @Override
    public double precioVenta()
    {
        double venta = super.precioVenta();
        if(this.subsidiado() == false) {
            if(this.departamento.equals("Montevideo"))
            {
                venta = venta * 1.15;
            }
            else{
                venta = venta * 1.10;
            }
        }
        return venta;
    }
}
