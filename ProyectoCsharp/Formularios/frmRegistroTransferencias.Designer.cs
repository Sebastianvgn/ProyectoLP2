namespace Formularios
{
    partial class frmRegistroTransferencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroTransferencias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecTransf = new System.Windows.Forms.DateTimePicker();
            this.dtpFecProd = new System.Windows.Forms.DateTimePicker();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.colCodArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripArti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetallePedidos = new System.Windows.Forms.DataGridView();
            this.colAlmOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantDespacho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlmDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIngArticulo = new System.Windows.Forms.TextBox();
            this.cmbAlmOrigen = new System.Windows.Forms.ComboBox();
            this.cmbAlmDestino = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txtNPedido = new System.Windows.Forms.TextBox();
            this.rbtnTransferencia = new System.Windows.Forms.RadioButton();
            this.rbtnPedido = new System.Windows.Forms.RadioButton();
            this.rbtnPedidosPend = new System.Windows.Forms.RadioButton();
            this.txtCantTransf = new System.Windows.Forms.TextBox();
            this.lblFecTransf = new System.Windows.Forms.Label();
            this.lblFecProd = new System.Windows.Forms.Label();
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantTrans = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnNewTransfer = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colNPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNTransf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecTransf
            // 
            this.dtpFecTransf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecTransf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecTransf.Location = new System.Drawing.Point(55, 59);
            this.dtpFecTransf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecTransf.Name = "dtpFecTransf";
            this.dtpFecTransf.Size = new System.Drawing.Size(144, 26);
            this.dtpFecTransf.TabIndex = 0;
            // 
            // dtpFecProd
            // 
            this.dtpFecProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecProd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecProd.Location = new System.Drawing.Point(55, 132);
            this.dtpFecProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecProd.Name = "dtpFecProd";
            this.dtpFecProd.Size = new System.Drawing.Size(144, 26);
            this.dtpFecProd.TabIndex = 1;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeight = 30;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodArticulo,
            this.colDescripArti,
            this.colUnidad});
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.Location = new System.Drawing.Point(437, 48);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.Size = new System.Drawing.Size(511, 172);
            this.dgvArticulos.TabIndex = 2;
            // 
            // colCodArticulo
            // 
            this.colCodArticulo.HeaderText = "Código";
            this.colCodArticulo.Name = "colCodArticulo";
            this.colCodArticulo.ReadOnly = true;
            // 
            // colDescripArti
            // 
            this.colDescripArti.HeaderText = "Descripción";
            this.colDescripArti.Name = "colDescripArti";
            this.colDescripArti.ReadOnly = true;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            // 
            // dgvDetallePedidos
            // 
            this.dgvDetallePedidos.AllowUserToResizeRows = false;
            this.dgvDetallePedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallePedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedidos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDetallePedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallePedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetallePedidos.ColumnHeadersHeight = 40;
            this.dgvDetallePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetallePedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlmOrigen,
            this.colFecha,
            this.colCodigo,
            this.colDescripcion,
            this.colUND,
            this.colCantDespacho,
            this.colCantPedida,
            this.colPrecioCosto,
            this.colAlmDestino});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallePedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetallePedidos.EnableHeadersVisualStyles = false;
            this.dgvDetallePedidos.Location = new System.Drawing.Point(161, 318);
            this.dgvDetallePedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetallePedidos.Name = "dgvDetallePedidos";
            this.dgvDetallePedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetallePedidos.RowHeadersVisible = false;
            this.dgvDetallePedidos.Size = new System.Drawing.Size(1243, 354);
            this.dgvDetallePedidos.TabIndex = 3;
            // 
            // colAlmOrigen
            // 
            this.colAlmOrigen.HeaderText = "Almacén Origen";
            this.colAlmOrigen.Name = "colAlmOrigen";
            this.colAlmOrigen.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colUND
            // 
            this.colUND.HeaderText = "UND";
            this.colUND.Name = "colUND";
            this.colUND.ReadOnly = true;
            // 
            // colCantDespacho
            // 
            this.colCantDespacho.HeaderText = "Cant Despacho";
            this.colCantDespacho.Name = "colCantDespacho";
            this.colCantDespacho.ReadOnly = true;
            // 
            // colCantPedida
            // 
            this.colCantPedida.HeaderText = "Cant Pedida";
            this.colCantPedida.Name = "colCantPedida";
            this.colCantPedida.ReadOnly = true;
            // 
            // colPrecioCosto
            // 
            this.colPrecioCosto.HeaderText = "Precio Costo";
            this.colPrecioCosto.Name = "colPrecioCosto";
            this.colPrecioCosto.ReadOnly = true;
            // 
            // colAlmDestino
            // 
            this.colAlmDestino.HeaderText = "Almacén Destino";
            this.colAlmDestino.Name = "colAlmDestino";
            this.colAlmDestino.ReadOnly = true;
            // 
            // txtIngArticulo
            // 
            this.txtIngArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIngArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIngArticulo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngArticulo.Location = new System.Drawing.Point(609, 11);
            this.txtIngArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngArticulo.Name = "txtIngArticulo";
            this.txtIngArticulo.Size = new System.Drawing.Size(337, 24);
            this.txtIngArticulo.TabIndex = 4;
            // 
            // cmbAlmOrigen
            // 
            this.cmbAlmOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlmOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAlmOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmOrigen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlmOrigen.FormattingEnabled = true;
            this.cmbAlmOrigen.Location = new System.Drawing.Point(1124, 32);
            this.cmbAlmOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAlmOrigen.Name = "cmbAlmOrigen";
            this.cmbAlmOrigen.Size = new System.Drawing.Size(256, 29);
            this.cmbAlmOrigen.TabIndex = 5;
            // 
            // cmbAlmDestino
            // 
            this.cmbAlmDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlmDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAlmDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlmDestino.FormattingEnabled = true;
            this.cmbAlmDestino.Location = new System.Drawing.Point(1124, 70);
            this.cmbAlmDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAlmDestino.Name = "cmbAlmDestino";
            this.cmbAlmDestino.Size = new System.Drawing.Size(256, 29);
            this.cmbAlmDestino.TabIndex = 6;
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(1124, 111);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(256, 29);
            this.cmbArea.TabIndex = 7;
            // 
            // txtNPedido
            // 
            this.txtNPedido.Location = new System.Drawing.Point(9, 318);
            this.txtNPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNPedido.Name = "txtNPedido";
            this.txtNPedido.Size = new System.Drawing.Size(143, 22);
            this.txtNPedido.TabIndex = 8;
            // 
            // rbtnTransferencia
            // 
            this.rbtnTransferencia.AutoSize = true;
            this.rbtnTransferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTransferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTransferencia.Location = new System.Drawing.Point(9, 231);
            this.rbtnTransferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTransferencia.Name = "rbtnTransferencia";
            this.rbtnTransferencia.Size = new System.Drawing.Size(148, 25);
            this.rbtnTransferencia.TabIndex = 10;
            this.rbtnTransferencia.TabStop = true;
            this.rbtnTransferencia.Text = "Transferencias";
            this.rbtnTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbtnPedido
            // 
            this.rbtnPedido.AutoSize = true;
            this.rbtnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPedido.Location = new System.Drawing.Point(9, 260);
            this.rbtnPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPedido.Name = "rbtnPedido";
            this.rbtnPedido.Size = new System.Drawing.Size(97, 25);
            this.rbtnPedido.TabIndex = 11;
            this.rbtnPedido.TabStop = true;
            this.rbtnPedido.Text = "Pedidos";
            this.rbtnPedido.UseVisualStyleBackColor = true;
            // 
            // rbtnPedidosPend
            // 
            this.rbtnPedidosPend.AutoSize = true;
            this.rbtnPedidosPend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPedidosPend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPedidosPend.Location = new System.Drawing.Point(9, 288);
            this.rbtnPedidosPend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPedidosPend.Name = "rbtnPedidosPend";
            this.rbtnPedidosPend.Size = new System.Drawing.Size(194, 25);
            this.rbtnPedidosPend.TabIndex = 12;
            this.rbtnPedidosPend.TabStop = true;
            this.rbtnPedidosPend.Text = "Pedidos Pendientes";
            this.rbtnPedidosPend.UseVisualStyleBackColor = true;
            // 
            // txtCantTransf
            // 
            this.txtCantTransf.Location = new System.Drawing.Point(563, 235);
            this.txtCantTransf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantTransf.Name = "txtCantTransf";
            this.txtCantTransf.Size = new System.Drawing.Size(64, 22);
            this.txtCantTransf.TabIndex = 13;
            // 
            // lblFecTransf
            // 
            this.lblFecTransf.AutoSize = true;
            this.lblFecTransf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecTransf.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFecTransf.Location = new System.Drawing.Point(12, 23);
            this.lblFecTransf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecTransf.Name = "lblFecTransf";
            this.lblFecTransf.Size = new System.Drawing.Size(198, 19);
            this.lblFecTransf.TabIndex = 18;
            this.lblFecTransf.Text = "Fecha de transferencia";
            // 
            // lblFecProd
            // 
            this.lblFecProd.AutoSize = true;
            this.lblFecProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecProd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFecProd.Location = new System.Drawing.Point(12, 108);
            this.lblFecProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecProd.Name = "lblFecProd";
            this.lblFecProd.Size = new System.Drawing.Size(186, 19);
            this.lblFecProd.TabIndex = 19;
            this.lblFecProd.Text = "Fecha de Producción";
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferencia.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTransferencia.Location = new System.Drawing.Point(5, 164);
            this.lblTransferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(167, 56);
            this.lblTransferencia.TabIndex = 20;
            this.lblTransferencia.Text = "Transferencia\r\nN°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(447, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ingresar Artículo";
            // 
            // lblCantTrans
            // 
            this.lblCantTrans.AutoSize = true;
            this.lblCantTrans.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTrans.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblCantTrans.Location = new System.Drawing.Point(447, 233);
            this.lblCantTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantTrans.Name = "lblCantTrans";
            this.lblCantTrans.Size = new System.Drawing.Size(100, 38);
            this.lblCantTrans.TabIndex = 22;
            this.lblCantTrans.Text = "Cantidad a\r\nTransferir";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(1045, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Origen";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(1043, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Destino";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(1063, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Area";
            // 
            // btnTransferir
            // 
            this.btnTransferir.AutoSize = true;
            this.btnTransferir.BackColor = System.Drawing.Color.Transparent;
            this.btnTransferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferir.Image")));
            this.btnTransferir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransferir.Location = new System.Drawing.Point(636, 228);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(99, 75);
            this.btnTransferir.TabIndex = 44;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.AutoSize = true;
            this.btnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrabar.Location = new System.Drawing.Point(743, 228);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(88, 74);
            this.btnGrabar.TabIndex = 45;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(1281, 159);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 71);
            this.btnImprimir.TabIndex = 46;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnNewTransfer
            // 
            this.btnNewTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTransfer.AutoSize = true;
            this.btnNewTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTransfer.FlatAppearance.BorderSize = 0;
            this.btnNewTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransfer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransfer.Image")));
            this.btnNewTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewTransfer.Location = new System.Drawing.Point(1176, 159);
            this.btnNewTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewTransfer.Name = "btnNewTransfer";
            this.btnNewTransfer.Size = new System.Drawing.Size(81, 95);
            this.btnNewTransfer.TabIndex = 47;
            this.btnNewTransfer.Text = "Nueva\r\nTransf.";
            this.btnNewTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewTransfer.UseVisualStyleBackColor = false;
            this.btnNewTransfer.Click += new System.EventHandler(this.btnNewTransfer_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedidos.ColumnHeadersHeight = 25;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNPedido});
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.Location = new System.Drawing.Point(9, 350);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.Size = new System.Drawing.Size(144, 322);
            this.dgvPedidos.TabIndex = 48;
            // 
            // colNPedido
            // 
            this.colNPedido.HeaderText = "NroPedido";
            this.colNPedido.Name = "colNPedido";
            this.colNPedido.ReadOnly = true;
            // 
            // lblNTransf
            // 
            this.lblNTransf.AutoSize = true;
            this.lblNTransf.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTransf.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNTransf.Location = new System.Drawing.Point(60, 191);
            this.lblNTransf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNTransf.Name = "lblNTransf";
            this.lblNTransf.Size = new System.Drawing.Size(64, 28);
            this.lblNTransf.TabIndex = 49;
            this.lblNTransf.Text = "0001";
            // 
            // frmRegistroTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1423, 730);
            this.Controls.Add(this.lblNTransf);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnNewTransfer);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCantTrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTransferencia);
            this.Controls.Add(this.lblFecProd);
            this.Controls.Add(this.lblFecTransf);
            this.Controls.Add(this.txtCantTransf);
            this.Controls.Add(this.rbtnPedidosPend);
            this.Controls.Add(this.rbtnPedido);
            this.Controls.Add(this.rbtnTransferencia);
            this.Controls.Add(this.txtNPedido);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbAlmDestino);
            this.Controls.Add(this.cmbAlmOrigen);
            this.Controls.Add(this.txtIngArticulo);
            this.Controls.Add(this.dgvDetallePedidos);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.dtpFecProd);
            this.Controls.Add(this.dtpFecTransf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroTransferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroTransferencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecTransf;
        private System.Windows.Forms.DateTimePicker dtpFecProd;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dgvDetallePedidos;
        private System.Windows.Forms.TextBox txtIngArticulo;
        private System.Windows.Forms.ComboBox cmbAlmOrigen;
        private System.Windows.Forms.ComboBox cmbAlmDestino;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.TextBox txtNPedido;
        private System.Windows.Forms.RadioButton rbtnTransferencia;
        private System.Windows.Forms.RadioButton rbtnPedido;
        private System.Windows.Forms.RadioButton rbtnPedidosPend;
        private System.Windows.Forms.TextBox txtCantTransf;
        private System.Windows.Forms.Label lblFecTransf;
        private System.Windows.Forms.Label lblFecProd;
        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnNewTransfer;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNPedido;
        private System.Windows.Forms.Label lblNTransf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripArti;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlmOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantDespacho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlmDestino;
    }
}