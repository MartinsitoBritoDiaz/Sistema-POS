using Sistema_de_POS.Entidades;
using Sistema_de_POS.UI.Registros.ToolBox;
using SistemaPOS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sistema_de_POS.UI.Registros
{
    public partial class rFacturacion : Form
    {
        private Button Eliminarbutton;
        private Button Guardarbutton;
        private Button Nuevobutton;
        private Panel panel1;
        private PictureBox CerrarButton;
        private PictureBox MinimizarButton;
        private Label Label;
        private Panel BarraTituloPanel;
        private GroupBox ClientesGroupBox;
        private Label DescripcionLabel;
        private Label PrecioUnitarioLabel;
        private Label label3;
        private DataGridView DetalledataGridView;
        private TextBox NombreTextBox;
        private TextBox PrecioUnitariotextBox;
        private Label label4;
        private Button Agregarbutton;
        private GroupBox ProductosGroupBox;
        private Label label6;
        private Label label8;
        private TextBox SubtotaltextBox;
        private Label label9;
        private TextBox ItbisTextBox;
        private ErrorProvider MyErrorProvider;
        private IContainer components;
        private NumericUpDown ClienteIdnumericUpDown;
        private Label label5;
        private TextBox NombreClientetextBox;
        private Label ClienteLabel;
        private Label label12;
        private TextBox ImporteTextBox;
        private Button Buscarbutton;
        private DateTimePicker FechadateTimePicker;
        private Label FechaLabel;
        private NumericUpDown FacturaIdnumericUpDown;
        private Label IDLabel;
        private Button BusquedaPButton;
        private NumericUpDown CantidadnumericUpDown;
        private Label label2;
        private Button BusquedaClienteButton;
        private ComboBox UnidadcomboBox;
        private TextBox TotalVentatextBox;

        public List<DetalleProducto> Detalle { get; set; }

        public rFacturacion()
        {
            InitializeComponent();
            this.Detalle = new List<DetalleProducto>();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rFacturacion));
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.BarraTituloPanel = new System.Windows.Forms.Panel();
            this.ClientesGroupBox = new System.Windows.Forms.GroupBox();
            this.ClienteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.PrecioUnitarioLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.PrecioUnitariotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductosGroupBox = new System.Windows.Forms.GroupBox();
            this.UnidadcomboBox = new System.Windows.Forms.ComboBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.TotalVentatextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ItbisTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FacturaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IDLabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.MinimizarButton = new System.Windows.Forms.PictureBox();
            this.CerrarButton = new System.Windows.Forms.PictureBox();
            this.BusquedaPButton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.BusquedaClienteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.BarraTituloPanel.SuspendLayout();
            this.ClientesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.ProductosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.ForeColor = System.Drawing.Color.White;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(524, -5);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(109, 45);
            this.Eliminarbutton.TabIndex = 44;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
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
            this.Guardarbutton.Location = new System.Drawing.Point(298, -5);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(109, 45);
            this.Guardarbutton.TabIndex = 43;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.ForeColor = System.Drawing.Color.White;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(64, 0);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(92, 45);
            this.Nuevobutton.TabIndex = 42;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.Nuevobutton);
            this.panel1.Controls.Add(this.Eliminarbutton);
            this.panel1.Controls.Add(this.Guardarbutton);
            this.panel1.Location = new System.Drawing.Point(-64, 711);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 40);
            this.panel1.TabIndex = 45;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(230, 8);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(108, 20);
            this.Label.TabIndex = 47;
            this.Label.Text = "Facturacion";
            // 
            // BarraTituloPanel
            // 
            this.BarraTituloPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTituloPanel.Controls.Add(this.Label);
            this.BarraTituloPanel.Controls.Add(this.MinimizarButton);
            this.BarraTituloPanel.Controls.Add(this.CerrarButton);
            this.BarraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPanel.Name = "BarraTituloPanel";
            this.BarraTituloPanel.Size = new System.Drawing.Size(569, 34);
            this.BarraTituloPanel.TabIndex = 46;
            this.BarraTituloPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTituloPanel_Paint);
            this.BarraTituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPanel_MouseDown);
            // 
            // ClientesGroupBox
            // 
            this.ClientesGroupBox.Controls.Add(this.BusquedaClienteButton);
            this.ClientesGroupBox.Controls.Add(this.ClienteIdnumericUpDown);
            this.ClientesGroupBox.Controls.Add(this.label5);
            this.ClientesGroupBox.Controls.Add(this.NombreClientetextBox);
            this.ClientesGroupBox.Controls.Add(this.ClienteLabel);
            this.ClientesGroupBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesGroupBox.Location = new System.Drawing.Point(13, 108);
            this.ClientesGroupBox.Name = "ClientesGroupBox";
            this.ClientesGroupBox.Size = new System.Drawing.Size(546, 90);
            this.ClientesGroupBox.TabIndex = 2;
            this.ClientesGroupBox.TabStop = false;
            this.ClientesGroupBox.Text = "Clientes";
            // 
            // ClienteIdnumericUpDown
            // 
            this.ClienteIdnumericUpDown.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteIdnumericUpDown.Location = new System.Drawing.Point(137, 45);
            this.ClienteIdnumericUpDown.Name = "ClienteIdnumericUpDown";
            this.ClienteIdnumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.ClienteIdnumericUpDown.TabIndex = 58;
            this.ClienteIdnumericUpDown.ValueChanged += new System.EventHandler(this.ClienteIdnumericUpDown_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Cliente";
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClientetextBox.Location = new System.Drawing.Point(398, 47);
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.ReadOnly = true;
            this.NombreClientetextBox.Size = new System.Drawing.Size(120, 23);
            this.NombreClientetextBox.TabIndex = 52;
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(17, 47);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(80, 20);
            this.ClienteLabel.TabIndex = 51;
            this.ClienteLabel.Text = "Cliente Id";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(18, 81);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(77, 20);
            this.DescripcionLabel.TabIndex = 2;
            this.DescripcionLabel.Text = "Producto";
            // 
            // PrecioUnitarioLabel
            // 
            this.PrecioUnitarioLabel.AutoSize = true;
            this.PrecioUnitarioLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitarioLabel.Location = new System.Drawing.Point(20, 128);
            this.PrecioUnitarioLabel.Name = "PrecioUnitarioLabel";
            this.PrecioUnitarioLabel.Size = new System.Drawing.Size(116, 20);
            this.PrecioUnitarioLabel.TabIndex = 3;
            this.PrecioUnitarioLabel.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista de productos:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.AllowUserToOrderColumns = true;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(22, 215);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.RowHeadersWidth = 51;
            this.DetalledataGridView.RowTemplate.Height = 24;
            this.DetalledataGridView.Size = new System.Drawing.Size(494, 150);
            this.DetalledataGridView.TabIndex = 5;
            this.DetalledataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalledataGridView_CellContentClick);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(142, 81);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(376, 23);
            this.NombreTextBox.TabIndex = 7;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // PrecioUnitariotextBox
            // 
            this.PrecioUnitariotextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitariotextBox.Location = new System.Drawing.Point(144, 125);
            this.PrecioUnitariotextBox.Name = "PrecioUnitariotextBox";
            this.PrecioUnitariotextBox.ReadOnly = true;
            this.PrecioUnitariotextBox.Size = new System.Drawing.Size(120, 23);
            this.PrecioUnitariotextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidad";
            // 
            // ProductosGroupBox
            // 
            this.ProductosGroupBox.Controls.Add(this.UnidadcomboBox);
            this.ProductosGroupBox.Controls.Add(this.BusquedaPButton);
            this.ProductosGroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.ProductosGroupBox.Controls.Add(this.label2);
            this.ProductosGroupBox.Controls.Add(this.label12);
            this.ProductosGroupBox.Controls.Add(this.ImporteTextBox);
            this.ProductosGroupBox.Controls.Add(this.Agregarbutton);
            this.ProductosGroupBox.Controls.Add(this.label4);
            this.ProductosGroupBox.Controls.Add(this.PrecioUnitariotextBox);
            this.ProductosGroupBox.Controls.Add(this.NombreTextBox);
            this.ProductosGroupBox.Controls.Add(this.DetalledataGridView);
            this.ProductosGroupBox.Controls.Add(this.label3);
            this.ProductosGroupBox.Controls.Add(this.PrecioUnitarioLabel);
            this.ProductosGroupBox.Controls.Add(this.DescripcionLabel);
            this.ProductosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosGroupBox.Location = new System.Drawing.Point(15, 219);
            this.ProductosGroupBox.Name = "ProductosGroupBox";
            this.ProductosGroupBox.Size = new System.Drawing.Size(544, 381);
            this.ProductosGroupBox.TabIndex = 3;
            this.ProductosGroupBox.TabStop = false;
            this.ProductosGroupBox.Text = "Productos";
            // 
            // UnidadcomboBox
            // 
            this.UnidadcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnidadcomboBox.FormattingEnabled = true;
            this.UnidadcomboBox.Location = new System.Drawing.Point(142, 37);
            this.UnidadcomboBox.Name = "UnidadcomboBox";
            this.UnidadcomboBox.Size = new System.Drawing.Size(122, 28);
            this.UnidadcomboBox.TabIndex = 19;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(388, 35);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(55, 27);
            this.CantidadnumericUpDown.TabIndex = 17;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Importe";
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteTextBox.Location = new System.Drawing.Point(400, 125);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.ReadOnly = true;
            this.ImporteTextBox.Size = new System.Drawing.Size(118, 23);
            this.ImporteTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 623);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Subtotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 688);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Total:";
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(126, 620);
            this.SubtotaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.ReadOnly = true;
            this.SubtotaltextBox.Size = new System.Drawing.Size(100, 22);
            this.SubtotaltextBox.TabIndex = 39;
            this.SubtotaltextBox.TextChanged += new System.EventHandler(this.SubtotaltextBox_TextChanged);
            // 
            // TotalVentatextBox
            // 
            this.TotalVentatextBox.Location = new System.Drawing.Point(126, 682);
            this.TotalVentatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalVentatextBox.Name = "TotalVentatextBox";
            this.TotalVentatextBox.ReadOnly = true;
            this.TotalVentatextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalVentatextBox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 654);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 47;
            this.label9.Text = "ITBIS:";
            // 
            // ItbisTextBox
            // 
            this.ItbisTextBox.Location = new System.Drawing.Point(126, 651);
            this.ItbisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItbisTextBox.Name = "ItbisTextBox";
            this.ItbisTextBox.ReadOnly = true;
            this.ItbisTextBox.Size = new System.Drawing.Size(100, 22);
            this.ItbisTextBox.TabIndex = 48;
            this.ItbisTextBox.TextChanged += new System.EventHandler(this.ItbisTextBox_TextChanged);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(403, 48);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 23);
            this.FechadateTimePicker.TabIndex = 56;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(327, 51);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 20);
            this.FechaLabel.TabIndex = 55;
            this.FechaLabel.Text = "Fecha";
            // 
            // FacturaIdnumericUpDown
            // 
            this.FacturaIdnumericUpDown.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaIdnumericUpDown.Location = new System.Drawing.Point(156, 47);
            this.FacturaIdnumericUpDown.Name = "FacturaIdnumericUpDown";
            this.FacturaIdnumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.FacturaIdnumericUpDown.TabIndex = 54;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(22, 51);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(84, 20);
            this.IDLabel.TabIndex = 53;
            this.IDLabel.Text = "Factura Id";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(220, 42);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(47, 40);
            this.Buscarbutton.TabIndex = 57;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.Image")));
            this.MinimizarButton.Location = new System.Drawing.Point(508, 3);
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
            this.CerrarButton.Location = new System.Drawing.Point(539, 3);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(25, 25);
            this.CerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // BusquedaPButton
            // 
            this.BusquedaPButton.Image = global::Sistema_de_POS.Properties.Resources.imgBuscar;
            this.BusquedaPButton.Location = new System.Drawing.Point(468, 26);
            this.BusquedaPButton.Name = "BusquedaPButton";
            this.BusquedaPButton.Size = new System.Drawing.Size(47, 40);
            this.BusquedaPButton.TabIndex = 18;
            this.BusquedaPButton.UseVisualStyleBackColor = true;
            this.BusquedaPButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.Location = new System.Drawing.Point(469, 159);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(47, 40);
            this.Agregarbutton.TabIndex = 12;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // BusquedaClienteButton
            // 
            this.BusquedaClienteButton.Image = global::Sistema_de_POS.Properties.Resources.imgBuscar;
            this.BusquedaClienteButton.Location = new System.Drawing.Point(201, 39);
            this.BusquedaClienteButton.Name = "BusquedaClienteButton";
            this.BusquedaClienteButton.Size = new System.Drawing.Size(38, 34);
            this.BusquedaClienteButton.TabIndex = 59;
            this.BusquedaClienteButton.UseVisualStyleBackColor = true;
            this.BusquedaClienteButton.Click += new System.EventHandler(this.BusquedaClienteButton_Click);
            // 
            // rFacturacion
            // 
            this.ClientSize = new System.Drawing.Size(569, 750);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.FacturaIdnumericUpDown);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.ItbisTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BarraTituloPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TotalVentatextBox);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductosGroupBox);
            this.Controls.Add(this.ClientesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RVentas_Load);
            this.panel1.ResumeLayout(false);
            this.BarraTituloPanel.ResumeLayout(false);
            this.BarraTituloPanel.PerformLayout();
            this.ClientesGroupBox.ResumeLayout(false);
            this.ClientesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ProductosGroupBox.ResumeLayout(false);
            this.ProductosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BarraTituloPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RVentas_Load(object sender, EventArgs e)
        {

        }

        private void BarraTituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }
        
        public void Limpiar()
        {
            FacturaIdnumericUpDown.Value = 0;
            ClienteIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombreClientetextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            UnidadcomboBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            PrecioUnitariotextBox.Text = "0";
            SubtotaltextBox.Text = "0";
            ItbisTextBox.Text = "0";
            TotalVentatextBox.Text = "0";

            this.Detalle = new List<DetalleProducto>();
            CargarGrid();
        }

        private Factura LlenarClase()
        {
            Factura factura = new Factura();

            factura.FacturaId = Convert.ToInt32(FacturaIdnumericUpDown.Value);
            factura.Fecha = FechadateTimePicker.Value.Date;
            factura.ClienteId = Convert.ToInt32(ClienteIdnumericUpDown.Value);
            factura.Cliente = NombreClientetextBox.Text;
            factura.ITBIS = Convert.ToDouble(ItbisTextBox.Text);
            factura.SubTotal = Convert.ToDouble(SubtotaltextBox.Text);
            factura.Total = Convert.ToDouble(TotalVentatextBox.Text);

            factura.DetalleProducto = this.Detalle;

            return factura;
        }

        public void LlenarCampo(Factura factura)
        {
            FacturaIdnumericUpDown.Value = factura.FacturaId;
            FechadateTimePicker.Value = factura.Fecha;
            ClienteIdnumericUpDown.Value = factura.ClienteId;
            NombreClientetextBox.Text = factura.Cliente;
            ItbisTextBox.Text = Convert.ToString(factura.ITBIS);
            SubtotaltextBox.Text = Convert.ToString(factura.SubTotal);
            TotalVentatextBox.Text = Convert.ToString(factura.Total);
            
            ItbisTextBox.Text = Convert.ToString(factura.ITBIS);

            this.Detalle = factura.DetalleProducto;
            CargarGrid();

        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(Agregarbutton, "Debe agregar al menos un producto");
                Agregarbutton.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombreClientetextBox.Text))
            {
                MyErrorProvider.SetError(NombreClientetextBox, "Debe de agregar un cliente para poder realizar la factura");
                NombreClientetextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ItbisTextBox.Text))
            {
                MyErrorProvider.SetError(Agregarbutton, "Debe agregar al menos un producto");
                Agregarbutton.Focus();
                paso = false;
            }

            return paso;

        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Factura> repositorio = new RepositorioBase<Factura>();
            Factura f = repositorio.Buscar((int)FacturaIdnumericUpDown.Value);
            return f != null;
        }
        
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            FacturacionRepositorio repositorio = new FacturacionRepositorio();
            bool paso = false;

            if (!Validar())
                return;

            Factura factura = LlenarClase();

            if (FacturaIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(factura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(factura);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            FacturacionRepositorio repositorio = new FacturacionRepositorio();

            int id;
            int.TryParse(Convert.ToString(FacturaIdnumericUpDown.Value), out id);

            Factura factura = repositorio.Buscar(id);

            Limpiar();

            if (factura != null)
            {
                repositorio.Eliminar(id);
            }
            else
            {
                MessageBox.Show("No se encuentra la factura");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (!ValidarDetalle())
                return;

            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<DetalleProducto>)DetalledataGridView.DataSource;

            this.Detalle.Add(
                new DetalleProducto(
                    descripcion: NombreTextBox.Text,
                    cantidad: Convert.ToInt32(CantidadnumericUpDown.Value),
                    precioUnitario: Convert.ToDouble(PrecioUnitariotextBox.Text),
                    unidad: UnidadcomboBox.Text,
                    importe: Convert.ToDouble(ImporteTextBox.Text),
                    facturaId: Convert.ToInt32(FacturaIdnumericUpDown.Value),
                    productoId: 0
                    )
                );


            double subtotal = 0;

            foreach (var item in this.Detalle)
            {
                subtotal += (item.PrecioUnitario * item.Cantidad);
            }

            SubtotaltextBox.Text = Convert.ToString(subtotal);
            CargarGrid();
        }

        private void ClienteIdnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ItbisTextBox_TextChanged(object sender, EventArgs e)
        {
            TotalVentatextBox.Text = Convert.ToString(Convert.ToDouble(SubtotaltextBox.Text) + Convert.ToDouble(ItbisTextBox.Text));
        }

        private void SubtotaltextBox_TextChanged(object sender, EventArgs e)
        {
            ItbisTextBox.Text = Convert.ToString(Convert.ToDouble(SubtotaltextBox.Text) * 0.18);
        }


        private void DetalledataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static int productosBuscados = 0;
        public static int clientesBuscados = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            BusquedaProductos busqueda = new BusquedaProductos();
            busqueda.ShowDialog();

            if (productosBuscados == 0)
            {
                MyErrorProvider.SetError(BusquedaPButton, "Debe de registrar productos al sistema");
                BusquedaPButton.Focus();
                return;
            }

            NombreTextBox.Text = BusquedaProductos.listaProductoEnviar[0].Nombre;
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {
            UnidadcomboBox.DisplayMember = "Unidad";
            UnidadcomboBox.DataSource = BusquedaProductos.listaProductoEnviar;
            PrecioUnitariotextBox.Text = Convert.ToString(BusquedaProductos.listaProductoEnviar[0].PrecioUnitario);
        }
        private bool ValidarDetalle()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (Convert.ToInt32(CantidadnumericUpDown.Value) == 0)
            {
                MyErrorProvider.SetError(CantidadnumericUpDown, "La cantidad de productos a vender no puede ser 0");
                CantidadnumericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "Debe de seleccionar un producto para poder añadirlo a la lista de compra");
                NombreTextBox.Focus();
                return false;
            }

            if (CantidadnumericUpDown.Value > BusquedaProductos.listaProductoEnviar[0].Existencia)
            {
                MyErrorProvider.SetError(CantidadnumericUpDown, "La cantidad de productos a vender debe ser menor o igual a la que hay en existencia");
                CantidadnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }
        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double cantidad = 0;
            double PrecioUnitario = 0;

            if (string.IsNullOrWhiteSpace(PrecioUnitariotextBox.Text) && string.IsNullOrWhiteSpace(CantidadnumericUpDown.Text))
            {
                CantidadnumericUpDown.Value = 0;
                PrecioUnitariotextBox.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(CantidadnumericUpDown.Text))
            {
                CantidadnumericUpDown.Value = 0;
            }
            if (string.IsNullOrWhiteSpace(PrecioUnitariotextBox.Text))
            {
                PrecioUnitariotextBox.Text = "0";
            }


            cantidad = Convert.ToDouble(CantidadnumericUpDown.Value);
            PrecioUnitario = Convert.ToDouble(PrecioUnitariotextBox.Text);

            double Total = 0;
            Total = cantidad * PrecioUnitario;

            ImporteTextBox.Text = Convert.ToString(Total);
        }

        private void ClienteIdnumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            if (ClienteIdnumericUpDown.Value == 0)
                MyErrorProvider.Clear();

            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();

            MyErrorProvider.Clear();

            int id;
            int.TryParse(Convert.ToString(ClienteIdnumericUpDown.Value), out id);

            Cliente cliente = repositorio.Buscar(id);

            if (cliente != null)
            {
                NombreClientetextBox.Text = cliente.Nombre;
            }
            else
            {
                MyErrorProvider.SetError(ClienteIdnumericUpDown, "No se encuentra el cliente");
                ClienteIdnumericUpDown.Focus();
                NombreClientetextBox.Text = string.Empty;
            }
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            FacturacionRepositorio repositorio = new FacturacionRepositorio();

            int id;
            int.TryParse(Convert.ToString(FacturaIdnumericUpDown.Value), out id);

            Factura factura = repositorio.Buscar(id);

            Limpiar();

            if (factura != null)
            {
                LlenarCampo(factura);
            }
            else
            {
                MessageBox.Show("No se encuentra la factura");
            }
        }

        private void BusquedaClienteButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            BusquedaClientes busqueda = new BusquedaClientes();
            busqueda.ShowDialog();

            if (clientesBuscados == 0)
            {
                MyErrorProvider.SetError(BusquedaClienteButton, "Debe de registrar clientes al sistema");
                BusquedaClienteButton.Focus();
                return;
            }

            NombreClientetextBox.Text = BusquedaClientes.listaClientesEnviar[0].Nombre;
            ClienteIdnumericUpDown.Value = BusquedaClientes.listaClientesEnviar[0].ClienteId;
        }
    }



}
