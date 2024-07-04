package capa_logica;

public class Articulo {
    
    private int unidades,codigo;
    private double precioCosto ,precioventa;
    private String nombrearticulo;
    
    public Articulo(String unNombrearticulo,double unCosto,double unPrecioventa,int unaUnidades,int unCodigo){
        this.setnombrearticulo(unNombrearticulo);
        this.setprecioCosto(unCosto);
        this.setunidades(unaUnidades);
        this.setcodigo(unCodigo);
    }
    
    public Articulo(){
        this.setnombrearticulo("Sin definir");
        this.setprecioCosto(0.0);
        this.setunidades(0);
        this.setcodigo(0);        
    }
    
    public void setnombrearticulo(String unNombrearticulo){
        nombrearticulo=unNombrearticulo;
    }
    
    public void setprecioCosto(double unCosto){
        precioCosto=unCosto;
    }
    
    public void setunidades(int unaUnidades){
        unidades=unaUnidades;
    }
    
    public void setcodigo(int unCodigo){
        codigo=unCodigo;
    }
    
    public String getnombrearticulo(){
        return nombrearticulo;
    }
    
    public double getprecioCosto(){
        return precioCosto;
    }
    
    public int getunidades(){
        return unidades;
    }
    
    public int getcodigo(){
        return codigo;
    }
    
    public double precioVenta()
    {
        return precioCosto * 1.20; 
    }
    
}
