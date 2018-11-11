/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Vista;
import javax.swing.JOptionPane;
import modelo.Usuario;
import LogicaNegocio.UsuarioBL;
import java.util.ArrayList;
import javax.swing.table.DefaultTableModel;
import modelo.Gerente;
import modelo.Operario;
/**
 *
 * @author alulab14
 */
public class ModAccountForm extends javax.swing.JDialog {

    /**
     * Creates new form ModAccountForm
     */
    private ArrayList<Usuario> usuarios;
    
    public ModAccountForm(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        UsuarioBL usuarioBL = new UsuarioBL();
        usuarios = new ArrayList<Usuario>();
        usuarios = usuarioBL.listarUsuarios();
        Object[] fila = new Object[1];
        DefaultTableModel modelo = (DefaultTableModel)tblUsers.getModel();
        int cant = usuarios.size();
        int i;
        for(i = 0; i<cant; i++){
            if(!usuarios.get(i).getDescripcion_permisos().equals("ADMINISTRADOR DE SISTEMAS")){
                fila[0] = usuarios.get(i).getUsername();
                modelo.addRow(fila);
            }
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

        lblName = new javax.swing.JLabel();
        btnModificar = new javax.swing.JButton();
        lblPass = new javax.swing.JLabel();
        lblPerm = new javax.swing.JLabel();
        btnCancelar = new javax.swing.JButton();
        lblApellidos = new javax.swing.JLabel();
        txtName = new javax.swing.JTextField();
        txtUser = new javax.swing.JTextField();
        txtPass = new javax.swing.JTextField();
        lblUsersSystem = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        tblUsers = new javax.swing.JTable();
        pnlTop = new javax.swing.JPanel();
        lblTextLogin = new javax.swing.JLabel();
        lblMail = new javax.swing.JLabel();
        lblDni = new javax.swing.JLabel();
        lblUser = new javax.swing.JLabel();
        txtApellidos = new javax.swing.JTextField();
        txtCorreo = new javax.swing.JTextField();
        txtDni = new javax.swing.JTextField();
        cmbTipo = new javax.swing.JComboBox<>();
        lblPuesto = new javax.swing.JLabel();
        txtPuesto = new javax.swing.JTextField();
        cbTipo = new java.awt.Checkbox();
        btnEliminar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);

        lblName.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblName.setText("Nombre:");

        btnModificar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnModificar.setText("Modificar");
        btnModificar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnModificarActionPerformed(evt);
            }
        });

        lblPass.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblPass.setText("Contraseña:");

        lblPerm.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblPerm.setText("Tipo de Usuario:");

        btnCancelar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnCancelar.setText("Cancelar");
        btnCancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCancelarActionPerformed(evt);
            }
        });

        lblApellidos.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblApellidos.setText("Apellidos:");

        txtName.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtName.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtName.setEnabled(false);

        txtUser.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtUser.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtUser.setEnabled(false);

        txtPass.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtPass.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtPass.setEnabled(false);

        lblUsersSystem.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lblUsersSystem.setText("Usuarios del Sistema");

        tblUsers.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Usuarios del Sistema"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        tblUsers.getTableHeader().setReorderingAllowed(false);
        tblUsers.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblUsersMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(tblUsers);

        pnlTop.setBackground(new java.awt.Color(1, 50, 67));

        lblTextLogin.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        lblTextLogin.setForeground(new java.awt.Color(255, 255, 255));
        lblTextLogin.setText("Modificar Cuenta");

        javax.swing.GroupLayout pnlTopLayout = new javax.swing.GroupLayout(pnlTop);
        pnlTop.setLayout(pnlTopLayout);
        pnlTopLayout.setHorizontalGroup(
            pnlTopLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlTopLayout.createSequentialGroup()
                .addGap(56, 56, 56)
                .addComponent(lblTextLogin)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnlTopLayout.setVerticalGroup(
            pnlTopLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlTopLayout.createSequentialGroup()
                .addGap(34, 34, 34)
                .addComponent(lblTextLogin)
                .addContainerGap(37, Short.MAX_VALUE))
        );

        lblMail.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblMail.setText("Correo:");

        lblDni.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblDni.setText("DNI:");

        lblUser.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblUser.setText("Usuario:");

        txtApellidos.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtApellidos.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtApellidos.setEnabled(false);

        txtCorreo.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtCorreo.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtCorreo.setEnabled(false);

        txtDni.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtDni.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtDni.setEnabled(false);
        txtDni.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtDniKeyTyped(evt);
            }
        });

        cmbTipo.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Gerente", "Operario", "Jefe de Almacén" }));
        cmbTipo.setEnabled(false);

        lblPuesto.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblPuesto.setText("Puesto:");

        txtPuesto.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtPuesto.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtPuesto.setEnabled(false);

        cbTipo.setEnabled(false);
        cbTipo.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cbTipoItemStateChanged(evt);
            }
        });

        btnEliminar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnEliminar.setText("Eliminar");
        btnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(35, 35, 35)
                .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(31, 31, 31)
                .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(34, 34, 34))
            .addComponent(pnlTop, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(45, 45, 45)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 272, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(87, 87, 87)
                        .addComponent(lblUsersSystem)))
                .addGap(41, 41, 41)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblMail)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(lblDni)
                            .addComponent(lblUser)
                            .addComponent(lblPass)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addComponent(txtCorreo, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(txtDni, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(txtUser, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(lblApellidos)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(txtApellidos, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(lblName)
                                        .addGap(69, 69, 69)
                                        .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addComponent(txtPass, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblPerm)
                                    .addComponent(lblPuesto))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(txtPuesto, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(cmbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 200, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(19, 19, 19)
                                        .addComponent(cbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                        .addContainerGap(132, Short.MAX_VALUE))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(pnlTop, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblName)
                            .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(lblUsersSystem, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtApellidos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblApellidos))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblMail)
                            .addComponent(txtCorreo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtDni, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblDni))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtUser, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblUser))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblPass)
                            .addComponent(txtPass, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtPuesto, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblPuesto))
                        .addGap(26, 26, 26)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(cbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                .addComponent(lblPerm)
                                .addComponent(cmbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 331, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 23, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(24, 24, 24))
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnModificarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnModificarActionPerformed
        
        Usuario user = null;
        String nombre = txtName.getText();
        if(nombre.length() == 0){
            JOptionPane.showMessageDialog(this,"Nombre inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String apellido = txtApellidos.getText();
        if(apellido.length() == 0){
            JOptionPane.showMessageDialog(this,"Apellido inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String correo = txtCorreo.getText();
        if(!correo.contains("@") || !correo.contains(".") || correo.length() == 0){
            JOptionPane.showMessageDialog(this,"Correo inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String dni = txtDni.getText();
        if(dni.length() != 8){
            JOptionPane.showMessageDialog(this,"DNI inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String username = txtUser.getText();
        if(username.length() == 0){
            JOptionPane.showMessageDialog(this,"Usuario inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        String pass = txtPass.getText();
        if(pass.length() == 0){
            JOptionPane.showMessageDialog(this,"Contraseña inválido", "Alerta",
            JOptionPane.ERROR_MESSAGE);
            return;
        }
        int index = cmbTipo.getSelectedIndex();
        int cant = usuarios.size();
        long numuser = 0;
        for(int i = 0; i<cant; i++){
            if(usuarios.get(i).getUsername().equals(username)){
                numuser = usuarios.get(i).getId_usuario();
            }
        }

        if(index == 0){
            String tipo = "GERENTE";
            user = new Gerente(numuser,nombre,apellido,correo,dni,username,pass,tipo);
        }else if(index == 1){
            String tipo = "OPERARIO";
            user = new Operario(numuser,nombre,apellido,correo,dni,username,pass,tipo);
        }else{
            String tipo = "JEFE DE ALMACEN";
            user = new Operario(numuser,nombre,apellido,correo,dni,username,pass,tipo);
        }
        
        UsuarioBL usuarioBL = new UsuarioBL();
        usuarioBL.modificarUsuario(user);
        
        JOptionPane.showMessageDialog(this,"Cuenta Modificada.", "Confirmación",
            JOptionPane.INFORMATION_MESSAGE);
        this.dispose();
    }//GEN-LAST:event_btnModificarActionPerformed

    private void btnCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCancelarActionPerformed
        this.dispose();
    }//GEN-LAST:event_btnCancelarActionPerformed

    private void tblUsersMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblUsersMouseClicked
        txtApellidos.setEnabled(true);
        txtCorreo.setEnabled(true);
        txtDni.setEnabled(true);
        txtName.setEnabled(true);
        txtPass.setEnabled(true);
        txtUser.setEnabled(true);
        txtPuesto.setEnabled(true);
        cbTipo.setEnabled(true);
        int cant = usuarios.size();
        int row = tblUsers.getSelectedRow();
        int col = tblUsers.getSelectedColumn();
        
        String username = tblUsers.getValueAt(row, col).toString();
        int index = 0;
        for(int i = 0; i<cant;i++){
            if(usuarios.get(i).getUsername().equals(username)){
                index = i;
            }
        }
        if(cbTipo.getState()){
            cmbTipo.setEnabled(true);
        }
        txtApellidos.setText(usuarios.get(index).getApellidos());
        txtCorreo.setText(usuarios.get(index).getCorreo());
        txtDni.setText(usuarios.get(index).getDni());
        txtName.setText(usuarios.get(index).getNombre());
        txtPass.setText(usuarios.get(index).getContrasena());
        txtUser.setText(username);
        txtPuesto.setText(usuarios.get(index).getDescripcion_permisos());
        
        
    }//GEN-LAST:event_tblUsersMouseClicked

    private void cbTipoItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cbTipoItemStateChanged
        if(evt.getStateChange() == java.awt.event.ItemEvent.SELECTED){
            cmbTipo.setEnabled(true);
        }else{
            cmbTipo.setEnabled(false);
        }
    }//GEN-LAST:event_cbTipoItemStateChanged

    private void btnEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarActionPerformed
        Usuario user = null;
        String nombre = txtName.getText();
        String apellido = txtApellidos.getText();
        String correo = txtCorreo.getText();
        String dni = txtDni.getText();
        String username = txtUser.getText();
        String pass = txtPass.getText();
        int index = cmbTipo.getSelectedIndex();
        int cant = usuarios.size();
        long numuser = 0;
        for(int i = 0; i<cant; i++){
            if(usuarios.get(i).getUsername().equals(username)){
                numuser = usuarios.get(i).getId_usuario();
            }
        }

        if(index == 0){
            String tipo = "GERENTE";
            user = new Gerente(numuser,nombre,apellido,correo,dni,username,pass,tipo);
        }else if(index == 1){
            String tipo = "OPERARIO";
            user = new Operario(numuser,nombre,apellido,correo,dni,username,pass,tipo);
        }else{
            String tipo = "JEFE DE ALMACEN";
            user = new Operario(numuser,nombre,apellido,correo,dni,username,pass,tipo);
        }
        
        UsuarioBL usuarioBL = new UsuarioBL();
        usuarioBL.eliminarUsuario(user);
        
        JOptionPane.showMessageDialog(this,"Cuenta Eliminada.", "Confirmación",
            JOptionPane.INFORMATION_MESSAGE);
        this.dispose();
    }//GEN-LAST:event_btnEliminarActionPerformed

    private void txtDniKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtDniKeyTyped
        char c = evt.getKeyChar();
        if(!(Character.isDigit(c))){
            evt.consume();
        }
    }//GEN-LAST:event_txtDniKeyTyped

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
            java.util.logging.Logger.getLogger(ModAccountForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ModAccountForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ModAccountForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ModAccountForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                ModAccountForm dialog = new ModAccountForm(new javax.swing.JFrame(), true);
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
    private java.awt.Checkbox cbTipo;
    private javax.swing.JComboBox<String> cmbTipo;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JLabel lblApellidos;
    private javax.swing.JLabel lblDni;
    private javax.swing.JLabel lblMail;
    private javax.swing.JLabel lblName;
    private javax.swing.JLabel lblPass;
    private javax.swing.JLabel lblPerm;
    private javax.swing.JLabel lblPuesto;
    private javax.swing.JLabel lblTextLogin;
    private javax.swing.JLabel lblUser;
    private javax.swing.JLabel lblUsersSystem;
    private javax.swing.JPanel pnlTop;
    private javax.swing.JTable tblUsers;
    private javax.swing.JTextField txtApellidos;
    private javax.swing.JTextField txtCorreo;
    private javax.swing.JTextField txtDni;
    private javax.swing.JTextField txtName;
    private javax.swing.JTextField txtPass;
    private javax.swing.JTextField txtPuesto;
    private javax.swing.JTextField txtUser;
    // End of variables declaration//GEN-END:variables
}
