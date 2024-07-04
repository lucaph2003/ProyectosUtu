package capa_logica;

public class Importado extends Articulo{
    
    private int anioimportado;
    private double impuesto;
    
    public Importado(String unNombrearticulo, double unCosto, int unaUnidades, int unCodigo, int unAnioimportado, double unImpuesto){
        this.setanioimportado(unAnioimportado);
        this.setimpuesto(unImpuesto);
        this.setnombrearticulo(unNombrearticulo);
        this.setprecioCosto(unCosto);
        this.setunidades(unaUnidades);
        this.setcodigo(unCodigo);
    }
    
    public Importado(){
        this.setanioimportado(0);
        this.setimpuesto(0.0);
    }
    
    public void setanioimportado(int unAnioimportado){
        anioimportado=unAnioimportado;
    }
    
    public void setimpuesto(double unImpuesto){
        impuesto=unImpuesto;
    }
    
    public int getanioimportado(){
        return anioimportado;
    }
            
    public double getimpuesto(){
        return impuesto;
    }        
    
    @Override
    public double precioVenta()
    {
        double venta = super.precioVenta();
        if (this.getanioimportado() <= 2008)
        {
            //80% del impuesto
            
            venta = venta * (((this.getimpuesto() * 0.8) / 100) + 1);
        }
        else
        {
            //100% del impuesto
            venta = venta * ((this.getimpuesto() / 100) + 1);
        }    
        return venta;
    }
    
}
