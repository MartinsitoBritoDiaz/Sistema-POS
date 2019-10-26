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
    public partial class rVentas : Form
    {
        private DateTimePicker dateTimePicker1;
        private Label FechaLabel;
        private Label CondicionLabel;
        private TextBox textBox1;
        private Label ClienteLabel;
        private NumericUpDown numericUpDown1;
        private Label IDLabel;
        private Label label1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox ProductosGroupBox;
        private DataGridView dataGridView1;
        private Label label3;
        private Label PrecioUnitarioLabel;
        private Label DescripcionLabel;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private NumericUpDown numericUpDown2;
        private Button Eliminarbutton;
        private Button Guardarbutton;
        private Button Nuevobutton;
        private TextBox TotalVentatextBox;
        private TextBox DescuentostextBox;
        private TextBox SubtotaltextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Panel BarraTituloPanel;
        private Label Label;
        private PictureBox MinimizarButton;
        private PictureBox RestaurarButton;
        private PictureBox MaximizarButton;
        private PictureBox CerrarButton;
        private GroupBox ClientesGroupBox;

        public rVentas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rVentas));
            this.ClientesGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.CondicionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ProductosGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioUnitarioLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.TotalVentatextBox = new System.Windows.Forms.TextBox();
            this.DescuentostextBox = new System.Windows.Forms.TextBox();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraTituloPanel = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.MinimizarButton = new System.Windows.Forms.PictureBox();
            this.RestaurarButton = new System.Windows.Forms.PictureBox();
            this.MaximizarButton = new System.Windows.Forms.PictureBox();
            this.CerrarButton = new System.Windows.Forms.PictureBox();
            this.ClientesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.ProductosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.BarraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesGroupBox
            // 
            this.ClientesGroupBox.Controls.Add(this.button1);
            this.ClientesGroupBox.Controls.Add(this.comboBox2);
            this.ClientesGroupBox.Controls.Add(this.comboBox1);
            this.ClientesGroupBox.Controls.Add(this.label1);
            this.ClientesGroupBox.Controls.Add(this.dateTimePicker1);
            this.ClientesGroupBox.Controls.Add(this.FechaLabel);
            this.ClientesGroupBox.Controls.Add(this.CondicionLabel);
            this.ClientesGroupBox.Controls.Add(this.textBox1);
            this.ClientesGroupBox.Controls.Add(this.ClienteLabel);
            this.ClientesGroupBox.Controls.Add(this.numericUpDown1);
            this.ClientesGroupBox.Controls.Add(this.IDLabel);
            this.ClientesGroupBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesGroupBox.Location = new System.Drawing.Point(14, 40);
            this.ClientesGroupBox.Name = "ClientesGroupBox";
            this.ClientesGroupBox.Size = new System.Drawing.Size(826, 173);
            this.ClientesGroupBox.TabIndex = 2;
            this.ClientesGroupBox.TabStop = false;
            this.ClientesGroupBox.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(375, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(654, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de pago: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(654, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(585, 34);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(53, 19);
            this.FechaLabel.TabIndex = 6;
            this.FechaLabel.Text = "Fecha";
            // 
            // CondicionLabel
            // 
            this.CondicionLabel.AutoSize = true;
            this.CondicionLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondicionLabel.Location = new System.Drawing.Point(19, 128);
            this.CondicionLabel.Name = "CondicionLabel";
            this.CondicionLabel.Size = new System.Drawing.Size(81, 19);
            this.CondicionLabel.TabIndex = 4;
            this.CondicionLabel.Text = "Condicion";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 23);
            this.textBox1.TabIndex = 3;
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(19, 82);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(58, 19);
            this.ClienteLabel.TabIndex = 2;
            this.ClienteLabel.Text = "Cliente";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(115, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown1.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(19, 40);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(22, 19);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Id";
            // 
            // ProductosGroupBox
            // 
            this.ProductosGroupBox.Controls.Add(this.textBox3);
            this.ProductosGroupBox.Controls.Add(this.textBox2);
            this.ProductosGroupBox.Controls.Add(this.numericUpDown2);
            this.ProductosGroupBox.Controls.Add(this.dataGridView1);
            this.ProductosGroupBox.Controls.Add(this.label3);
            this.ProductosGroupBox.Controls.Add(this.PrecioUnitarioLabel);
            this.ProductosGroupBox.Controls.Add(this.DescripcionLabel);
            this.ProductosGroupBox.Controls.Add(this.label2);
            this.ProductosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosGroupBox.Location = new System.Drawing.Point(15, 219);
            this.ProductosGroupBox.Name = "ProductosGroupBox";
            this.ProductosGroupBox.Size = new System.Drawing.Size(825, 344);
            this.ProductosGroupBox.TabIndex = 3;
            this.ProductosGroupBox.TabStop = false;
            this.ProductosGroupBox.Text = "Productos";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(140, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(662, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(140, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(662, 23);
            this.textBox2.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(140, 26);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 23);
            this.numericUpDown2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista de productos:";
            // 
            // PrecioUnitarioLabel
            // 
            this.PrecioUnitarioLabel.AutoSize = true;
            this.PrecioUnitarioLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitarioLabel.Location = new System.Drawing.Point(18, 109);
            this.PrecioUnitarioLabel.Name = "PrecioUnitarioLabel";
            this.PrecioUnitarioLabel.Size = new System.Drawing.Size(107, 19);
            this.PrecioUnitarioLabel.TabIndex = 3;
            this.PrecioUnitarioLabel.Text = "Precio Unitario";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(18, 69);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(89, 19);
            this.DescripcionLabel.TabIndex = 2;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
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
            this.Eliminarbutton.Location = new System.Drawing.Point(729, 0);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(109, 45);
            this.Eliminarbutton.TabIndex = 44;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
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
            this.Guardarbutton.Location = new System.Drawing.Point(379, 0);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(109, 45);
            this.Guardarbutton.TabIndex = 43;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
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
            this.Nuevobutton.Location = new System.Drawing.Point(35, 0);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(92, 45);
            this.Nuevobutton.TabIndex = 42;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // TotalVentatextBox
            // 
            this.TotalVentatextBox.Location = new System.Drawing.Point(130, 614);
            this.TotalVentatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalVentatextBox.Name = "TotalVentatextBox";
            this.TotalVentatextBox.Size = new System.Drawing.Size(257, 22);
            this.TotalVentatextBox.TabIndex = 41;
            // 
            // DescuentostextBox
            // 
            this.DescuentostextBox.Location = new System.Drawing.Point(561, 574);
            this.DescuentostextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescuentostextBox.Name = "DescuentostextBox";
            this.DescuentostextBox.Size = new System.Drawing.Size(256, 22);
            this.DescuentostextBox.TabIndex = 40;
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(130, 574);
            this.SubtotaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.Size = new System.Drawing.Size(257, 22);
            this.SubtotaltextBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 617);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 577);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Descuentos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 577);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Subtotal:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.Nuevobutton);
            this.panel1.Controls.Add(this.Eliminarbutton);
            this.panel1.Controls.Add(this.Guardarbutton);
            this.panel1.Location = new System.Drawing.Point(0, 665);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 40);
            this.panel1.TabIndex = 45;
            // 
            // BarraTituloPanel
            // 
            this.BarraTituloPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTituloPanel.Controls.Add(this.Label);
            this.BarraTituloPanel.Controls.Add(this.MinimizarButton);
            this.BarraTituloPanel.Controls.Add(this.RestaurarButton);
            this.BarraTituloPanel.Controls.Add(this.MaximizarButton);
            this.BarraTituloPanel.Controls.Add(this.CerrarButton);
            this.BarraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPanel.Name = "BarraTituloPanel";
            this.BarraTituloPanel.Size = new System.Drawing.Size(852, 34);
            this.BarraTituloPanel.TabIndex = 46;
            this.BarraTituloPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTituloPanel_Paint);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(384, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(67, 20);
            this.Label.TabIndex = 47;
            this.Label.Text = "Ventas";
            // 
            // MinimizarButton
            // 
            this.MinimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarButton.Image")));
            this.MinimizarButton.Location = new System.Drawing.Point(760, 3);
            this.MinimizarButton.Name = "MinimizarButton";
            this.MinimizarButton.Size = new System.Drawing.Size(25, 25);
            this.MinimizarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarButton.TabIndex = 4;
            this.MinimizarButton.TabStop = false;
            this.MinimizarButton.Click += new System.EventHandler(this.MinimizarButton_Click);
            // 
            // RestaurarButton
            // 
            this.RestaurarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurarButton.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarButton.Image")));
            this.RestaurarButton.Location = new System.Drawing.Point(791, 3);
            this.RestaurarButton.Name = "RestaurarButton";
            this.RestaurarButton.Size = new System.Drawing.Size(25, 25);
            this.RestaurarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestaurarButton.TabIndex = 3;
            this.RestaurarButton.TabStop = false;
            this.RestaurarButton.Visible = false;
            this.RestaurarButton.Click += new System.EventHandler(this.RestaurarButton_Click);
            // 
            // MaximizarButton
            // 
            this.MaximizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizarButton.Image")));
            this.MaximizarButton.Location = new System.Drawing.Point(791, 3);
            this.MaximizarButton.Name = "MaximizarButton";
            this.MaximizarButton.Size = new System.Drawing.Size(25, 25);
            this.MaximizarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizarButton.TabIndex = 2;
            this.MaximizarButton.TabStop = false;
            this.MaximizarButton.Click += new System.EventHandler(this.MaximizarButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("CerrarButton.Image")));
            this.CerrarButton.Location = new System.Drawing.Point(822, 3);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(25, 25);
            this.CerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // rVentas
            // 
            this.ClientSize = new System.Drawing.Size(852, 703);
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
            this.Name = "rVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientesGroupBox.ResumeLayout(false);
            this.ClientesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ProductosGroupBox.ResumeLayout(false);
            this.ProductosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.BarraTituloPanel.ResumeLayout(false);
            this.BarraTituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BarraTituloPanel_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RestaurarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestaurarButton.Visible = false;
            MaximizarButton.Visible = true;
        }

        private void MaximizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestaurarButton.Visible = true;
            MaximizarButton.Visible = false;
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
