namespace Sistema_de_POS.UI.Consultas
{
    partial class ConsultaPOS
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
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(8, 29);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.RowHeadersWidth = 51;
            this.ConsultadataGridView.Size = new System.Drawing.Size(579, 406);
            this.ConsultadataGridView.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Desde:";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(52, 3);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.DesdedateTimePicker.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hasta:";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(183, 3);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.HastadateTimePicker.TabIndex = 24;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Location = new System.Drawing.Point(353, 4);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(234, 23);
            this.Consultarbutton.TabIndex = 29;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cantidad de Articulos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(707, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(707, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(707, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 36;
            // 
            // ConsultaPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 447);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "ConsultaPOS";
            this.Text = "Consulta POS";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}