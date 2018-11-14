package Vista;
import LogicaNegocio.AlmacenBL;
import LogicaNegocio.UsuarioBL;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import modelo.Almacen;
import modelo.Area;
import modelo.Operario;
import modelo.Usuario;
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author a20141056
 */
public class ModWrhouseForm extends javax.swing.JDialog {

    private ArrayList<Area> areas;
    private DefaultTableModel modelo;
    private DefaultTableModel modeloArea;
    private ArrayList<Usuario> usuarios;
    private ArrayList<Almacen> almacenes;
    private AlmacenBL almacenBL;
    private UsuarioBL usuarioBL;
    private String ger;
    private int index;

    public ModWrhouseForm(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        almacenBL = new AlmacenBL();
        usuarioBL = new UsuarioBL();
        usuarios = usuarioBL.listarUsuarios();
        almacenes = almacenBL.listarAlmacenes();
        modelo = (DefaultTableModel)tblAlmacen.getModel();
        Object[] fila = new Object[1];
        int cant = almacenes.size();
        for(int i = 0; i<cant; i++){
            fila[0] = almacenes.get(i).getNomAlmacen();
            modelo.addRow(fila);
        }
        modeloArea = (DefaultTableModel)tblAreas.getModel();
        
        
        
    }

    public ArrayList<Area> getAreas() {
        return areas;
    }

