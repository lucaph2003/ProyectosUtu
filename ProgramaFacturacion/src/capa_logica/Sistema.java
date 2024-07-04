package capa_logica;

import java.util.ArrayList;

public class Sistema {
    
    Producto stock;
    
    public Sistema() 
    {
        stock = new Producto();
        
        //Nacionales
        Nacional nacional1 = new Nacional("Microondas", 10000.00, 7, 3392, "Canelones", true);
        stock.insertar(nacional1);
        
        Nacional nacional2 = new Nacional("Heladera", 1800.0, 15, 3312, "Montevideo", false);
        stock.insertar(nacional2);
        
        Nacional nacional3 = new Nacional("Silla", 500.00, 32, 1392, "Soriano", false);
        stock.insertar(nacional3);
        
        Nacional nacional4 = new Nacional("Mesa", 1500.00, 14, 6452, "Montevideo", false);
        stock.insertar(nacional4);
        
        Nacional nacional5 = new Nacional("Horno", 16500.00, 9, 3562, "Canelones", true);
        stock.insertar(nacional5);
        
        //Importados
        Importado importado1 = new Importado("Batidora", 5000.00, 15, 9854, 2008, 10);
        stock.insertar(importado1);
        
        Importado importado2 = new Importado("Tostador", 2500.00, 2, 5482, 2010, 5);
        stock.insertar(importado2);
        
        Importado importado3 = new Importado("Licuadora", 2000.00, 10, 3846, 2005, 5);
        stock.insertar(importado3);
        
        Importado importado4 = new Importado("Freidora", 6500.00, 9, 3697, 2016, 10);
        stock.insertar(importado4);
        
        Importado importado5 = new Importado("Aspiradora", 7500.00, 5, 9423, 2018, 5);
        stock.insertar(importado5);
        
        
    }
    
    public Producto getProducto()
    {
        return this.stock;
    }        
   
}