﻿namespace Sistema_de_POS.UI.Registros
{
    partial class rCierreCaja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCierreCaja));
            this.BarraTituloPanel = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.MinimizarButton = new System.Windows.Forms.PictureBox();
            this.CerrarButton = new System.Windows.Forms.PictureBox();
            this.CierreCajaTabControl = new System.Windows.Forms.TabControl();
            this.CierreEfectivoTabPage = new System.Windows.Forms.TabPage();
            this.EfectivoDGV = new System.Windows.Forms.DataGridView();
            this.ColumnaBilletes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreditoDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DSTGTextBox = new System.Windows.Forms.TextBox();
            this.DSTTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DSETextBox = new System.Windows.Forms.TextBox();
            this.TotalGeneralTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalTarjetaCreditoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComentarioTextBox = new System.Windows.Forms.TextBox();
            this.TotalEfectivoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.ColumnaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).BeginInit();
            this.CierreCajaTabControl.SuspendLayout();
            this.CierreEfectivoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTituloPanel
            // 
            this.BarraTituloPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTituloPanel.Controls.Add(this.Label);
            this.BarraTituloPanel.Controls.Add(this.MinimizarButton);
            this.BarraTituloPanel.Controls.Add(this.CerrarButton);
            this.BarraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BarraTituloPanel.Name = "BarraTituloPanel";
            this.BarraTituloPanel.Size = new System.Drawing.Size(539, 28);
            this.BarraTituloPanel.TabIndex = 48;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(170, 6);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(112, 17);
            this.Label.TabIndex = 47;
            this.Label.Text = "Cierre de Caja";
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.Image")));
            this.MinimizarButton.Location = new System.Drawing.Point(489, 2);
            this.MinimizarButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizarButton.Name = "MinimizarButton";
            this.MinimizarButton.Size = new System.Drawing.Size(19, 20);
            this.MinimizarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarButton.TabIndex = 4;
            this.MinimizarButton.TabStop = false;
            this.MinimizarButton.Click += new System.EventHandler(this.MinimizarButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("CerrarButton.Image")));
            this.CerrarButton.Location = new System.Drawing.Point(516, 2);
            this.CerrarButton.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(19, 20);
            this.CerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CierreCajaTabControl
            // 
            this.CierreCajaTabControl.Controls.Add(this.CierreEfectivoTabPage);
            this.CierreCajaTabControl.Controls.Add(this.tabPage2);
            this.CierreCajaTabControl.Location = new System.Drawing.Point(0, 97);
            this.CierreCajaTabControl.Multiline = true;
            this.CierreCajaTabControl.Name = "CierreCajaTabControl";
            this.CierreCajaTabControl.SelectedIndex = 0;
            this.CierreCajaTabControl.Size = new System.Drawing.Size(535, 273);
            this.CierreCajaTabControl.TabIndex = 49;
            // 
            // CierreEfectivoTabPage
            // 
            this.CierreEfectivoTabPage.Controls.Add(this.EfectivoDGV);
            this.CierreEfectivoTabPage.Location = new System.Drawing.Point(4, 22);
            this.CierreEfectivoTabPage.Name = "CierreEfectivoTabPage";
            this.CierreEfectivoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CierreEfectivoTabPage.Size = new System.Drawing.Size(527, 247);
            this.CierreEfectivoTabPage.TabIndex = 0;
            this.CierreEfectivoTabPage.Text = "Efectivo";
            this.CierreEfectivoTabPage.UseVisualStyleBackColor = true;
            // 
            // EfectivoDGV
            // 
            this.EfectivoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EfectivoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaBilletes,
            this.ColumnaCantidad,
            this.ColumnaSubtotal});
            this.EfectivoDGV.Location = new System.Drawing.Point(8, 0);
            this.EfectivoDGV.Name = "EfectivoDGV";
            this.EfectivoDGV.RowHeadersWidth = 51;
            this.EfectivoDGV.Size = new System.Drawing.Size(442, 237);
            this.EfectivoDGV.TabIndex = 61;
            this.EfectivoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EfectivoDGV_CellContentClick);
            this.EfectivoDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // ColumnaBilletes
            // 
            this.ColumnaBilletes.HeaderText = "Denominacion";
            this.ColumnaBilletes.MinimumWidth = 6;
            this.ColumnaBilletes.Name = "ColumnaBilletes";
            this.ColumnaBilletes.ReadOnly = true;
            this.ColumnaBilletes.Width = 125;
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.MinimumWidth = 6;
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.Width = 125;
            // 
            // ColumnaSubtotal
            // 
            this.ColumnaSubtotal.HeaderText = "Subtotal";
            this.ColumnaSubtotal.MinimumWidth = 6;
            this.ColumnaSubtotal.Name = "ColumnaSubtotal";
            this.ColumnaSubtotal.ReadOnly = true;
            this.ColumnaSubtotal.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CreditoDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(527, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credito";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreditoDGV
            // 
            this.CreditoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreditoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaReferencia,
            this.ColumnaMonto});
            this.CreditoDGV.Location = new System.Drawing.Point(3, 6);
            this.CreditoDGV.Name = "CreditoDGV";
            this.CreditoDGV.RowHeadersWidth = 51;
            this.CreditoDGV.Size = new System.Drawing.Size(454, 238);
            this.CreditoDGV.TabIndex = 0;
            this.CreditoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreditoDGV_CellContentClick);
            this.CreditoDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreditoDGV_CellEndEdit);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.NuevoButton);
            this.panel2.Controls.Add(this.BorrarButton);
            this.panel2.Controls.Add(this.Guardarbutton);
            this.panel2.Location = new System.Drawing.Point(0, 526);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 39);
            this.panel2.TabIndex = 51;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.FlatAppearance.BorderSize = 0;
            this.NuevoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ForeColor = System.Drawing.Color.White;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.Location = new System.Drawing.Point(36, 0);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 39);
            this.NuevoButton.TabIndex = 46;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.FlatAppearance.BorderSize = 0;
            this.BorrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BorrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarButton.ForeColor = System.Drawing.Color.White;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButton.Location = new System.Drawing.Point(359, 1);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(84, 37);
            this.BorrarButton.TabIndex = 45;
            this.BorrarButton.Text = "Salir";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.ForeColor = System.Drawing.Color.White;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(216, -1);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 37);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 27);
            this.button1.TabIndex = 77;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(65, 69);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.FechaDateTimePicker.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Fecha";
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(65, 40);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.IDNumericUpDown.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Id";
            // 
            // DSTGTextBox
            // 
            this.DSTGTextBox.Location = new System.Drawing.Point(289, 449);
            this.DSTGTextBox.Name = "DSTGTextBox";
            this.DSTGTextBox.ReadOnly = true;
            this.DSTGTextBox.Size = new System.Drawing.Size(110, 20);
            this.DSTGTextBox.TabIndex = 95;
            this.DSTGTextBox.TextChanged += new System.EventHandler(this.DSTGTextBox_TextChanged);
            // 
            // DSTTextBox
            // 
            this.DSTTextBox.Location = new System.Drawing.Point(289, 424);
            this.DSTTextBox.Name = "DSTTextBox";
            this.DSTTextBox.ReadOnly = true;
            this.DSTTextBox.Size = new System.Drawing.Size(110, 20);
            this.DSTTextBox.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Datos del Sistema:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Datos del Cajero:";
            // 
            // DSETextBox
            // 
            this.DSETextBox.Location = new System.Drawing.Point(289, 398);
            this.DSETextBox.Name = "DSETextBox";
            this.DSETextBox.ReadOnly = true;
            this.DSETextBox.Size = new System.Drawing.Size(110, 20);
            this.DSETextBox.TabIndex = 91;
            this.DSETextBox.TextChanged += new System.EventHandler(this.DSETextBox_TextChanged);
            // 
            // TotalGeneralTextBox
            // 
            this.TotalGeneralTextBox.Location = new System.Drawing.Point(95, 449);
            this.TotalGeneralTextBox.Name = "TotalGeneralTextBox";
            this.TotalGeneralTextBox.ReadOnly = true;
            this.TotalGeneralTextBox.Size = new System.Drawing.Size(110, 20);
            this.TotalGeneralTextBox.TabIndex = 90;
            this.TotalGeneralTextBox.Text = "0";
            this.TotalGeneralTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Total General";
            // 
            // TotalTarjetaCreditoTextBox
            // 
            this.TotalTarjetaCreditoTextBox.Location = new System.Drawing.Point(95, 424);
            this.TotalTarjetaCreditoTextBox.Name = "TotalTarjetaCreditoTextBox";
            this.TotalTarjetaCreditoTextBox.ReadOnly = true;
            this.TotalTarjetaCreditoTextBox.Size = new System.Drawing.Size(110, 20);
            this.TotalTarjetaCreditoTextBox.TabIndex = 88;
            this.TotalTarjetaCreditoTextBox.Text = "0";
            this.TotalTarjetaCreditoTextBox.TextChanged += new System.EventHandler(this.TotalTarjetaCreditoTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Tarjeta Crédito";
            // 
            // ComentarioTextBox
            // 
            this.ComentarioTextBox.Location = new System.Drawing.Point(95, 475);
            this.ComentarioTextBox.Multiline = true;
            this.ComentarioTextBox.Name = "ComentarioTextBox";
            this.ComentarioTextBox.Size = new System.Drawing.Size(164, 44);
            this.ComentarioTextBox.TabIndex = 86;
            this.ComentarioTextBox.TextChanged += new System.EventHandler(this.ComentarioTextBox_TextChanged);
            // 
            // TotalEfectivoTextBox
            // 
            this.TotalEfectivoTextBox.Location = new System.Drawing.Point(95, 398);
            this.TotalEfectivoTextBox.Name = "TotalEfectivoTextBox";
            this.TotalEfectivoTextBox.ReadOnly = true;
            this.TotalEfectivoTextBox.Size = new System.Drawing.Size(110, 20);
            this.TotalEfectivoTextBox.TabIndex = 84;
            this.TotalEfectivoTextBox.Text = "0";
            this.TotalEfectivoTextBox.TextChanged += new System.EventHandler(this.TotalEfectivoTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Total Efectivo";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 99;
            this.label11.Text = "Comentario";
            // 
            // ColumnaReferencia
            // 
            this.ColumnaReferencia.HeaderText = "Referencia";
            this.ColumnaReferencia.MinimumWidth = 6;
            this.ColumnaReferencia.Name = "ColumnaReferencia";
            this.ColumnaReferencia.ReadOnly = true;
            this.ColumnaReferencia.Width = 200;
            // 
            // ColumnaMonto
            // 
            this.ColumnaMonto.HeaderText = "Monto";
            this.ColumnaMonto.MinimumWidth = 6;
            this.ColumnaMonto.Name = "ColumnaMonto";
            this.ColumnaMonto.Width = 125;
            // 
            // rCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 565);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DSTGTextBox);
            this.Controls.Add(this.DSTTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DSETextBox);
            this.Controls.Add(this.TotalGeneralTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalTarjetaCreditoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComentarioTextBox);
            this.Controls.Add(this.TotalEfectivoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CierreCajaTabControl);
            this.Controls.Add(this.BarraTituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rCierreCaja";
            this.Text = "rCierreCaja";
            this.Load += new System.EventHandler(this.rCierreCaja_Load);
            this.BarraTituloPanel.ResumeLayout(false);
            this.BarraTituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).EndInit();
            this.CierreCajaTabControl.ResumeLayout(false);
            this.CierreEfectivoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EfectivoDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreditoDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloPanel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox MinimizarButton;
        private System.Windows.Forms.PictureBox CerrarButton;
        private System.Windows.Forms.TabControl CierreCajaTabControl;
        private System.Windows.Forms.TabPage CierreEfectivoTabPage;
        private System.Windows.Forms.DataGridView EfectivoDGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.DataGridView CreditoDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DSTGTextBox;
        private System.Windows.Forms.TextBox DSTTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DSETextBox;
        private System.Windows.Forms.TextBox TotalGeneralTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalTarjetaCreditoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ComentarioTextBox;
        private System.Windows.Forms.TextBox TotalEfectivoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBilletes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMonto;
    }
}