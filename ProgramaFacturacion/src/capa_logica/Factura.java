package capa_logica;

public class Factura {
    
    private Producto venta;
    private Fecha realizada;
    private Empleado vendedor;
    private Cliente comprador;
    private double subTotal;
     
     public Factura(Producto unVenta,Fecha unRealizada ,Empleado unVendedor,Cliente unComprador){
         this.setventa(unVenta);
         this.setrealizada(unRealizada);
         this.setvendedor(unVendedor);
         this.setcomprador(unComprador);
     }  
    
     public void setventa(Producto unVenta){
         venta=unVenta;
     }
     
     public void setrealizada(Fecha unRealizada){
         realizada=unRealizada;
     }
     
     public void setvendedor(Empleado unVendedor){
         vendedor=unVendedor;
     }
     
     public void setcomprador(Cliente unComprador){
         comprador=unComprador;
     }
     
     public Producto getventa(){
         return venta;
     }
     
      public Fecha getrealizada(){
         return realizada;
     }
      
       public Empleado getvendedor(){
         return vendedor;
     }
       
        public Cliente getcomprador(){
         return comprador;
     }
     
    public double impuestoIva()
    {
        return this.subTotal() * 0.22;
    }   
    
    public double subTotal()
    {
       double subtotal=0;
       for(Articulo actual:venta.getLista()){
           subtotal=subtotal+(actual.precioVenta()*actual.getunidades());
       }
       return subtotal;
    }
    
    public double totalVenta()
    {
        return this.subTotal() * 1.22;
    }
    
  
         public String toString() {
        return "El subtotal es: $"+subTotal;
    }
        
        
}
