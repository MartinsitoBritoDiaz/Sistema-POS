namespace Sistema_de_POS.UI.Registros
{
    partial class rAperturaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAperturaCaja));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaBilletes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalEfectivoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ComentarioTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.BarraTituloPanel = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.MinimizarButton = new System.Windows.Forms.PictureBox();
            this.CerrarButton = new System.Windows.Forms.PictureBox();
            this.CajaTextBox = new System.Windows.Forms.TextBox();
            this.CajaLabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.BarraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaBilletes,
            this.ColumnaCantidad,
            this.ColumnaSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(22, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(370, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
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
            this.ColumnaSubtotal.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(72, 37);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.IDNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(72, 96);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(127, 20);
            this.UsuarioTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(72, 66);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.FechaDateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Efectivo";
            // 
            // TotalEfectivoTextBox
            // 
            this.TotalEfectivoTextBox.Location = new System.Drawing.Point(92, 377);
            this.TotalEfectivoTextBox.Name = "TotalEfectivoTextBox";
            this.TotalEfectivoTextBox.Size = new System.Drawing.Size(110, 20);
            this.TotalEfectivoTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Comentario";
            // 
            // ComentarioTextBox
            // 
            this.ComentarioTextBox.Location = new System.Drawing.Point(92, 407);
            this.ComentarioTextBox.Multiline = true;
            this.ComentarioTextBox.Name = "ComentarioTextBox";
            this.ComentarioTextBox.Size = new System.Drawing.Size(172, 35);
            this.ComentarioTextBox.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.NuevoButton);
            this.panel2.Controls.Add(this.BorrarButton);
            this.panel2.Controls.Add(this.Guardarbutton);
            this.panel2.Location = new System.Drawing.Point(-24, 462);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 39);
            this.panel2.TabIndex = 25;
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
            this.BorrarButton.Location = new System.Drawing.Point(332, 0);
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
            this.Guardarbutton.Location = new System.Drawing.Point(188, 0);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 37);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // BarraTituloPanel
            // 
            this.BarraTituloPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTituloPanel.Controls.Add(this.Label);
            this.BarraTituloPanel.Controls.Add(this.MinimizarButton);
            this.BarraTituloPanel.Controls.Add(this.CerrarButton);
            this.BarraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraTituloPanel.Name = "BarraTituloPanel";
            this.BarraTituloPanel.Size = new System.Drawing.Size(419, 28);
            this.BarraTituloPanel.TabIndex = 48;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(133, 5);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(131, 17);
            this.Label.TabIndex = 47;
            this.Label.Text = "Apertura de Caja";
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.Image")));
            this.MinimizarButton.Location = new System.Drawing.Point(369, 2);
            this.MinimizarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.CerrarButton.Location = new System.Drawing.Point(396, 2);
            this.CerrarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(19, 20);
            this.CerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CajaTextBox
            // 
            this.CajaTextBox.Location = new System.Drawing.Point(309, 40);
            this.CajaTextBox.Name = "CajaTextBox";
            this.CajaTextBox.Size = new System.Drawing.Size(83, 20);
            this.CajaTextBox.TabIndex = 49;
            // 
            // CajaLabel
            // 
            this.CajaLabel.AutoSize = true;
            this.CajaLabel.Location = new System.Drawing.Point(266, 43);
            this.CajaLabel.Name = "CajaLabel";
            this.CajaLabel.Size = new System.Drawing.Size(28, 13);
            this.CajaLabel.TabIndex = 50;
            this.CajaLabel.Text = "Caja";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 501);
            this.Controls.Add(this.CajaLabel);
            this.Controls.Add(this.CajaTextBox);
            this.Controls.Add(this.BarraTituloPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ComentarioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalEfectivoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rAperturaCaja";
            this.Text = "rAperturaCaja";
            this.Load += new System.EventHandler(this.rAperturaCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.BarraTituloPanel.ResumeLayout(false);
            this.BarraTituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalEfectivoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ComentarioTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBilletes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaSubtotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Panel BarraTituloPanel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox MinimizarButton;
        private System.Windows.Forms.PictureBox CerrarButton;
        private System.Windows.Forms.TextBox CajaTextBox;
        private System.Windows.Forms.Label CajaLabel;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}