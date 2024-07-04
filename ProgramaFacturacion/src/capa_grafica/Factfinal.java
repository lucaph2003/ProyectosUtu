package capa_grafica;

import capa_logica.*;
import javax.swing.table.DefaultTableModel;

public class Factfinal extends javax.swing.JFrame {

       public Factfinal(Empleado pVendedor,Fecha pActual,Cliente pComprador,Producto pCarrito) {
        initComponents();
        setLocationRelativeTo(null);
        
        this.TxtEmpleado.setText("Vendedor: " +"\n"+ pVendedor.toString());
        
        this.LblFecha.setText("Fecha de realizacion: "+pActual.toString());
        
        this.TxtCliente.setText("Cliente: "+ "\n" + pComprador.toString());
      
        Factura venta1 = new Factura(pCarrito, pActual, pVendedor, pComprador);
        
        this.Lblsubtotal.setText("Sub total: $"+venta1.subTotal() + "");
        
        
        this.LblIva.setText("IVA: $"+venta1.impuestoIva()+ "");
        
        
        this.Lbltotal.setText("Total: $"+venta1.totalVenta()+ "");
        
        for(Articulo art:pCarrito.getLista()){
            DefaultTableModel model = (DefaultTableModel) jTable1.getModel();

            Object[] data = new Object[4];
            data[0] = art.getcodigo();
            data[1] = art.getnombrearticulo();
            data[2] = art.precioVenta();
            data[3] = art.getunidades();
            model.addRow(data);
        }
        
        
        // this.Lblsubtotal.setText();
        
        
    }
   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        jPanel1 = new javax.swing.JPanel();
        LblFecha = new javax.swing.JLabel();
        LblTitulo = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        Lblsubtotal = new javax.swing.JLabel();
        LblIva = new javax.swing.JLabel();
        Lbltotal = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        TxtEmpleado = new javax.swing.JTextArea();
        jScrollPane3 = new javax.swing.JScrollPane();
        TxtCliente = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Tienda");
        setAlwaysOnTop(true);
        setResizable(false);

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));

        LblTitulo.setFont(new java.awt.Font("Impact", 0, 48)); // NOI18N
        LblTitulo.setText("Freshop");

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Código", "Nombre", "Precio", "Cantidad"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane2.setViewportView(jTable1);

        jLabel1.setFont(new java.awt.Font("Gadugi", 1, 14)); // NOI18N
        jLabel1.setText("Consumo final");

        Lblsubtotal.setFont(new java.awt.Font("Adobe Garamond Pro Bold", 0, 36)); // NOI18N
        Lblsubtotal.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        LblIva.setFont(new java.awt.Font("Adobe Garamond Pro Bold", 0, 36)); // NOI18N
        LblIva.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        Lbltotal.setFont(new java.awt.Font("Adobe Garamond Pro Bold", 0, 36)); // NOI18N
        Lbltotal.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        TxtEmpleado.setEditable(false);
        TxtEmpleado.setBackground(new java.awt.Color(204, 204, 204));
        TxtEmpleado.setColumns(20);
        TxtEmpleado.setRows(6);
        jScrollPane1.setViewportView(TxtEmpleado);

        TxtCliente.setEditable(false);
        TxtCliente.setBackground(new java.awt.Color(204, 204, 204));
        TxtCliente.setColumns(20);
        TxtCliente.setRows(5);
        jScrollPane3.setViewportView(TxtCliente);

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(183, 183, 183)
                .addComponent(jLabel1)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(LblFecha, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(131, 131, 131))
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 460, Short.MAX_VALUE)
                    .addComponent(jScrollPane1)
                    .addComponent(jScrollPane3)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(149, 149, 149)
                        .addComponent(LblTitulo))
                    .addComponent(LblIva, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Lblsubtotal, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Lbltotal, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap(12, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(13, 13, 13)
                .addComponent(LblTitulo)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(LblFecha, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 154, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Lblsubtotal, javax.swing.GroupLayout.PREFERRED_SIZE, 53, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(LblIva, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Lbltotal, javax.swing.GroupLayout.PREFERRED_SIZE, 54, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel LblFecha;
    private javax.swing.JLabel LblIva;
    private javax.swing.JLabel LblTitulo;
    private javax.swing.JLabel Lblsubtotal;
    private javax.swing.JLabel Lbltotal;
    private javax.swing.JTextArea TxtCliente;
    private javax.swing.JTextArea TxtEmpleado;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JTable jTable1;
    // End of variables declaration//GEN-END:variables
}
