namespace Sistema_de_POS.UI.Registros
{
    partial class rProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.Label = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.BarraTituloPanel = new System.Windows.Forms.Panel();
            this.MinimizarButton = new System.Windows.Forms.PictureBox();
            this.CerrarButton = new System.Windows.Forms.PictureBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImpuestoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.CelularLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UnidadComboBox = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.BarraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(220, 56);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(118, 29);
            this.Label.TabIndex = 84;
            this.Label.Text = "Producto";
            this.Label.Click += new System.EventHandler(this.Label_Click_1);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(461, 56);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(47, 40);
            this.BuscarButton.TabIndex = 81;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.NuevoButton);
            this.panel2.Controls.Add(this.BorrarButton);
            this.panel2.Controls.Add(this.Guardarbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 48);
            this.panel2.TabIndex = 85;
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
            this.NuevoButton.Location = new System.Drawing.Point(4, 0);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(119, 48);
            this.NuevoButton.TabIndex = 46;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.FlatAppearance.BorderSize = 0;
            this.BorrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BorrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarButton.ForeColor = System.Drawing.Color.White;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButton.Location = new System.Drawing.Point(426, 1);
            this.BorrarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(112, 46);
            this.BorrarButton.TabIndex = 45;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guardarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.ForeColor = System.Drawing.Color.White;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(213, -2);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(114, 46);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // BarraTituloPanel
            // 
            this.BarraTituloPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTituloPanel.Controls.Add(this.MinimizarButton);
            this.BarraTituloPanel.Controls.Add(this.CerrarButton);
            this.BarraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPanel.Name = "BarraTituloPanel";
            this.BarraTituloPanel.Size = new System.Drawing.Size(538, 34);
            this.BarraTituloPanel.TabIndex = 86;
            this.BarraTituloPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTituloPanel_Paint);
            this.BarraTituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPanel_MouseDown);
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.Image")));
            this.MinimizarButton.Location = new System.Drawing.Point(477, 3);
            this.MinimizarButton.Name = "MinimizarButton";
            this.MinimizarButton.Size = new System.Drawing.Size(25, 25);
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
            this.CerrarButton.Location = new System.Drawing.Point(508, 3);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(25, 25);
            this.CerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // ImpuestoTextBox
            // 
            this.ImpuestoTextBox.Location = new System.Drawing.Point(44, 446);
            this.ImpuestoTextBox.Name = "ImpuestoTextBox";
            this.ImpuestoTextBox.ReadOnly = true;
            this.ImpuestoTextBox.Size = new System.Drawing.Size(147, 22);
            this.ImpuestoTextBox.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "ITBIS:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(343, 262);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(165, 22);
            this.PrecioTextBox.TabIndex = 103;
            this.PrecioTextBox.TextChanged += new System.EventHandler(this.PrecioTextBox_TextChanged);
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Location = new System.Drawing.Point(51, 348);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(147, 22);
            this.ExistenciaTextBox.TabIndex = 102;
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Items.AddRange(new object[] {
            "Bebidas",
            "Comestible ",
            "Dulce"});
            this.CategoriaComboBox.Location = new System.Drawing.Point(45, 262);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(146, 24);
            this.CategoriaComboBox.TabIndex = 101;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreTextBox.Location = new System.Drawing.Point(343, 161);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(165, 22);
            this.NombreTextBox.TabIndex = 100;
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLabel.Location = new System.Drawing.Point(79, 309);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(89, 21);
            this.DireccionLabel.TabIndex = 99;
            this.DireccionLabel.Text = "Exitencia:";
            // 
            // CelularLabel
            // 
            this.CelularLabel.AutoSize = true;
            this.CelularLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularLabel.Location = new System.Drawing.Point(339, 309);
            this.CelularLabel.Name = "CelularLabel";
            this.CelularLabel.Size = new System.Drawing.Size(169, 21);
            this.CelularLabel.TabIndex = 98;
            this.CelularLabel.Text = "Unidad de medida";
            this.CelularLabel.Click += new System.EventHandler(this.CelularLabel_Click);
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(386, 220);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(66, 21);
            this.TelefonoLabel.TabIndex = 97;
            this.TelefonoLabel.Text = "Precio:";
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(79, 220);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(96, 21);
            this.CedulaLabel.TabIndex = 96;
            this.CedulaLabel.Text = "Categoria";
            // 
            // NombreLabel
            // 
            this.NombreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(386, 121);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(77, 21);
            this.NombreLabel.TabIndex = 95;
            this.NombreLabel.Text = "Nombre";
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(79, 121);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(111, 21);
            this.ClienteLabel.TabIndex = 94;
            this.ClienteLabel.Text = "Id producto";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(52, 161);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(146, 22);
            this.IDnumericUpDown.TabIndex = 93;
            this.IDnumericUpDown.ValueChanged += new System.EventHandler(this.IDnumericUpDown_ValueChanged);
            // 
            // UnidadComboBox
            // 
            this.UnidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnidadComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnidadComboBox.FormattingEnabled = true;
            this.UnidadComboBox.Items.AddRange(new object[] {
            "Libras",
            "Kilos",
            "Sacos",
            "Paquetes",
            "Unidades",
            "Onzas",
            "Porciones"});
            this.UnidadComboBox.Location = new System.Drawing.Point(343, 348);
            this.UnidadComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnidadComboBox.Name = "UnidadComboBox";
            this.UnidadComboBox.Size = new System.Drawing.Size(165, 26);
            this.UnidadComboBox.TabIndex = 107;
            this.UnidadComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 569);
            this.Controls.Add(this.UnidadComboBox);
            this.Controls.Add(this.ImpuestoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.CelularLabel);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.ClienteLabel);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.BarraTituloPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.BuscarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rProductos";
            this.Text = "rProductos";
            this.Load += new System.EventHandler(this.RProductos_Load);
            this.panel2.ResumeLayout(false);
            this.BarraTituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Panel BarraTituloPanel;
        private System.Windows.Forms.PictureBox MinimizarButton;
        private System.Windows.Forms.PictureBox CerrarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox ImpuestoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label CelularLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.ComboBox UnidadComboBox;
    }
}