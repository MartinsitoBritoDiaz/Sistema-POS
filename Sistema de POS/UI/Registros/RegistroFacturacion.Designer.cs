namespace Sistema_de_POS.UI.Registros
{
    partial class RegistroFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFacturacion));
            this.RemoverButton = new System.Windows.Forms.Button();
            this.ProductosgroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UnidadComboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.PrecioUnitariotextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientegroupBox = new System.Windows.Forms.GroupBox();
            this.CondicioncomboBox = new System.Windows.Forms.ComboBox();
            this.TipoPagocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.TotalVentatextBox = new System.Windows.Forms.TextBox();
            this.DescuentostextBox = new System.Windows.Forms.TextBox();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.ClientegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(25, 471);
            this.RemoverButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(183, 28);
            this.RemoverButton.TabIndex = 40;
            this.RemoverButton.Text = "Remover Producto";
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // ProductosgroupBox
            // 
            this.ProductosgroupBox.Controls.Add(this.label13);
            this.ProductosgroupBox.Controls.Add(this.UnidadComboBox);
            this.ProductosgroupBox.Controls.Add(this.Agregarbutton);
            this.ProductosgroupBox.Controls.Add(this.PrecioUnitariotextBox);
            this.ProductosgroupBox.Controls.Add(this.label12);
            this.ProductosgroupBox.Controls.Add(this.DescripcionTextBox);
            this.ProductosgroupBox.Controls.Add(this.label11);
            this.ProductosgroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.ProductosgroupBox.Controls.Add(this.label10);
            this.ProductosgroupBox.Controls.Add(this.DetalledataGridView);
            this.ProductosgroupBox.Controls.Add(this.label5);
            this.ProductosgroupBox.Location = new System.Drawing.Point(13, 142);
            this.ProductosgroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductosgroupBox.Name = "ProductosgroupBox";
            this.ProductosgroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ProductosgroupBox.Size = new System.Drawing.Size(671, 357);
            this.ProductosgroupBox.TabIndex = 37;
            this.ProductosgroupBox.TabStop = false;
            this.ProductosgroupBox.Text = "Productos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Unidad";
            // 
            // UnidadComboBox
            // 
            this.UnidadComboBox.FormattingEnabled = true;
            this.UnidadComboBox.Items.AddRange(new object[] {
            "Kilos",
            "Libras",
            "Onzas",
            "Paquetes",
            "Unidades",
            "Porciones"});
            this.UnidadComboBox.Location = new System.Drawing.Point(429, 26);
            this.UnidadComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnidadComboBox.Name = "UnidadComboBox";
            this.UnidadComboBox.Size = new System.Drawing.Size(141, 24);
            this.UnidadComboBox.TabIndex = 20;
            this.UnidadComboBox.SelectedIndexChanged += new System.EventHandler(this.UnidadComboBox_SelectedIndexChanged);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.Location = new System.Drawing.Point(592, 11);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(48, 39);
            this.Agregarbutton.TabIndex = 19;
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // PrecioUnitariotextBox
            // 
            this.PrecioUnitariotextBox.Location = new System.Drawing.Point(121, 90);
            this.PrecioUnitariotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioUnitariotextBox.Name = "PrecioUnitariotextBox";
            this.PrecioUnitariotextBox.Size = new System.Drawing.Size(517, 22);
            this.PrecioUnitariotextBox.TabIndex = 5;
            this.PrecioUnitariotextBox.TextChanged += new System.EventHandler(this.PrecioUnitariotextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Precio Unitario:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(121, 58);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(517, 22);
            this.DescripcionTextBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Descripcion:";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(121, 26);
            this.CantidadnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(180, 22);
            this.CantidadnumericUpDown.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cantidad:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(13, 146);
            this.DetalledataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.RowHeadersWidth = 51;
            this.DetalledataGridView.Size = new System.Drawing.Size(627, 175);
            this.DetalledataGridView.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lista de productos:";
            // 
            // ClientegroupBox
            // 
            this.ClientegroupBox.Controls.Add(this.CondicioncomboBox);
            this.ClientegroupBox.Controls.Add(this.TipoPagocomboBox);
            this.ClientegroupBox.Controls.Add(this.label1);
            this.ClientegroupBox.Controls.Add(this.label9);
            this.ClientegroupBox.Controls.Add(this.label2);
            this.ClientegroupBox.Controls.Add(this.Buscarbutton);
            this.ClientegroupBox.Controls.Add(this.label3);
            this.ClientegroupBox.Controls.Add(this.label4);
            this.ClientegroupBox.Controls.Add(this.IDnumericUpDown);
            this.ClientegroupBox.Controls.Add(this.FechadateTimePicker);
            this.ClientegroupBox.Controls.Add(this.ClientetextBox);
            this.ClientegroupBox.Location = new System.Drawing.Point(13, 6);
            this.ClientegroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientegroupBox.Name = "ClientegroupBox";
            this.ClientegroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ClientegroupBox.Size = new System.Drawing.Size(671, 129);
            this.ClientegroupBox.TabIndex = 36;
            this.ClientegroupBox.TabStop = false;
            this.ClientegroupBox.Text = "Cliente";
            this.ClientegroupBox.Enter += new System.EventHandler(this.ClientegroupBox_Enter);
            // 
            // CondicioncomboBox
            // 
            this.CondicioncomboBox.FormattingEnabled = true;
            this.CondicioncomboBox.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.CondicioncomboBox.Location = new System.Drawing.Point(91, 94);
            this.CondicioncomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CondicioncomboBox.Name = "CondicioncomboBox";
            this.CondicioncomboBox.Size = new System.Drawing.Size(141, 24);
            this.CondicioncomboBox.TabIndex = 11;
            // 
            // TipoPagocomboBox
            // 
            this.TipoPagocomboBox.FormattingEnabled = true;
            this.TipoPagocomboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito",
            "Cheque"});
            this.TipoPagocomboBox.Location = new System.Drawing.Point(499, 97);
            this.TipoPagocomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoPagocomboBox.Name = "TipoPagocomboBox";
            this.TipoPagocomboBox.Size = new System.Drawing.Size(141, 24);
            this.TipoPagocomboBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(195, 15);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(107, 43);
            this.Buscarbutton.TabIndex = 19;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Condicion:";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(91, 26);
            this.IDnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(93, 22);
            this.IDnumericUpDown.TabIndex = 8;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(535, 26);
            this.FechadateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(104, 22);
            this.FechadateTimePicker.TabIndex = 9;
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.Location = new System.Drawing.Point(91, 66);
            this.ClientetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(548, 22);
            this.ClientetextBox.TabIndex = 10;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(559, 657);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(93, 58);
            this.Eliminarbutton.TabIndex = 35;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(325, 657);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(96, 58);
            this.Guardarbutton.TabIndex = 34;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(104, 657);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(93, 58);
            this.Nuevobutton.TabIndex = 33;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // TotalVentatextBox
            // 
            this.TotalVentatextBox.Location = new System.Drawing.Point(104, 593);
            this.TotalVentatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalVentatextBox.Name = "TotalVentatextBox";
            this.TotalVentatextBox.Size = new System.Drawing.Size(257, 22);
            this.TotalVentatextBox.TabIndex = 32;
            this.TotalVentatextBox.TextChanged += new System.EventHandler(this.TotalVentatextBox_TextChanged);
            // 
            // DescuentostextBox
            // 
            this.DescuentostextBox.Location = new System.Drawing.Point(105, 561);
            this.DescuentostextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescuentostextBox.Name = "DescuentostextBox";
            this.DescuentostextBox.Size = new System.Drawing.Size(256, 22);
            this.DescuentostextBox.TabIndex = 31;
            this.DescuentostextBox.TextChanged += new System.EventHandler(this.DescuentostextBox_TextChanged);
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(104, 528);
            this.SubtotaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.Size = new System.Drawing.Size(257, 22);
            this.SubtotaltextBox.TabIndex = 30;
            this.SubtotaltextBox.TextChanged += new System.EventHandler(this.SubtotaltextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 597);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 565);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Descuentos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 530);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Subtotal:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistroFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 734);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.ProductosgroupBox);
            this.Controls.Add(this.ClientegroupBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TotalVentatextBox);
            this.Controls.Add(this.DescuentostextBox);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroFacturacion";
            this.Text = "RegsitroFacturacion";
            this.Load += new System.EventHandler(this.RegistroFacturacion_Load);
            this.ProductosgroupBox.ResumeLayout(false);
            this.ProductosgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ClientegroupBox.ResumeLayout(false);
            this.ClientegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.GroupBox ProductosgroupBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.TextBox PrecioUnitariotextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox ClientegroupBox;
        private System.Windows.Forms.ComboBox CondicioncomboBox;
        private System.Windows.Forms.ComboBox TipoPagocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox ClientetextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox TotalVentatextBox;
        private System.Windows.Forms.TextBox DescuentostextBox;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox UnidadComboBox;
    }
}