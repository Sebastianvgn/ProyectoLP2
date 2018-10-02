namespace Formularios
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnOcultar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnArticulosCaducar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnPedidosPendientes = new System.Windows.Forms.Button();
            this.btnMermas = new System.Windows.Forms.Button();
            this.btnRegistroIngresoComprobantes = new System.Windows.Forms.Button();
            this.btnRegistroTransferencias = new System.Windows.Forms.Button();
            this.btnIngresarPedido = new System.Windows.Forms.Button();
            this.btnGenerarConsolidado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOcultarMenu = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelSuperior.Controls.Add(this.btnOcultar);
            this.panelSuperior.Controls.Add(this.btnMaximizar);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1346, 38);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultar.Image")));
            this.btnOcultar.Location = new System.Drawing.Point(1247, 5);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(28, 28);
            this.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultar.TabIndex = 4;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1281, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 28);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1315, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Almacén LUCET SA";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1281, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateral.Controls.Add(this.btnArticulosCaducar);
            this.panelLateral.Controls.Add(this.btnAyuda);
            this.panelLateral.Controls.Add(this.btnPedidosPendientes);
            this.panelLateral.Controls.Add(this.btnMermas);
            this.panelLateral.Controls.Add(this.btnRegistroIngresoComprobantes);
            this.panelLateral.Controls.Add(this.btnRegistroTransferencias);
            this.panelLateral.Controls.Add(this.btnIngresarPedido);
            this.panelLateral.Controls.Add(this.btnGenerarConsolidado);
            this.panelLateral.Controls.Add(this.btnSalir);
            this.panelLateral.Controls.Add(this.btnOcultarMenu);
            this.panelLateral.Controls.Add(this.btnInsumos);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 38);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(260, 801);
            this.panelLateral.TabIndex = 1;
            // 
            // btnArticulosCaducar
            // 
            this.btnArticulosCaducar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulosCaducar.FlatAppearance.BorderSize = 0;
            this.btnArticulosCaducar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnArticulosCaducar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnArticulosCaducar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulosCaducar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulosCaducar.ForeColor = System.Drawing.Color.White;
            this.btnArticulosCaducar.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulosCaducar.Image")));
            this.btnArticulosCaducar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulosCaducar.Location = new System.Drawing.Point(0, 490);
            this.btnArticulosCaducar.Name = "btnArticulosCaducar";
            this.btnArticulosCaducar.Size = new System.Drawing.Size(260, 51);
            this.btnArticulosCaducar.TabIndex = 10;
            this.btnArticulosCaducar.Text = "Artículos a Caducar";
            this.btnArticulosCaducar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArticulosCaducar.UseVisualStyleBackColor = true;
            this.btnArticulosCaducar.Click += new System.EventHandler(this.btnArticulosCaducar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 547);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(260, 51);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnPedidosPendientes
            // 
            this.btnPedidosPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosPendientes.FlatAppearance.BorderSize = 0;
            this.btnPedidosPendientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnPedidosPendientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnPedidosPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidosPendientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosPendientes.ForeColor = System.Drawing.Color.White;
            this.btnPedidosPendientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidosPendientes.Image")));
            this.btnPedidosPendientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidosPendientes.Location = new System.Drawing.Point(0, 433);
            this.btnPedidosPendientes.Name = "btnPedidosPendientes";
            this.btnPedidosPendientes.Size = new System.Drawing.Size(260, 51);
            this.btnPedidosPendientes.TabIndex = 8;
            this.btnPedidosPendientes.Text = "Pedidos Pendientes";
            this.btnPedidosPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedidosPendientes.UseVisualStyleBackColor = true;
            this.btnPedidosPendientes.Click += new System.EventHandler(this.btnPedidosPendientes_Click);
            // 
            // btnMermas
            // 
            this.btnMermas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMermas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMermas.FlatAppearance.BorderSize = 0;
            this.btnMermas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnMermas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnMermas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMermas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMermas.ForeColor = System.Drawing.Color.White;
            this.btnMermas.Image = ((System.Drawing.Image)(resources.GetObject("btnMermas.Image")));
            this.btnMermas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMermas.Location = new System.Drawing.Point(0, 376);
            this.btnMermas.Name = "btnMermas";
            this.btnMermas.Size = new System.Drawing.Size(260, 51);
            this.btnMermas.TabIndex = 7;
            this.btnMermas.Text = "Mermas";
            this.btnMermas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMermas.UseVisualStyleBackColor = false;
            this.btnMermas.Click += new System.EventHandler(this.btnMermas_Click);
            // 
            // btnRegistroIngresoComprobantes
            // 
            this.btnRegistroIngresoComprobantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroIngresoComprobantes.FlatAppearance.BorderSize = 0;
            this.btnRegistroIngresoComprobantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnRegistroIngresoComprobantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnRegistroIngresoComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroIngresoComprobantes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroIngresoComprobantes.ForeColor = System.Drawing.Color.White;
            this.btnRegistroIngresoComprobantes.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroIngresoComprobantes.Image")));
            this.btnRegistroIngresoComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroIngresoComprobantes.Location = new System.Drawing.Point(0, 252);
            this.btnRegistroIngresoComprobantes.Name = "btnRegistroIngresoComprobantes";
            this.btnRegistroIngresoComprobantes.Size = new System.Drawing.Size(260, 56);
            this.btnRegistroIngresoComprobantes.TabIndex = 6;
            this.btnRegistroIngresoComprobantes.Text = "Registro Ingreso Comprobantes";
            this.btnRegistroIngresoComprobantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroIngresoComprobantes.UseVisualStyleBackColor = true;
            this.btnRegistroIngresoComprobantes.Click += new System.EventHandler(this.btnRegistroIngresoComprobantes_Click);
            // 
            // btnRegistroTransferencias
            // 
            this.btnRegistroTransferencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroTransferencias.FlatAppearance.BorderSize = 0;
            this.btnRegistroTransferencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnRegistroTransferencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnRegistroTransferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroTransferencias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroTransferencias.ForeColor = System.Drawing.Color.White;
            this.btnRegistroTransferencias.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroTransferencias.Image")));
            this.btnRegistroTransferencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroTransferencias.Location = new System.Drawing.Point(3, 314);
            this.btnRegistroTransferencias.Name = "btnRegistroTransferencias";
            this.btnRegistroTransferencias.Size = new System.Drawing.Size(260, 56);
            this.btnRegistroTransferencias.TabIndex = 5;
            this.btnRegistroTransferencias.Text = "Registro\r\nTransferencias";
            this.btnRegistroTransferencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroTransferencias.UseVisualStyleBackColor = true;
            this.btnRegistroTransferencias.Click += new System.EventHandler(this.btnRegistroTransferencias_Click);
            // 
            // btnIngresarPedido
            // 
            this.btnIngresarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarPedido.FlatAppearance.BorderSize = 0;
            this.btnIngresarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnIngresarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnIngresarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarPedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPedido.ForeColor = System.Drawing.Color.White;
            this.btnIngresarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarPedido.Image")));
            this.btnIngresarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarPedido.Location = new System.Drawing.Point(0, 195);
            this.btnIngresarPedido.Name = "btnIngresarPedido";
            this.btnIngresarPedido.Size = new System.Drawing.Size(260, 51);
            this.btnIngresarPedido.TabIndex = 4;
            this.btnIngresarPedido.Text = "Ingresar Pedido";
            this.btnIngresarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarPedido.UseVisualStyleBackColor = true;
            this.btnIngresarPedido.Click += new System.EventHandler(this.btnIngresarPedido_Click);
            // 
            // btnGenerarConsolidado
            // 
            this.btnGenerarConsolidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarConsolidado.FlatAppearance.BorderSize = 0;
            this.btnGenerarConsolidado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnGenerarConsolidado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnGenerarConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarConsolidado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarConsolidado.ForeColor = System.Drawing.Color.White;
            this.btnGenerarConsolidado.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarConsolidado.Image")));
            this.btnGenerarConsolidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarConsolidado.Location = new System.Drawing.Point(0, 138);
            this.btnGenerarConsolidado.Name = "btnGenerarConsolidado";
            this.btnGenerarConsolidado.Size = new System.Drawing.Size(260, 51);
            this.btnGenerarConsolidado.TabIndex = 3;
            this.btnGenerarConsolidado.Text = "Generar Consolidado";
            this.btnGenerarConsolidado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarConsolidado.UseVisualStyleBackColor = true;
            this.btnGenerarConsolidado.Click += new System.EventHandler(this.btnGenerarConsolidado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 701);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(260, 51);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOcultarMenu
            // 
            this.btnOcultarMenu.AutoSize = true;
            this.btnOcultarMenu.BackColor = System.Drawing.Color.Black;
            this.btnOcultarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarMenu.FlatAppearance.BorderSize = 0;
            this.btnOcultarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOcultarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOcultarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarMenu.ForeColor = System.Drawing.Color.White;
            this.btnOcultarMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultarMenu.Image")));
            this.btnOcultarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcultarMenu.Location = new System.Drawing.Point(0, 0);
            this.btnOcultarMenu.Name = "btnOcultarMenu";
            this.btnOcultarMenu.Size = new System.Drawing.Size(260, 51);
            this.btnOcultarMenu.TabIndex = 1;
            this.btnOcultarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOcultarMenu.UseVisualStyleBackColor = false;
            this.btnOcultarMenu.Click += new System.EventHandler(this.btnOcultarMenu_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnInsumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(39)))), ((int)(((byte)(164)))));
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumos.ForeColor = System.Drawing.Color.White;
            this.btnInsumos.Image = ((System.Drawing.Image)(resources.GetObject("btnInsumos.Image")));
            this.btnInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumos.Location = new System.Drawing.Point(0, 81);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(260, 51);
            this.btnInsumos.TabIndex = 0;
            this.btnInsumos.Text = "Insumos y Mercadería";
            this.btnInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(260, 38);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1086, 801);
            this.panelPrincipal.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 839);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOcultarMenu;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnOcultar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarConsolidado;
        private System.Windows.Forms.Button btnRegistroIngresoComprobantes;
        private System.Windows.Forms.Button btnRegistroTransferencias;
        private System.Windows.Forms.Button btnIngresarPedido;
        private System.Windows.Forms.Button btnPedidosPendientes;
        private System.Windows.Forms.Button btnMermas;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnArticulosCaducar;
    }
}