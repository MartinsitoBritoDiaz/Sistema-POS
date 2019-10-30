using Sistema_de_POS.Entidades;
using SistemaPOS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
        private Label IDLabel;
        private NumericUpDown FacturaIdnumericUpDown;
        private Label ClienteLabel;
        private TextBox NombreClientetextBox;
        private Label CondicionLabel;
        private Label FechaLabel;
        private DateTimePicker FechadateTimePicker;
        private Label label1;
        private Button Buscarbutton;
        private GroupBox ClientesGroupBox;
        private Label label2;
        private Label DescripcionLabel;
        private Label PrecioUnitarioLabel;
        private Label label3;
        private DataGridView DetalledataGridView;
        private NumericUpDown CantidadnumericUpDown;
        private TextBox DescripciontextBox;
        private TextBox PrecioUnitariotextBox;
        private Label label4;
        private ComboBox UnidadcomboBox;
        private Button Agregarbutton;
        private GroupBox ProductosGroupBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox SubtotaltextBox;
        private TextBox DescuentostextBox;
        private ComboBox TipoPagocomboBox;
        private ComboBox CondicioncomboBox;
        private NumericUpDown ClienteIdnumericUpDown;
        private Label label5;
        private Label label9;
        private TextBox ItbisTextBox;
        private Label label10;
        private TextBox PagoTextBox;
        private TextBox DeudatextBox;
        private Label label11;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rFacturacion));
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CerrarButton = new System.Windows.Forms.PictureBox();
            this.MinimizarButton = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            this.BarraTituloPanel = new System.Windows.Forms.Panel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FacturaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.CondicionLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ClientesGroupBox = new System.Windows.Forms.GroupBox();
            this.ClienteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CondicioncomboBox = new System.Windows.Forms.ComboBox();
            this.TipoPagocomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.PrecioUnitarioLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.PrecioUnitariotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnidadcomboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ProductosGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.DescuentostextBox = new System.Windows.Forms.TextBox();
            this.TotalVentatextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ItbisTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PagoTextBox = new System.Windows.Forms.TextBox();
            this.DeudatextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).BeginInit();
            this.BarraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdnumericUpDown)).BeginInit();
            this.ClientesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            this.ProductosGroupBox.SuspendLayout();
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
            this.Eliminarbutton.Location = new System.Drawing.Point(547, 0);
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
            this.Guardarbutton.Location = new System.Drawing.Point(280, 0);
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
            this.Nuevobutton.Location = new System.Drawing.Point(13, 0);
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
            this.panel1.Location = new System.Drawing.Point(0, 707);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 40);
            this.panel1.TabIndex = 45;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("CerrarButton.Image")));
            this.CerrarButton.Location = new System.Drawing.Point(666, 3);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(25, 25);
            this.CerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.Image")));
            this.MinimizarButton.Location = new System.Drawing.Point(635, 3);
            this.MinimizarButton.Name = "MinimizarButton";
            this.MinimizarButton.Size = new System.Drawing.Size(25, 25);
            this.MinimizarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarButton.TabIndex = 4;
            this.MinimizarButton.TabStop = false;
            this.MinimizarButton.Click += new System.EventHandler(this.MinimizarButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(300, 8);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(58, 17);
            this.Label.TabIndex = 47;
            this.Label.Text = "Ventas";
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
            this.BarraTituloPanel.Size = new System.Drawing.Size(696, 34);
            this.BarraTituloPanel.TabIndex = 46;
            this.BarraTituloPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTituloPanel_Paint);
            this.BarraTituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPanel_MouseDown);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(19, 40);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(80, 19);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Factura Id";
            // 
            // FacturaIdnumericUpDown
            // 
            this.FacturaIdnumericUpDown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaIdnumericUpDown.Location = new System.Drawing.Point(142, 37);
            this.FacturaIdnumericUpDown.Name = "FacturaIdnumericUpDown";
            this.FacturaIdnumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.FacturaIdnumericUpDown.TabIndex = 1;
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(19, 82);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(75, 19);
            this.ClienteLabel.TabIndex = 2;
            this.ClienteLabel.Text = "Cliente Id";
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClientetextBox.Location = new System.Drawing.Point(504, 82);
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.Size = new System.Drawing.Size(149, 22);
            this.NombreClientetextBox.TabIndex = 3;
            // 
            // CondicionLabel
            // 
            this.CondicionLabel.AutoSize = true;
            this.CondicionLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondicionLabel.Location = new System.Drawing.Point(19, 128);
            this.CondicionLabel.Name = "CondicionLabel";
            this.CondicionLabel.Size = new System.Drawing.Size(81, 19);
            this.CondicionLabel.TabIndex = 4;
            this.CondicionLabel.Text = "Condicion";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(365, 40);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(53, 19);
            this.FechaLabel.TabIndex = 6;
            this.FechaLabel.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(504, 40);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(149, 22);
            this.FechadateTimePicker.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de pago";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(232, 30);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(47, 40);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ClientesGroupBox
            // 
            this.ClientesGroupBox.Controls.Add(this.ClienteIdnumericUpDown);
            this.ClientesGroupBox.Controls.Add(this.label5);
            this.ClientesGroupBox.Controls.Add(this.CondicioncomboBox);
            this.ClientesGroupBox.Controls.Add(this.TipoPagocomboBox);
            this.ClientesGroupBox.Controls.Add(this.Buscarbutton);
            this.ClientesGroupBox.Controls.Add(this.label1);
            this.ClientesGroupBox.Controls.Add(this.FechadateTimePicker);
            this.ClientesGroupBox.Controls.Add(this.FechaLabel);
            this.ClientesGroupBox.Controls.Add(this.CondicionLabel);
            this.ClientesGroupBox.Controls.Add(this.NombreClientetextBox);
            this.ClientesGroupBox.Controls.Add(this.ClienteLabel);
            this.ClientesGroupBox.Controls.Add(this.FacturaIdnumericUpDown);
            this.ClientesGroupBox.Controls.Add(this.IDLabel);
            this.ClientesGroupBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesGroupBox.Location = new System.Drawing.Point(13, 40);
            this.ClientesGroupBox.Name = "ClientesGroupBox";
            this.ClientesGroupBox.Size = new System.Drawing.Size(678, 173);
            this.ClientesGroupBox.TabIndex = 2;
            this.ClientesGroupBox.TabStop = false;
            this.ClientesGroupBox.Text = "Clientes";
            // 
            // ClienteIdnumericUpDown
            // 
            this.ClienteIdnumericUpDown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteIdnumericUpDown.Location = new System.Drawing.Point(142, 82);
            this.ClienteIdnumericUpDown.Name = "ClienteIdnumericUpDown";
            this.ClienteIdnumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.ClienteIdnumericUpDown.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nombre cliente";
            // 
            // CondicioncomboBox
            // 
            this.CondicioncomboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondicioncomboBox.FormattingEnabled = true;
            this.CondicioncomboBox.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.CondicioncomboBox.Location = new System.Drawing.Point(139, 126);
            this.CondicioncomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CondicioncomboBox.Name = "CondicioncomboBox";
            this.CondicioncomboBox.Size = new System.Drawing.Size(140, 25);
            this.CondicioncomboBox.TabIndex = 48;
            // 
            // TipoPagocomboBox
            // 
            this.TipoPagocomboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPagocomboBox.FormattingEnabled = true;
            this.TipoPagocomboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito",
            "Cheque"});
            this.TipoPagocomboBox.Location = new System.Drawing.Point(504, 126);
            this.TipoPagocomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TipoPagocomboBox.Name = "TipoPagocomboBox";
            this.TipoPagocomboBox.Size = new System.Drawing.Size(149, 25);
            this.TipoPagocomboBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(18, 69);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(79, 17);
            this.DescripcionLabel.TabIndex = 2;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // PrecioUnitarioLabel
            // 
            this.PrecioUnitarioLabel.AutoSize = true;
            this.PrecioUnitarioLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitarioLabel.Location = new System.Drawing.Point(18, 109);
            this.PrecioUnitarioLabel.Name = "PrecioUnitarioLabel";
            this.PrecioUnitarioLabel.Size = new System.Drawing.Size(95, 17);
            this.PrecioUnitarioLabel.TabIndex = 3;
            this.PrecioUnitarioLabel.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista de productos:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.AllowUserToOrderColumns = true;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(22, 166);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.RowHeadersWidth = 51;
            this.DetalledataGridView.RowTemplate.Height = 24;
            this.DetalledataGridView.Size = new System.Drawing.Size(629, 150);
            this.DetalledataGridView.TabIndex = 5;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(140, 26);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.CantidadnumericUpDown.TabIndex = 6;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripciontextBox.Location = new System.Drawing.Point(140, 65);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(511, 20);
            this.DescripciontextBox.TabIndex = 7;
            // 
            // PrecioUnitariotextBox
            // 
            this.PrecioUnitariotextBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitariotextBox.Location = new System.Drawing.Point(140, 106);
            this.PrecioUnitariotextBox.Name = "PrecioUnitariotextBox";
            this.PrecioUnitariotextBox.Size = new System.Drawing.Size(511, 20);
            this.PrecioUnitariotextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidad";
            // 
            // UnidadcomboBox
            // 
            this.UnidadcomboBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnidadcomboBox.FormattingEnabled = true;
            this.UnidadcomboBox.Items.AddRange(new object[] {
            "Kilos",
            "Libras",
            "Onzas",
            "Paquetes",
            "Unidades",
            "Porciones"});
            this.UnidadcomboBox.Location = new System.Drawing.Point(418, 27);
            this.UnidadcomboBox.Name = "UnidadcomboBox";
            this.UnidadcomboBox.Size = new System.Drawing.Size(149, 23);
            this.UnidadcomboBox.TabIndex = 10;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.Location = new System.Drawing.Point(604, 17);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(47, 40);
            this.Agregarbutton.TabIndex = 12;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ProductosGroupBox
            // 
            this.ProductosGroupBox.Controls.Add(this.Agregarbutton);
            this.ProductosGroupBox.Controls.Add(this.UnidadcomboBox);
            this.ProductosGroupBox.Controls.Add(this.label4);
            this.ProductosGroupBox.Controls.Add(this.PrecioUnitariotextBox);
            this.ProductosGroupBox.Controls.Add(this.DescripciontextBox);
            this.ProductosGroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.ProductosGroupBox.Controls.Add(this.DetalledataGridView);
            this.ProductosGroupBox.Controls.Add(this.label3);
            this.ProductosGroupBox.Controls.Add(this.PrecioUnitarioLabel);
            this.ProductosGroupBox.Controls.Add(this.DescripcionLabel);
            this.ProductosGroupBox.Controls.Add(this.label2);
            this.ProductosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosGroupBox.Location = new System.Drawing.Point(15, 219);
            this.ProductosGroupBox.Name = "ProductosGroupBox";
            this.ProductosGroupBox.Size = new System.Drawing.Size(680, 344);
            this.ProductosGroupBox.TabIndex = 3;
            this.ProductosGroupBox.TabStop = false;
            this.ProductosGroupBox.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 577);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 577);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Descuentos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 620);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Total:";
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(130, 574);
            this.SubtotaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.ReadOnly = true;
            this.SubtotaltextBox.Size = new System.Drawing.Size(128, 20);
            this.SubtotaltextBox.TabIndex = 39;
            // 
            // DescuentostextBox
            // 
            this.DescuentostextBox.Location = new System.Drawing.Point(538, 574);
            this.DescuentostextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescuentostextBox.Name = "DescuentostextBox";
            this.DescuentostextBox.Size = new System.Drawing.Size(128, 20);
            this.DescuentostextBox.TabIndex = 40;
            // 
            // TotalVentatextBox
            // 
            this.TotalVentatextBox.Location = new System.Drawing.Point(538, 617);
            this.TotalVentatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalVentatextBox.Name = "TotalVentatextBox";
            this.TotalVentatextBox.ReadOnly = true;
            this.TotalVentatextBox.Size = new System.Drawing.Size(128, 20);
            this.TotalVentatextBox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 620);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "ITBIS:";
            // 
            // ItbisTextBox
            // 
            this.ItbisTextBox.Location = new System.Drawing.Point(130, 620);
            this.ItbisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItbisTextBox.Name = "ItbisTextBox";
            this.ItbisTextBox.ReadOnly = true;
            this.ItbisTextBox.Size = new System.Drawing.Size(128, 20);
            this.ItbisTextBox.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 665);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Pago:";
            // 
            // PagoTextBox
            // 
            this.PagoTextBox.Location = new System.Drawing.Point(130, 665);
            this.PagoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PagoTextBox.Name = "PagoTextBox";
            this.PagoTextBox.Size = new System.Drawing.Size(128, 20);
            this.PagoTextBox.TabIndex = 50;
            // 
            // DeudatextBox
            // 
            this.DeudatextBox.Location = new System.Drawing.Point(538, 665);
            this.DeudatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DeudatextBox.Name = "DeudatextBox";
            this.DeudatextBox.ReadOnly = true;
            this.DeudatextBox.Size = new System.Drawing.Size(128, 20);
            this.DeudatextBox.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 668);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Deuda:";
            // 
            // rFacturacion
            // 
            this.ClientSize = new System.Drawing.Size(696, 746);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeudatextBox);
            this.Controls.Add(this.PagoTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ItbisTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BarraTituloPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TotalVentatextBox);
            this.Controls.Add(this.DescuentostextBox);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductosGroupBox);
            this.Controls.Add(this.ClientesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RVentas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).EndInit();
            this.BarraTituloPanel.ResumeLayout(false);
            this.BarraTituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdnumericUpDown)).EndInit();
            this.ClientesGroupBox.ResumeLayout(false);
            this.ClientesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            this.ProductosGroupBox.ResumeLayout(false);
            this.ProductosGroupBox.PerformLayout();
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
        /*
        public void Limpiar()
        {
            FacturaIdnumericUpDown.Value = 0;
            ClienteIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombreClientetextBox.Text = string.Empty;
            CondicioncomboBox.Text = string.Empty;
            TipoPagocomboBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            UnidadcomboBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            PrecioUnitariotextBox.Text = "0";
            SubtotaltextBox.Text = "0";
            DescuentostextBox.Text = "0";
            ItbisTextBox.Text = "0";
            TotalVentatextBox.Text = "0";
            PagoTextBox.Text = "0";
            DeudatextBox.Text = "0";

            this.Detalle = new List<DetalleProducto>();
            CargarGrid();
        }

        private Factura LlenarClase()
        {
            Factura factura = new Factura();

            factura.Facturaid = Convert.ToInt32(IDnumericUpDown.Value);
            factura.Fecha = FechadateTimePicker.Value.Date;
            factura.Cliente = ClientetextBox.Text;
            factura.Condicion = CondicioncomboBox.Text;
            factura.TipoPago = TipoPagocomboBox.Text;
            factura.SubTotal = Convert.ToDecimal(SubtotaltextBox.Text);
            factura.Total = Convert.ToDecimal(TotalVentatextBox.Text);
            factura.descuentos = Convert.ToDecimal(DescuentostextBox.Text);

            factura.Productos = this.Detalle;

            return factura;
        }

        public void LlenarCampo(Factura factura)
        {
            IDnumericUpDown.Value = factura.Facturaid;
            FechadateTimePicker.Value = factura.Fecha;
            ClientetextBox.Text = factura.Cliente;
            CondicioncomboBox.Text = factura.Condicion;
            TipoPagocomboBox.Text = factura.TipoPago;
            SubtotaltextBox.Text = Convert.ToString(factura.SubTotal);
            TotalVentatextBox.Text = Convert.ToString(factura.Total);
            DescuentostextBox.Text = Convert.ToString(factura.descuentos);

            this.Detalle = factura.Productos;

        }

        public bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(CondicioncomboBox.Text))
            {
                MyErrorProvider.SetError(CondicioncomboBox, "El campo condicion no puede estar vacio");
                CondicioncomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TipoPagocomboBox.Text))
            {
                MyErrorProvider.SetError(TipoPagocomboBox, "El campo tipo de pago no puede estar vacio");
                TipoPagocomboBox.Focus();
                paso = false;
            }
            if (this.Detalle.Count == 0)
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
            Factura f = repositorio.Buscar((int)IDnumericUpDown.Value);
            return f != null;
        }
        */
        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
