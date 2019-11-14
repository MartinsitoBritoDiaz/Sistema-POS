using Sistema_de_POS.Entidades;
using SistemaPOS.BLL;
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
    public partial class rLogin : Form
    {
        public rLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraTituloPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();

            foreach (var item in repositorio.GetList(r => true))
            {
                if(UsuarioTextBox.Text == item.User)
                {
                    if (ContraseñaTextBox.Text == item.Contraseña)
                    {
                        MenuForm menu = new MenuForm(UsuarioTextBox.Text);
                        menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Debe de proporcionar un usuario y/o contraseña valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            UsuarioTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;                
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            rUsuario registro = new rUsuario();
            registro.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();

            bool paso = true;

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo usuario no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MyErrorProvider.SetError(ContraseñaTextBox, "El campo contraseña no puede estar vacio");
                ContraseñaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void VisualizarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string text = ContraseñaTextBox.Text;
            if (VisualizarCheckBox.Checked)
            {
                ContraseñaTextBox.UseSystemPasswordChar = false;
                ContraseñaTextBox.Text = text;

            }
            else
            {
                ContraseñaTextBox.UseSystemPasswordChar = true;
                ContraseñaTextBox.Text = text;
            }
        }
    }
}
