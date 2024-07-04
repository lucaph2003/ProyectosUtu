package capa_grafica;

import javax.swing.ImageIcon;
import javax.swing.Icon;
import javax.swing.JButton;
import capa_logica.*;
import java.awt.Image;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
public class Articulos extends javax.swing.JFrame {
    public Articulos(Empleado pVendedor,Fecha pActual,Cliente pComprador) {
        initComponents();
        setLocationRelativeTo(null); 
        vendedor = pVendedor;
        Actual=pActual;
        comprador=pComprador;
        
        //Inicializa productos
        Sistema listaInicial = new Sistema();
        
        stock = listaInicial.getProducto();
        carrito = new Producto();
        
    }

    Empleado vendedor;
    Fecha Actual;
    Cliente comprador;
    Producto stock;
    Articulo articulo;
    Producto carrito;
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jList1 = new javax.swing.JList<String>();
        jPanel1 = new javax.swing.JPanel();
        jButton1 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        agcompra = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel2 = new javax.swing.JLabel();
        TxtCodigoProducto = new javax.swing.JTextField();
        jButton2 = new javax.swing.JButton();
        JLabelInfo = new javax.swing.JLabel();
        jCantidad = new javax.swing.JSpinner();
        jLabel3 = new javax.swing.JLabel();
        Txtalerta = new javax.swing.JLabel();
        papeleraBoton = new javax.swing.JButton();

        jList1.setModel(new javax.swing.AbstractListModel() {
            String[] strings = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            public int getSize() { return strings.length; }
            public Object getElementAt(int i) { return strings[i]; }
        });
        jScrollPane1.setViewportView(jList1);

