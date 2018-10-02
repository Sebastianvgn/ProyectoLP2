namespace Formularios
{
    partial class frmGenerarConsolidado
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
            this.mCFecProceso = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecProceso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbActualizarEstado = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chbConsolidado = new System.Windows.Forms.CheckBox();
            this.chbPerecible = new System.Windows.Forms.CheckBox();
            this.chbNoPerecible = new System.Windows.Forms.CheckBox();
            this.btnConsolidarOP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbRecibir = new System.Windows.Forms.CheckBox();
            this.chbDespachar = new System.Windows.Forms.CheckBox();
            this.btnRevertir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbDiario = new System.Windows.Forms.CheckBox();
            this.chbSemanal = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mCFecProceso
            // 
            this.mCFecProceso.Location = new System.Drawing.Point(428, 103);
            this.mCFecProceso.Name = "mCFecProceso";
            this.mCFecProceso.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Agrupar Por";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo de Pedido";
            // 
            // lblFecProceso
            // 
            this.lblFecProceso.AutoSize = true;
            this.lblFecProceso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecProceso.Location = new System.Drawing.Point(271, 163);
            this.lblFecProceso.Name = "lblFecProceso";
            this.lblFecProceso.Size = new System.Drawing.Size(145, 23);
            this.lblFecProceso.TabIndex = 23;
            this.lblFecProceso.Text = "Fecha Proceso";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tipo de Produccion";
            // 
            // chbActualizarEstado
            // 
            this.chbActualizarEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbActualizarEstado.AutoSize = true;
            this.chbActualizarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbActualizarEstado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbActualizarEstado.Location = new System.Drawing.Point(289, 292);
            this.chbActualizarEstado.Name = "chbActualizarEstado";
            this.chbActualizarEstado.Size = new System.Drawing.Size(188, 26);
            this.chbActualizarEstado.TabIndex = 24;
            this.chbActualizarEstado.Text = "Actualizar Estado";
            this.chbActualizarEstado.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.chbConsolidado);
            this.panel3.Controls.Add(this.chbPerecible);
            this.panel3.Controls.Add(this.chbNoPerecible);
            this.panel3.Location = new System.Drawing.Point(288, 596);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 74);
            this.panel3.TabIndex = 29;
            // 
            // chbConsolidado
            // 
            this.chbConsolidado.AutoSize = true;
            this.chbConsolidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbConsolidado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbConsolidado.Location = new System.Drawing.Point(14, 18);
            this.chbConsolidado.Name = "chbConsolidado";
            this.chbConsolidado.Size = new System.Drawing.Size(144, 26);
            this.chbConsolidado.TabIndex = 10;
            this.chbConsolidado.Text = "Consolidado";
            this.chbConsolidado.UseVisualStyleBackColor = true;
            // 
            // chbPerecible
            // 
            this.chbPerecible.AutoSize = true;
            this.chbPerecible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbPerecible.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPerecible.Location = new System.Drawing.Point(193, 18);
            this.chbPerecible.Name = "chbPerecible";
            this.chbPerecible.Size = new System.Drawing.Size(113, 26);
            this.chbPerecible.TabIndex = 11;
            this.chbPerecible.Text = "Perecible";
            this.chbPerecible.UseVisualStyleBackColor = true;
            // 
            // chbNoPerecible
            // 
            this.chbNoPerecible.AutoSize = true;
            this.chbNoPerecible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbNoPerecible.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNoPerecible.Location = new System.Drawing.Point(360, 18);
            this.chbNoPerecible.Name = "chbNoPerecible";
            this.chbNoPerecible.Size = new System.Drawing.Size(144, 26);
            this.chbNoPerecible.TabIndex = 12;
            this.chbNoPerecible.Text = "No Perecible";
            this.chbNoPerecible.UseVisualStyleBackColor = true;
            // 
            // btnConsolidarOP
            // 
            this.btnConsolidarOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsolidarOP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsolidarOP.Location = new System.Drawing.Point(704, 163);
            this.btnConsolidarOP.Name = "btnConsolidarOP";
            this.btnConsolidarOP.Size = new System.Drawing.Size(135, 35);
            this.btnConsolidarOP.TabIndex = 25;
            this.btnConsolidarOP.Text = "Consolidar OP";
            this.btnConsolidarOP.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chbRecibir);
            this.panel2.Controls.Add(this.chbDespachar);
            this.panel2.Location = new System.Drawing.Point(289, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 74);
            this.panel2.TabIndex = 28;
            // 
            // chbRecibir
            // 
            this.chbRecibir.AutoSize = true;
            this.chbRecibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbRecibir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRecibir.Location = new System.Drawing.Point(103, 21);
            this.chbRecibir.Name = "chbRecibir";
            this.chbRecibir.Size = new System.Drawing.Size(90, 26);
            this.chbRecibir.TabIndex = 8;
            this.chbRecibir.Text = "Recibir";
            this.chbRecibir.UseVisualStyleBackColor = true;
            // 
            // chbDespachar
            // 
            this.chbDespachar.AutoSize = true;
            this.chbDespachar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbDespachar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDespachar.Location = new System.Drawing.Point(306, 21);
            this.chbDespachar.Name = "chbDespachar";
            this.chbDespachar.Size = new System.Drawing.Size(131, 26);
            this.chbDespachar.TabIndex = 9;
            this.chbDespachar.Text = "Despachar";
            this.chbDespachar.UseVisualStyleBackColor = true;
            // 
            // btnRevertir
            // 
            this.btnRevertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevertir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevertir.Location = new System.Drawing.Point(704, 286);
            this.btnRevertir.Name = "btnRevertir";
            this.btnRevertir.Size = new System.Drawing.Size(135, 32);
            this.btnRevertir.TabIndex = 26;
            this.btnRevertir.Text = "Revertir";
            this.btnRevertir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chbDiario);
            this.panel1.Controls.Add(this.chbSemanal);
            this.panel1.Location = new System.Drawing.Point(289, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 74);
            this.panel1.TabIndex = 27;
            // 
            // chbDiario
            // 
            this.chbDiario.AutoSize = true;
            this.chbDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbDiario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDiario.Location = new System.Drawing.Point(103, 18);
            this.chbDiario.Name = "chbDiario";
            this.chbDiario.Size = new System.Drawing.Size(80, 26);
            this.chbDiario.TabIndex = 6;
            this.chbDiario.Text = "Diario";
            this.chbDiario.UseVisualStyleBackColor = true;
            // 
            // chbSemanal
            // 
            this.chbSemanal.AutoSize = true;
            this.chbSemanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbSemanal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSemanal.Location = new System.Drawing.Point(306, 18);
            this.chbSemanal.Name = "chbSemanal";
            this.chbSemanal.Size = new System.Drawing.Size(108, 26);
            this.chbSemanal.TabIndex = 7;
            this.chbSemanal.Text = "Semanal";
            this.chbSemanal.UseVisualStyleBackColor = true;
            // 
            // frmGenerarConsolidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 801);
            this.Controls.Add(this.mCFecProceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecProceso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbActualizarEstado);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConsolidarOP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRevertir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerarConsolidado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consolidacion de Ordenes de Pedido";
            this.Load += new System.EventHandler(this.frmGenerarConsolidado_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCFecProceso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecProceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbActualizarEstado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chbConsolidado;
        private System.Windows.Forms.CheckBox chbPerecible;
        private System.Windows.Forms.CheckBox chbNoPerecible;
        private System.Windows.Forms.Button btnConsolidarOP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbRecibir;
        private System.Windows.Forms.CheckBox chbDespachar;
        private System.Windows.Forms.Button btnRevertir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbDiario;
        private System.Windows.Forms.CheckBox chbSemanal;
    }
}