package capa_logica;

import java.util.ArrayList;

public class Producto {
    
    public ArrayList<Articulo> lista = new ArrayList<Articulo>();
    
    public ArrayList<Articulo> getLista()
    {
        return this.lista;
    }        
    
    public Articulo buscar(int codigo){
        Articulo a = new Articulo();
        for(Articulo actual:lista){
            if (actual.getcodigo() == codigo){
               a = actual;
            }
        }
        return a;
    }
    
    public void insertar(Articulo a){
        lista.add(a);
    }
    
    public void eliminar(Articulo a){
        lista.remove(a);
    }
    
}