        setTitle("Tienda");
        setUndecorated(true);
        setResizable(false);

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));

        jButton1.setBackground(new java.awt.Color(102, 102, 102));
        jButton1.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        jButton1.setForeground(new java.awt.Color(255, 255, 255));
        jButton1.setText("IR a Factura");
        jButton1.setToolTipText("Ir a Factura");
        jButton1.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jLabel1.setFont(new java.awt.Font("Impact", 0, 48)); // NOI18N
        jLabel1.setText("Ingreso de Productos");

        agcompra.setBackground(new java.awt.Color(255, 255, 255));
        agcompra.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        agcompra.setForeground(new java.awt.Color(255, 255, 255));
        agcompra.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Carrito.png"))); // NOI18N
        agcompra.setToolTipText("Agregar a carrito");
        agcompra.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        agcompra.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                agcompraActionPerformed(evt);
            }
        });

        jTable1.setBackground(new java.awt.Color(204, 204, 204));
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

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setText("Codigo del producto");

        TxtCodigoProducto.setToolTipText("#Codigo");
        TxtCodigoProducto.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        TxtCodigoProducto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                TxtCodigoProductoActionPerformed(evt);
            }
        });

        jButton2.setBackground(new java.awt.Color(255, 255, 255));
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Sin título-1.png"))); // NOI18N
        jButton2.setToolTipText("Buscar");
        jButton2.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        JLabelInfo.setFont(new java.awt.Font("Dialog", 1, 14)); // NOI18N
        JLabelInfo.setText("Producto:");

        jCantidad.setToolTipText("Cantidad");
        jCantidad.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setText("Cantidad:");

        Txtalerta.setBackground(new java.awt.Color(204, 204, 204));
        Txtalerta.setFont(new java.awt.Font("Dialog", 1, 10)); // NOI18N
        Txtalerta.setForeground(new java.awt.Color(255, 0, 0));

        papeleraBoton.setBackground(new java.awt.Color(255, 255, 255));
        papeleraBoton.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        papeleraBoton.setForeground(new java.awt.Color(255, 255, 255));
        papeleraBoton.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Papelera.jpg"))); // NOI18N
        papeleraBoton.setToolTipText("Eliminar");
        papeleraBoton.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        papeleraBoton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                papeleraBotonActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(31, 31, 31)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 465, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(51, 51, 51))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jButton1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 476, Short.MAX_VALUE)
                                .addGap(18, 18, 18)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(agcompra, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(papeleraBoton, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(JLabelInfo, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, jPanel1Layout.createSequentialGroup()
                                        .addComponent(Txtalerta, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addGap(18, 18, 18)
                                        .addComponent(jLabel3)
                                        .addGap(18, 18, 18)
                                        .addComponent(jCantidad, javax.swing.GroupLayout.PREFERRED_SIZE, 61, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addGap(15, 15, 15)))
                        .addContainerGap())
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(jLabel2)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(TxtCodigoProducto, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jButton2, javax.swing.GroupLayout.PREFERRED_SIZE, 24, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(22, 22, 22)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jButton2, javax.swing.GroupLayout.PREFERRED_SIZE, 24, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel2)
                        .addComponent(TxtCodigoProducto, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(16, 16, 16)
                .addComponent(JLabelInfo, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(Txtalerta, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel3)
                        .addComponent(jCantidad, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(agcompra, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 29, Short.MAX_VALUE)
                        .addComponent(papeleraBoton, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(18, 18, 18)
                .addComponent(jButton1)
                .addGap(42, 42, 42))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void agcompraActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_agcompraActionPerformed
        // TODO add your handling code here:
        //JFrame frameAgregarcarrito = new Agregarcarrito();
        //frameAgregarcarrito.show();
        if (articulo.getnombrearticulo() == "Sin definir")
        {
            JLabelInfo.setText("Debe buscar el artículo que desea agregar.");
            this.TxtCodigoProducto.setText("");
            this.TxtCodigoProducto.requestFocus();  
        }
        else
        {
            Integer cantidad = (Integer)jCantidad.getValue();
            if (cantidad > 0)
            {
                DefaultTableModel model = (DefaultTableModel) jTable1.getModel();
                
                Object[] data = new Object[4];
                data[0] = articulo.getcodigo();
                data[1] = articulo.getnombrearticulo();
                data[2] = articulo.precioVenta();
                data[3] = cantidad;
                model.addRow(data);
                
                articulo.setunidades(cantidad);
                
                carrito.insertar(articulo);
            }
            else
            {
                Txtalerta.setText("Debe ingresar un numero mayor a 0");
            }
            
        }   
    }//GEN-LAST:event_agcompraActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        JFrame frameFactfinal = new Factfinal(vendedor,Actual,comprador,carrito);
        frameFactfinal.show();
        this.hide();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // TODO add your handling code here:
        int codigo = Integer.parseInt(this.TxtCodigoProducto.getText());
        articulo = stock.buscar(codigo);
        if (articulo.getnombrearticulo() == "Sin definir")
        {
            JLabelInfo.setText("No se encontró ningún artículo con ese código.");
            this.TxtCodigoProducto.setText("");
            this.TxtCodigoProducto.requestFocus();    
        }
        else
        {
            JLabelInfo.setText(articulo.getnombrearticulo() + " Precio: " + articulo.precioVenta());
        }
    }//GEN-LAST:event_jButton2ActionPerformed

    private void papeleraBotonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_papeleraBotonActionPerformed
        // TODO add your handling code here:
        //        JFrame frameVenborr = new Venborr();
        //        frameVenborr.show();

        if(jTable1.getSelectedRow() >= 0)
        {
            if (jTable1.getValueAt(jTable1.getSelectedRow(), 0).toString().length() > 0) {
                int codigo = Integer.parseInt(jTable1.getValueAt(jTable1.getSelectedRow(), 0).toString());
                Articulo art = carrito.buscar(codigo);
                carrito.eliminar(art);
                DefaultTableModel model = (DefaultTableModel) jTable1.getModel();
                model.removeRow(jTable1.getSelectedRow());
            }
        }
        else
        {
            // Txtalerta.setText("Debe seleccionar el artículo que desea eliminar.");
            JOptionPane.showConfirmDialog(null, "Debe seleccionar el artículo que desea eliminar.", "Error", JOptionPane.DEFAULT_OPTION);
        }

    }//GEN-LAST:event_papeleraBotonActionPerformed

    private void TxtCodigoProductoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_TxtCodigoProductoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_TxtCodigoProductoActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel JLabelInfo;
    private javax.swing.JTextField TxtCodigoProducto;
    private javax.swing.JLabel Txtalerta;
    private javax.swing.JButton agcompra;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JSpinner jCantidad;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JList<String> jList1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTable jTable1;
    private javax.swing.JButton papeleraBoton;
    // End of variables declaration//GEN-END:variables

}
