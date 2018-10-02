namespace Formularios
{
    partial class frmIngresarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpFecProduccion = new System.Windows.Forms.DateTimePicker();
            this.lblNOrden = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNOrden = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbAlmDestino = new System.Windows.Forms.ComboBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.PanelFecha = new System.Windows.Forms.Panel();
            this.lblFechaProduccion = new System.Windows.Forms.Label();
            this.lblHoraEntrega = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.PanelNOrden = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.PanelAlmacen = new System.Windows.Forms.Panel();
            this.cmbAlmOrigen = new System.Windows.Forms.ComboBox();
            this.dgvDetallePedido = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetallePedido = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDuplicar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.colNombArticu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFecha.SuspendLayout();
            this.PanelNOrden.SuspendLayout();
            this.PanelAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecEntrega
            // 
            this.dtpFecEntrega.CustomFormat = "dd-MM-yyyy";
            this.dtpFecEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecEntrega.Location = new System.Drawing.Point(18, 39);
            this.dtpFecEntrega.Name = "dtpFecEntrega";
            this.dtpFecEntrega.Size = new System.Drawing.Size(172, 22);
            this.dtpFecEntrega.TabIndex = 0;
            this.dtpFecEntrega.ValueChanged += new System.EventHandler(this.dtpFecEntrega_ValueChanged);
            // 
            // dtpHoraEntrega
            // 
            this.dtpHoraEntrega.CustomFormat = "";
            this.dtpHoraEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrega.Location = new System.Drawing.Point(18, 101);
            this.dtpHoraEntrega.Name = "dtpHoraEntrega";
            this.dtpHoraEntrega.ShowUpDown = true;
            this.dtpHoraEntrega.Size = new System.Drawing.Size(172, 22);
            this.dtpHoraEntrega.TabIndex = 1;
            // 
            // dtpFecProduccion
            // 
            this.dtpFecProduccion.CustomFormat = "dd-MM-yyyy";
            this.dtpFecProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecProduccion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecProduccion.Location = new System.Drawing.Point(18, 164);
            this.dtpFecProduccion.Name = "dtpFecProduccion";
            this.dtpFecProduccion.Size = new System.Drawing.Size(172, 22);
            this.dtpFecProduccion.TabIndex = 2;
            // 
            // lblNOrden
            // 
            this.lblNOrden.AutoSize = true;
            this.lblNOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOrden.Location = new System.Drawing.Point(8, 7);
            this.lblNOrden.Name = "lblNOrden";
            this.lblNOrden.Size = new System.Drawing.Size(61, 20);
            this.lblNOrden.TabIndex = 3;
            this.lblNOrden.Text = "N° Ord";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(415, 7);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtNOrden
            // 
            this.txtNOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOrden.Location = new System.Drawing.Point(131, 7);
            this.txtNOrden.Name = "txtNOrden";
            this.txtNOrden.Size = new System.Drawing.Size(186, 22);
            this.txtNOrden.TabIndex = 5;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(410, 19);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(62, 20);
            this.lblOrigen.TabIndex = 9;
            this.lblOrigen.Text = "Origen";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(22, 38);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(64, 20);
            this.lblPedido.TabIndex = 8;
            this.lblPedido.Text = "Pedido";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(410, 57);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(71, 20);
            this.lblDestino.TabIndex = 11;
            this.lblDestino.Text = "Destino";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(22, 101);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(114, 20);
            this.lblResponsable.TabIndex = 10;
            this.lblResponsable.Text = "Responsable";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(410, 96);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Area";
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.Location = new System.Drawing.Point(149, 41);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(191, 25);
            this.cmbTipoPedido.TabIndex = 14;
            this.cmbTipoPedido.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPedido_SelectedIndexChanged);
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(149, 100);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(191, 25);
            this.cmbResponsable.TabIndex = 15;
            // 
            // cmbArea
            // 
            this.cmbArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(506, 96);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(191, 25);
            this.cmbArea.TabIndex = 18;
            // 
            // cmbAlmDestino
            // 
            this.cmbAlmDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAlmDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlmDestino.FormattingEnabled = true;
            this.cmbAlmDestino.Location = new System.Drawing.Point(506, 57);
            this.cmbAlmDestino.Name = "cmbAlmDestino";
            this.cmbAlmDestino.Size = new System.Drawing.Size(191, 25);
            this.cmbAlmDestino.TabIndex = 17;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(27, 272);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(216, 22);
            this.txtArticulo.TabIndex = 19;
            // 
            // PanelFecha
            // 
            this.PanelFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFecha.Controls.Add(this.lblFechaProduccion);
            this.PanelFecha.Controls.Add(this.dtpFecEntrega);
            this.PanelFecha.Controls.Add(this.lblHoraEntrega);
            this.PanelFecha.Controls.Add(this.dtpHoraEntrega);
            this.PanelFecha.Controls.Add(this.lblFechaEntrega);
            this.PanelFecha.Controls.Add(this.dtpFecProduccion);
            this.PanelFecha.Location = new System.Drawing.Point(27, 18);
            this.PanelFecha.Name = "PanelFecha";
            this.PanelFecha.Size = new System.Drawing.Size(216, 222);
            this.PanelFecha.TabIndex = 20;
            // 
            // lblFechaProduccion
            // 
            this.lblFechaProduccion.AutoSize = true;
            this.lblFechaProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaProduccion.Location = new System.Drawing.Point(14, 136);
            this.lblFechaProduccion.Name = "lblFechaProduccion";
            this.lblFechaProduccion.Size = new System.Drawing.Size(178, 20);
            this.lblFechaProduccion.TabIndex = 23;
            this.lblFechaProduccion.Text = "Fecha de Produccion";
            // 
            // lblHoraEntrega
            // 
            this.lblHoraEntrega.AutoSize = true;
            this.lblHoraEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrega.Location = new System.Drawing.Point(14, 76);
            this.lblHoraEntrega.Name = "lblHoraEntrega";
            this.lblHoraEntrega.Size = new System.Drawing.Size(142, 20);
            this.lblHoraEntrega.TabIndex = 22;
            this.lblHoraEntrega.Text = "Hora de Entrega";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(14, 17);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(153, 20);
            this.lblFechaEntrega.TabIndex = 21;
            this.lblFechaEntrega.Text = "Fecha de Entrega";
            // 
            // PanelNOrden
            // 
            this.PanelNOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNOrden.Controls.Add(this.cmbEstado);
            this.PanelNOrden.Controls.Add(this.txtNOrden);
            this.PanelNOrden.Controls.Add(this.lblNOrden);
            this.PanelNOrden.Controls.Add(this.lblEstado);
            this.PanelNOrden.Location = new System.Drawing.Point(265, 18);
            this.PanelNOrden.Name = "PanelNOrden";
            this.PanelNOrden.Size = new System.Drawing.Size(731, 40);
            this.PanelNOrden.TabIndex = 21;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(508, 6);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(194, 25);
            this.cmbEstado.TabIndex = 40;
            // 
            // PanelAlmacen
            // 
            this.PanelAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAlmacen.Controls.Add(this.cmbAlmOrigen);
            this.PanelAlmacen.Controls.Add(this.lblPedido);
            this.PanelAlmacen.Controls.Add(this.lblOrigen);
            this.PanelAlmacen.Controls.Add(this.lblResponsable);
            this.PanelAlmacen.Controls.Add(this.lblDestino);
            this.PanelAlmacen.Controls.Add(this.cmbArea);
            this.PanelAlmacen.Controls.Add(this.lblArea);
            this.PanelAlmacen.Controls.Add(this.cmbAlmDestino);
            this.PanelAlmacen.Controls.Add(this.cmbTipoPedido);
            this.PanelAlmacen.Controls.Add(this.cmbResponsable);
            this.PanelAlmacen.Location = new System.Drawing.Point(265, 75);
            this.PanelAlmacen.Name = "PanelAlmacen";
            this.PanelAlmacen.Size = new System.Drawing.Size(731, 147);
            this.PanelAlmacen.TabIndex = 22;
            // 
            // cmbAlmOrigen
            // 
            this.cmbAlmOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAlmOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmOrigen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlmOrigen.FormattingEnabled = true;
            this.cmbAlmOrigen.Location = new System.Drawing.Point(506, 14);
            this.cmbAlmOrigen.Name = "cmbAlmOrigen";
            this.cmbAlmOrigen.Size = new System.Drawing.Size(191, 25);
            this.cmbAlmOrigen.TabIndex = 39;
            // 
            // dgvDetallePedido
            // 
            this.dgvDetallePedido.AllowUserToAddRows = false;
            this.dgvDetallePedido.AllowUserToDeleteRows = false;
            this.dgvDetallePedido.AllowUserToResizeColumns = false;
            this.dgvDetallePedido.AllowUserToResizeRows = false;
            this.dgvDetallePedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedido.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDetallePedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetallePedido.ColumnHeadersHeight = 35;
            this.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colUnidad,
            this.colCant,
            this.colPrecio,
            this.colIGV,
            this.colNeto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallePedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetallePedido.EnableHeadersVisualStyles = false;
            this.dgvDetallePedido.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDetallePedido.Location = new System.Drawing.Point(265, 269);
            this.dgvDetallePedido.Name = "dgvDetallePedido";
            this.dgvDetallePedido.RowHeadersVisible = false;
            this.dgvDetallePedido.Size = new System.Drawing.Size(843, 364);
            this.dgvDetallePedido.TabIndex = 23;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            // 
            // colCant
            // 
            this.colCant.HeaderText = "Cantidad";
            this.colCant.Name = "colCant";
            this.colCant.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colIGV
            // 
            this.colIGV.HeaderText = "IGV";
            this.colIGV.Name = "colIGV";
            this.colIGV.ReadOnly = true;
            // 
            // colNeto
            // 
            this.colNeto.HeaderText = "Neto";
            this.colNeto.Name = "colNeto";
            this.colNeto.ReadOnly = true;
            // 
            // lblDetallePedido
            // 
            this.lblDetallePedido.AutoSize = true;
            this.lblDetallePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallePedido.Location = new System.Drawing.Point(270, 246);
            this.lblDetallePedido.Name = "lblDetallePedido";
            this.lblDetallePedido.Size = new System.Drawing.Size(126, 20);
            this.lblDetallePedido.TabIndex = 24;
            this.lblDetallePedido.Text = "Detalle Pedido";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(1002, 636);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(89, 22);
            this.txtSubTotal.TabIndex = 26;
            // 
            // txtIGV
            // 
            this.txtIGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIGV.Enabled = false;
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(1002, 664);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(89, 22);
            this.txtIGV.TabIndex = 27;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1002, 692);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(89, 22);
            this.txtTotal.TabIndex = 28;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(42, 249);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(70, 20);
            this.lblArticulo.TabIndex = 29;
            this.lblArticulo.Text = "Articulo";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(910, 636);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(86, 20);
            this.lblSubTotal.TabIndex = 30;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblIGV
            // 
            this.lblIGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(955, 664);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(41, 20);
            this.lblIGV.TabIndex = 31;
            this.lblIGV.Text = "IGV";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(947, 692);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Total";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.AutoSize = true;
            this.btnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrabar.Location = new System.Drawing.Point(531, 649);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 63);
            this.btnGrabar.TabIndex = 33;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(612, 649);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuplicar.AutoSize = true;
            this.btnDuplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuplicar.FlatAppearance.BorderSize = 0;
            this.btnDuplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuplicar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplicar.Image")));
            this.btnDuplicar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuplicar.Location = new System.Drawing.Point(774, 649);
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(75, 63);
            this.btnDuplicar.TabIndex = 36;
            this.btnDuplicar.Text = "Duplicar";
            this.btnDuplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDuplicar.UseVisualStyleBackColor = true;
            this.btnDuplicar.Click += new System.EventHandler(this.btnDuplicar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(693, 649);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 63);
            this.btnImprimir.TabIndex = 35;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(281, 65);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(57, 20);
            this.lblDatos.TabIndex = 37;
            this.lblDatos.Text = "Datos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.ColumnHeadersHeight = 30;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombArticu});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Info;
            this.dgvArticulos.Location = new System.Drawing.Point(27, 300);
            this.dgvArticulos.Name = "dgvArticulos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.Size = new System.Drawing.Size(216, 371);
            this.dgvArticulos.TabIndex = 38;
            // 
            // colNombArticu
            // 
            this.colNombArticu.HeaderText = "NombreArtículo";
            this.colNombArticu.Name = "colNombArticu";
            this.colNombArticu.ReadOnly = true;
            // 
            // frmIngresarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 774);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnDuplicar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblDetallePedido);
            this.Controls.Add(this.dgvDetallePedido);
            this.Controls.Add(this.PanelAlmacen);
            this.Controls.Add(this.PanelNOrden);
            this.Controls.Add(this.PanelFecha);
            this.Controls.Add(this.txtArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Pedido";
            this.PanelFecha.ResumeLayout(false);
            this.PanelFecha.PerformLayout();
            this.PanelNOrden.ResumeLayout(false);
            this.PanelNOrden.PerformLayout();
            this.PanelAlmacen.ResumeLayout(false);
            this.PanelAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecEntrega;
        private System.Windows.Forms.DateTimePicker dtpFecProduccion;
        private System.Windows.Forms.Label lblNOrden;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNOrden;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbAlmDestino;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Panel PanelFecha;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrega;
        private System.Windows.Forms.Label lblFechaProduccion;
        private System.Windows.Forms.Label lblHoraEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Panel PanelNOrden;
        private System.Windows.Forms.Panel PanelAlmacen;
        private System.Windows.Forms.DataGridView dgvDetallePedido;
        private System.Windows.Forms.Label lblDetallePedido;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDuplicar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombArticu;
        private System.Windows.Forms.ComboBox cmbAlmOrigen;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeto;
    }
}