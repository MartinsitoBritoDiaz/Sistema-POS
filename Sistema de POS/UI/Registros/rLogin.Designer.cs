namespace Sistema_de_POS.UI.Registros
{
    partial class rLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.BarraTituloPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MinizarButton = new System.Windows.Forms.PictureBox();
            this.CerrarButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VisualizarCheckBox = new System.Windows.Forms.CheckBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BarraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinizarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // IngresarButton
            // 
            this.IngresarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.IngresarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarButton.Location = new System.Drawing.Point(164, 206);
            this.IngresarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(143, 44);
            this.IngresarButton.TabIndex = 2;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.Button1_Click);
            this.IngresarButton.Enter += new System.EventHandler(this.IngresarButton_Enter);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(164, 110);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(253, 22);
            this.UsuarioTextBox.TabIndex = 3;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(164, 156);
            this.ContraseñaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(143, 22);
            this.ContraseñaTextBox.TabIndex = 4;
            this.ContraseñaTextBox.UseSystemPasswordChar = true;
            // 
            // BarraTituloPanel
            // 
            this.BarraTituloPanel.BackColor = System.Drawing.Color.Gray;
            this.BarraTituloPanel.Controls.Add(this.label3);
            this.BarraTituloPanel.Controls.Add(this.MinizarButton);
            this.BarraTituloPanel.Controls.Add(this.CerrarButton);
            this.BarraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTituloPanel.Name = "BarraTituloPanel";
            this.BarraTituloPanel.Size = new System.Drawing.Size(460, 33);
            this.BarraTituloPanel.TabIndex = 57;
            this.BarraTituloPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTituloPanel_Paint);
            this.BarraTituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPanel_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // MinizarButton
            // 
            this.MinizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinizarButton.Image = ((System.Drawing.Image)(resources.GetObject("MinizarButton.Image")));
            this.MinizarButton.Location = new System.Drawing.Point(397, 2);
            this.MinizarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinizarButton.Name = "MinizarButton";
            this.MinizarButton.Size = new System.Drawing.Size(25, 25);
            this.MinizarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinizarButton.TabIndex = 4;
            this.MinizarButton.TabStop = false;
            this.MinizarButton.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("CerrarButton.Image")));
            this.CerrarButton.Location = new System.Drawing.Point(429, 2);
            this.CerrarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(25, 25);
            this.CerrarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.TabStop = false;
            this.CerrarButton.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Desea crear un usuario?";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // VisualizarCheckBox
            // 
            this.VisualizarCheckBox.AutoSize = true;
            this.VisualizarCheckBox.Location = new System.Drawing.Point(319, 158);
            this.VisualizarCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizarCheckBox.Name = "VisualizarCheckBox";
            this.VisualizarCheckBox.Size = new System.Drawing.Size(91, 21);
            this.VisualizarCheckBox.TabIndex = 59;
            this.VisualizarCheckBox.Text = "Visualizar";
            this.VisualizarCheckBox.UseVisualStyleBackColor = true;
            this.VisualizarCheckBox.CheckedChanged += new System.EventHandler(this.VisualizarCheckBox_CheckedChanged);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 293);
            this.Controls.Add(this.VisualizarCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BarraTituloPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.RLogin_Load);
            this.BarraTituloPanel.ResumeLayout(false);
            this.BarraTituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinizarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTituloPanel;
        private System.Windows.Forms.PictureBox MinizarButton;
        private System.Windows.Forms.PictureBox CerrarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox VisualizarCheckBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}