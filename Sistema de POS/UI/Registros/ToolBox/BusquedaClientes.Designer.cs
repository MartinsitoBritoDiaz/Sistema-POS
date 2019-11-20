namespace Sistema_de_POS.UI.Registros.ToolBox
{
    partial class BusquedaClientes
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
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.AllowUserToAddRows = false;
            this.ClientesDataGridView.AllowUserToDeleteRows = false;
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgregarColumn,
            this.ProductIdColumn,
            this.NombreColumn});
            this.ClientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.RowHeadersWidth = 10;
            this.ClientesDataGridView.RowTemplate.Height = 24;
            this.ClientesDataGridView.Size = new System.Drawing.Size(461, 579);
            this.ClientesDataGridView.TabIndex = 3;
            // 
            // AgregarColumn
            // 
            this.AgregarColumn.HeaderText = "Agregar";
            this.AgregarColumn.MinimumWidth = 6;
            this.AgregarColumn.Name = "AgregarColumn";
            this.AgregarColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgregarColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AgregarColumn.Width = 75;
            // 
            // ProductIdColumn
            // 
            this.ProductIdColumn.HeaderText = "Id";
            this.ProductIdColumn.MinimumWidth = 6;
            this.ProductIdColumn.Name = "ProductIdColumn";
            this.ProductIdColumn.Width = 125;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.MinimumWidth = 6;
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.Agregarbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 48);
            this.panel2.TabIndex = 22;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Agregarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregarbutton.FlatAppearance.BorderSize = 0;
            this.Agregarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Agregarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarbutton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ForeColor = System.Drawing.Color.White;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.Location = new System.Drawing.Point(162, -2);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(114, 46);
            this.Agregarbutton.TabIndex = 44;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BusquedaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClientesDataGridView);
            this.Name = "BusquedaClientes";
            this.Text = "Busqueda clientes";
            this.Load += new System.EventHandler(this.BusquedaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AgregarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}