    public void setAreas(ArrayList<Area> areas) {
        this.areas = areas;
    }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lblAccount = new javax.swing.JLabel();
        txtName = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        txtDescripcion = new javax.swing.JTextArea();
        lblName = new javax.swing.JLabel();
        lblUsersSystem = new javax.swing.JLabel();
        btnModificar = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        tblAlmacen = new javax.swing.JTable();
        btnCancelar = new javax.swing.JButton();
        pnlTop = new javax.swing.JPanel();
        lblTextLogin = new javax.swing.JLabel();
        lblOperario = new javax.swing.JLabel();
        txtOperario = new javax.swing.JTextField();
        btnOperarios = new javax.swing.JButton();
        lblOperario1 = new javax.swing.JLabel();
        jScrollPane3 = new javax.swing.JScrollPane();
        tblAreas = new javax.swing.JTable();
        btnEditarArea = new javax.swing.JButton();
        btnEliminar = new javax.swing.JButton();
        lblTipo = new javax.swing.JLabel();
        cmbTipo = new javax.swing.JComboBox<>();
        cbTipo = new java.awt.Checkbox();
        lblTipoAlm = new javax.swing.JLabel();
        txtTipoAlmacen = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);

        lblAccount.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblAccount.setText("Descripción:");

        txtName.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtName.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtName.setEnabled(false);

        txtDescripcion.setColumns(20);
        txtDescripcion.setRows(5);
        txtDescripcion.setEnabled(false);
        jScrollPane1.setViewportView(txtDescripcion);

        lblName.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblName.setText("Nombre:");

        lblUsersSystem.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lblUsersSystem.setText("Lista de Almacenes");

        btnModificar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnModificar.setText("Modificar");
        btnModificar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnModificarActionPerformed(evt);
            }
        });

        tblAlmacen.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Almacenes"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        tblAlmacen.getTableHeader().setReorderingAllowed(false);
        tblAlmacen.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblAlmacenMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(tblAlmacen);

        btnCancelar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnCancelar.setText("Cancelar");
        btnCancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCancelarActionPerformed(evt);
            }
        });

        pnlTop.setBackground(new java.awt.Color(1, 50, 67));

        lblTextLogin.setFont(new java.awt.Font("Tahoma", 1, 24)); // NOI18N
        lblTextLogin.setForeground(new java.awt.Color(255, 255, 255));
        lblTextLogin.setText("Modificar Almacén");

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

        lblOperario.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblOperario.setText("Operario:");

        txtOperario.setEditable(false);
        txtOperario.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtOperario.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtOperario.setEnabled(false);

        btnOperarios.setText("...");
        btnOperarios.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOperariosActionPerformed(evt);
            }
        });

        lblOperario1.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblOperario1.setText("Áreas:");

        tblAreas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Áreas"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        tblAreas.getTableHeader().setReorderingAllowed(false);
        jScrollPane3.setViewportView(tblAreas);

        btnEditarArea.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        btnEditarArea.setText("Editar");
        btnEditarArea.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEditarAreaActionPerformed(evt);
            }
        });

        btnEliminar.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        btnEliminar.setText("Eliminar");
        btnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarActionPerformed(evt);
            }
        });

        lblTipo.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblTipo.setText("Tipos:");

        cmbTipo.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Almacén Virtual", "Almacén Principal" }));
        cmbTipo.setEnabled(false);

        cbTipo.setEnabled(false);
        cbTipo.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                cbTipoItemStateChanged(evt);
            }
        });

        lblTipoAlm.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblTipoAlm.setText("Tipo Almacen:");

        txtTipoAlmacen.setEditable(false);
        txtTipoAlmacen.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtTipoAlmacen.setDisabledTextColor(new java.awt.Color(153, 153, 153));
        txtTipoAlmacen.setEnabled(false);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnlTop, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap(19, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addComponent(lblUsersSystem)
                                .addGap(77, 77, 77))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 222, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)))
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addGroup(layout.createSequentialGroup()
                                    .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGap(26, 26, 26)
                                    .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGap(28, 28, 28)
                                    .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 93, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(lblName)
                                        .addComponent(lblAccount))
                                    .addGap(30, 30, 30)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(cmbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 235, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 308, Short.MAX_VALUE)
                                            .addComponent(txtName, javax.swing.GroupLayout.DEFAULT_SIZE, 308, Short.MAX_VALUE)
                                            .addComponent(txtOperario, javax.swing.GroupLayout.PREFERRED_SIZE, 235, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblOperario)
                                    .addComponent(lblTipo)
                                    .addComponent(lblOperario1))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 47, Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(261, 261, 261)
                                        .addComponent(cbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(jScrollPane3, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 308, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(btnOperarios, javax.swing.GroupLayout.Alignment.TRAILING))))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(lblTipoAlm)
                                .addGap(18, 18, 18)
                                .addComponent(txtTipoAlmacen, javax.swing.GroupLayout.PREFERRED_SIZE, 235, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addComponent(btnEditarArea, javax.swing.GroupLayout.PREFERRED_SIZE, 72, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(67, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(pnlTop, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblUsersSystem, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 320, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(19, 19, 19)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblName))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblAccount)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtOperario, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(btnOperarios, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(lblOperario))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblTipoAlm)
                            .addComponent(txtTipoAlmacen, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblTipo)
                            .addComponent(cmbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 163, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblOperario1))))
                .addComponent(btnEditarArea, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(29, 29, 29))
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void btnModificarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnModificarActionPerformed
        String nom = txtName.getText();
        String desc = txtDescripcion.getText();
        Almacen alm = new Almacen();
        ArrayList<Operario> operarios = new ArrayList<Operario>();
        String nomOp = txtOperario.getText();
        Operario operar = null;
        int tam = usuarios.size();
        for(int i = 0; i< tam; i++){
            if(usuarios.get(i).getNombre().equals(nomOp)){
                operar = (Operario)usuarios.get(i);
                operarios.add(operar);
                break;
            }
        }
        alm.setAreas(areas);
        alm.setDescripcion(desc);
        alm.setNomAlmacen(nom);
        alm.setOperarios(operarios);
        alm.setIdAlmacen(almacenes.get(index).getIdAlmacen());
        boolean flag = true;
        if(areas.equals(almacenes.get(index).getAreas())){
            flag = false;
        }
        int indnum = cmbTipo.getSelectedIndex();
        if(indnum>=0){
            alm.setTipo_almacen(indnum);
        }else{
            if(txtTipoAlmacen.getText().equals("Almacén Virtual")){
                alm.setTipo_almacen(0);
            }else{
                alm.setTipo_almacen(1);
            }
        }
        almacenBL.modificarAlmacen(alm, flag);
        JOptionPane.showMessageDialog(this,"Almacén Modificado.", "Confirmación",
            JOptionPane.INFORMATION_MESSAGE);
        this.dispose();
    }//GEN-LAST:event_btnModificarActionPerformed

    private void btnCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCancelarActionPerformed
        this.dispose();
    }//GEN-LAST:event_btnCancelarActionPerformed

    private void btnOperariosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOperariosActionPerformed
        ModOperarioForm mof = new ModOperarioForm(null,true,ger);
        mof.setVisible(true);
        Operario oper = mof.op;
        txtOperario.setText(oper.getNombre());
    }//GEN-LAST:event_btnOperariosActionPerformed

    private void tblAlmacenMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblAlmacenMouseClicked
        txtName.setEnabled(true);
        txtDescripcion.setEnabled(true);
        txtOperario.setEnabled(true);
        cbTipo.setEnabled(true);
        txtTipoAlmacen.setEnabled(true);
        modeloArea.getDataVector().removeAllElements();
        
        int row = tblAlmacen.getSelectedRow();
        int col = tblAlmacen.getSelectedColumn();
        int cant = almacenes.size();
        String nombreAlm = tblAlmacen.getValueAt(row, col).toString();
        index = 0;
        for(int i = 0; i<cant;i++){
            if(almacenes.get(i).getNomAlmacen().equals(nombreAlm)){
                index = i;
            }
        }
        int indnum = almacenes.get(index).getTipo_almacen();
        if(indnum == 0){
            txtTipoAlmacen.setText("Almacén Virtual");
        }else{
            txtTipoAlmacen.setText("Almacén Principal");
        }
        txtName.setText(almacenes.get(index).getNomAlmacen());
        txtDescripcion.setText(almacenes.get(index).getDescripcion());
        txtOperario.setText(almacenes.get(index).getOperarios().get(0).getNombre());
        ger = almacenes.get(index).getOperarios().get(0).getNombre();
        if(cbTipo.getState()){
            cmbTipo.setEnabled(true);
        }
        
        Object[] fila = new Object[1];
        areas = new ArrayList<Area>();
        areas = almacenes.get(index).getAreas();
        int cant2 = areas.size();
        for(int i = 0; i<cant2; i++){
            fila[0] = areas.get(i).getNombreArea();
            modeloArea.addRow(fila);
        }
        
        
    }//GEN-LAST:event_tblAlmacenMouseClicked

    private void btnEditarAreaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEditarAreaActionPerformed
        ModAreaForm maf = new ModAreaForm(null,true, areas);
        maf.setVisible(true);
        areas = maf.areas;
        modeloArea.getDataVector().removeAllElements();
        Object[] fila = new Object[1];
        int cant2 = areas.size();
        for(int i = 0; i<cant2; i++){
            fila[0] = areas.get(i).getNombreArea();
            modeloArea.addRow(fila);
        }
    }//GEN-LAST:event_btnEditarAreaActionPerformed

    private void btnEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarActionPerformed
        String nom = txtName.getText();
        String desc = txtDescripcion.getText();
        Almacen alm = new Almacen();
        ArrayList<Operario> operarios = new ArrayList<Operario>();
        operarios = almacenes.get(index).getOperarios();
        alm.setAreas(areas);
        alm.setDescripcion(desc);
        alm.setNomAlmacen(nom);
        alm.setOperarios(operarios);
        alm.setIdAlmacen(almacenes.get(index).getIdAlmacen());
        almacenBL.eliminarAlmacen(alm);
        JOptionPane.showMessageDialog(this,"Almacén Eliminado.", "Confirmación",
            JOptionPane.INFORMATION_MESSAGE);
        this.dispose();
    }//GEN-LAST:event_btnEliminarActionPerformed

    private void cbTipoItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_cbTipoItemStateChanged
        if(evt.getStateChange() == java.awt.event.ItemEvent.SELECTED){
            cmbTipo.setEnabled(true);
        }else{
            cmbTipo.setEnabled(false);
        }
    }//GEN-LAST:event_cbTipoItemStateChanged

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
            java.util.logging.Logger.getLogger(ModWrhouseForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ModWrhouseForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ModWrhouseForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ModWrhouseForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                ModWrhouseForm dialog = new ModWrhouseForm(new javax.swing.JFrame(), true);
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
    private javax.swing.JButton btnEditarArea;
    private javax.swing.JButton btnEliminar;
    private javax.swing.JButton btnModificar;
    private javax.swing.JButton btnOperarios;
    private java.awt.Checkbox cbTipo;
    private javax.swing.JComboBox<String> cmbTipo;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JLabel lblAccount;
    private javax.swing.JLabel lblName;
    private javax.swing.JLabel lblOperario;
    private javax.swing.JLabel lblOperario1;
    private javax.swing.JLabel lblTextLogin;
    private javax.swing.JLabel lblTipo;
    private javax.swing.JLabel lblTipoAlm;
    private javax.swing.JLabel lblUsersSystem;
    private javax.swing.JPanel pnlTop;
    private javax.swing.JTable tblAlmacen;
    private javax.swing.JTable tblAreas;
    private javax.swing.JTextArea txtDescripcion;
    private javax.swing.JTextField txtName;
    private javax.swing.JTextField txtOperario;
    private javax.swing.JTextField txtTipoAlmacen;
    // End of variables declaration//GEN-END:variables
}
