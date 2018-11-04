/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Vista;
import javax.swing.JOptionPane;
import LogicaNegocio.ProveedorBL;
import java.util.ArrayList;
import javax.swing.table.DefaultTableModel;
import modelo.Proveedor;
/**
 *
 * @author a20141056
 */
public class ModProveedorForm extends javax.swing.JDialog {

    private ArrayList<Proveedor> proveedores;
    /**
     * Creates new form ModProveedorForm
     */
    public ModProveedorForm(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        ProveedorBL proveedorBL = new ProveedorBL();
        proveedores = new ArrayList<Proveedor>();
        proveedores = proveedorBL.listarProveedores();
        Object[] fila = new Object[1];
        DefaultTableModel modelo = (DefaultTableModel)tblProveedores.getModel();
        int cant = proveedores.size();
        int i;
        for(i = 0; i<cant; i++){
            fila[0] = proveedores.get(i).getRazon_socual();
            modelo.addRow(fila);
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lblRUC = new javax.swing.JLabel();
        txtRUC = new javax.swing.JTextField();
        lblUsersSystem = new javax.swing.JLabel();
        lblTelefono = new javax.swing.JLabel();
        btnModificar = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        tblProveedores = new javax.swing.JTable();
        lblRazon = new javax.swing.JLabel();
        lblCorreo = new javax.swing.JLabel();
        btnCancelar = new javax.swing.JButton();
        txtRazon = new javax.swing.JTextField();
        txtCorreo = new javax.swing.JTextField();
        txtTelefono = new javax.swing.JTextField();
        pnlTop = new javax.swing.JPanel();
        lblTextLogin = new javax.swing.JLabel();
        btnEliminar = new javax.swing.JButton();
        lblDireccion = new javax.swing.JLabel();
        txtDireccion = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);

        lblRUC.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblRUC.setText("RUC:");

        txtRUC.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtRUC.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtRUC.setEnabled(false);

        lblUsersSystem.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lblUsersSystem.setText("Lista Proveedores");

        lblTelefono.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblTelefono.setText("Teléfono:");

        btnModificar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnModificar.setText("Modificar");
        btnModificar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnModificarActionPerformed(evt);
            }
        });

        tblProveedores.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Proveedores"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        tblProveedores.getTableHeader().setReorderingAllowed(false);
        tblProveedores.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblProveedoresMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(tblProveedores);

        lblRazon.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblRazon.setText("Razón Social:");

        lblCorreo.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblCorreo.setText("Correo:");

        btnCancelar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnCancelar.setText("Cancelar");
        btnCancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCancelarActionPerformed(evt);
            }
        });

        txtRazon.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtRazon.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtRazon.setEnabled(false);

        txtCorreo.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtCorreo.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtCorreo.setEnabled(false);

        txtTelefono.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtTelefono.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtTelefono.setEnabled(false);
        txtTelefono.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtTelefonoKeyTyped(evt);
            }
        });

        pnlTop.setBackground(new java.awt.Color(1, 50, 67));

        lblTextLogin.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        lblTextLogin.setForeground(new java.awt.Color(255, 255, 255));
        lblTextLogin.setText("Modificar Proveedor");

        javax.swing.GroupLayout pnlTopLayout = new javax.swing.GroupLayout(pnlTop);
        pnlTop.setLayout(pnlTopLayout);
        pnlTopLayout.setHorizontalGroup(
            pnlTopLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlTopLayout.createSequentialGroup()
                .addGap(36, 36, 36)
                .addComponent(lblTextLogin)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnlTopLayout.setVerticalGroup(
            pnlTopLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlTopLayout.createSequentialGroup()
                .addGap(22, 22, 22)
                .addComponent(lblTextLogin)
                .addContainerGap(28, Short.MAX_VALUE))
        );

        btnEliminar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnEliminar.setText("Eliminar");
        btnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarActionPerformed(evt);
            }
        });

        lblDireccion.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblDireccion.setText("Dirección:");

        txtDireccion.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtDireccion.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtDireccion.setEnabled(false);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(36, 36, 36)
                        .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(34, 34, 34)
                        .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(90, 90, 90)
                                .addComponent(lblUsersSystem))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(39, 39, 39)
                                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 222, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 24, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblRUC)
                                    .addComponent(lblRazon)
                                    .addComponent(lblCorreo)
                                    .addComponent(lblTelefono))
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(22, 22, 22)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(txtRUC, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(txtRazon, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(txtCorreo, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(txtDireccion, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(txtTelefono, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE))))
                            .addComponent(lblDireccion))))
                .addContainerGap(28, Short.MAX_VALUE))
            .addComponent(pnlTop, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(pnlTop, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(lblUsersSystem, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(15, 15, 15)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblRUC)
                            .addComponent(txtRUC, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblRazon)
                            .addComponent(txtRazon, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblCorreo)
                            .addComponent(txtCorreo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblDireccion)
                            .addComponent(txtDireccion, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(21, 21, 21)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblTelefono)
                            .addComponent(txtTelefono, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 229, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(23, Short.MAX_VALUE))
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnModificarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnModificarActionPerformed
        String ruc = txtRUC.getText();
        if(ruc.length() != 11 || ruc.length() == 0){
            JOptionPane.showMessageDialog(this,"RUC inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String razon = txtRazon.getText();
        if(razon.length() == 0){
            JOptionPane.showMessageDialog(this,"Razon Social inválida", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String correo = txtCorreo.getText();
        if(!correo.contains("@") || !correo.contains(".") || correo.length() == 0){
            JOptionPane.showMessageDialog(this,"Correo inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String direccion = txtDireccion.getText();
        if(direccion.length() == 0){
            JOptionPane.showMessageDialog(this,"Dirección inválida", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String telefono = txtTelefono.getText();
        if(telefono.length() > 9){
            JOptionPane.showMessageDialog(this,"Número telefónico inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        int cant = proveedores.size();
        long numprov=0;
        for(int i = 0; i<cant; i++){
            if(proveedores.get(i).getRazon_socual().equals(razon)){
                numprov = proveedores.get(i).getId_proveedor();
            }
        }
        Proveedor prov = new Proveedor(numprov,ruc,razon,correo,direccion,telefono);
        ProveedorBL proveedorBL = new ProveedorBL();
        proveedorBL.modificarProveedor(prov);
        
        JOptionPane.showMessageDialog(this,"Proveedor Modificado.", "Confirmación",
            JOptionPane.INFORMATION_MESSAGE);
        this.dispose();
    }//GEN-LAST:event_btnModificarActionPerformed

    private void btnCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCancelarActionPerformed
        this.dispose();
    }//GEN-LAST:event_btnCancelarActionPerformed

    private void tblProveedoresMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblProveedoresMouseClicked
        txtCorreo.setEnabled(true);
        txtRUC.setEnabled(true);
        txtRazon.setEnabled(true);
        txtDireccion.setEnabled(true);
        txtTelefono.setEnabled(true);
        int cant = proveedores.size();
        int row = tblProveedores.getSelectedRow();
        int col = tblProveedores.getSelectedColumn();
        
        String razon = tblProveedores.getValueAt(row, col).toString();
        int index = 0;
        for(int i = 0; i<cant; i++){
            if(proveedores.get(i).getRazon_socual().equals(razon)){
                index = i;
            }
        }
        txtCorreo.setText(proveedores.get(index).getEmail());
        txtRUC.setText(proveedores.get(index).getRUC());
        txtRazon.setText(proveedores.get(index).getRazon_socual());
        txtDireccion.setText(proveedores.get(index).getDireccion());
        txtTelefono.setText(proveedores.get(index).getTelefono());
    }//GEN-LAST:event_tblProveedoresMouseClicked

    private void btnEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarActionPerformed
        String ruc = txtRUC.getText();
        String correo = txtCorreo.getText();
        String razon = txtRazon.getText();
        String direccion = txtDireccion.getText();
        String telefono = txtTelefono.getText();
        int cant = proveedores.size();
        long numprov=0;
        for(int i = 0; i<cant; i++){
            if(proveedores.get(i).getRazon_socual().equals(razon)){
                numprov = proveedores.get(i).getId_proveedor();
            }
        }
        Proveedor prov = new Proveedor(numprov,ruc,razon,correo,direccion,telefono);
        ProveedorBL proveedorBL = new ProveedorBL();
        proveedorBL.eliminarProveedor(prov);
        
        JOptionPane.showMessageDialog(this,"Proveedor Eliminado.", "Confirmación",
            JOptionPane.INFORMATION_MESSAGE);
        this.dispose();
    }//GEN-LAST:event_btnEliminarActionPerformed

    private void txtTelefonoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTelefonoKeyTyped
        char c = evt.getKeyChar();
        if(!(Character.isDigit(c))){
            evt.consume();
        }
    }//GEN-LAST:event_txtTelefonoKeyTyped

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(ModProveedorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ModProveedorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ModProveedorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ModProveedorForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                ModProveedorForm dialog = new ModProveedorForm(new javax.swing.JFrame(), true);
                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                    @Override
                    public void windowClosing(java.awt.event.WindowEvent e) {
                        System.exit(0);
                    }
                });
                dialog.setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCancelar;
    private javax.swing.JButton btnEliminar;
    private javax.swing.JButton btnModificar;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JLabel lblCorreo;
    private javax.swing.JLabel lblDireccion;
    private javax.swing.JLabel lblRUC;
    private javax.swing.JLabel lblRazon;
    private javax.swing.JLabel lblTelefono;
    private javax.swing.JLabel lblTextLogin;
    private javax.swing.JLabel lblUsersSystem;
    private javax.swing.JPanel pnlTop;
    private javax.swing.JTable tblProveedores;
    private javax.swing.JTextField txtCorreo;
    private javax.swing.JTextField txtDireccion;
    private javax.swing.JTextField txtRUC;
    private javax.swing.JTextField txtRazon;
    private javax.swing.JTextField txtTelefono;
    // End of variables declaration//GEN-END:variables
}
