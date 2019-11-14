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
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            TipoComboBox.ResetText();
            CedulaMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            UsuarioTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Usuario usuario)
        {
            IDnumericUpDown.Value = usuario.UsuarioId;
            NombreTextBox.Text = usuario.Nombre;
            TipoComboBox.Text = usuario.Tipo;
            CedulaMaskedTextBox.Text = usuario.Cedula;
            CelularMaskedTextBox.Text = usuario.Celular;
            UsuarioTextBox.Text = usuario.User;
            ContraseñaTextBox.Text = usuario.Contraseña;
            FechaDateTimePicker.Value = usuario.FechaNacimiento;
        }

        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();
            usuario.UsuarioId = Convert.ToInt32(IDnumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Cedula = CedulaMaskedTextBox.Text;
            usuario.Tipo = TipoComboBox.SelectedText;
            usuario.Celular = CelularMaskedTextBox.Text;
            usuario.User = UsuarioTextBox.Text;
            usuario.Contraseña = ContraseñaTextBox.Text;
            usuario.FechaNacimiento = FechaDateTimePicker.Value;

            return usuario;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no ouede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo cedula no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TipoComboBox.Text))
            {
                MyErrorProvider.SetError(TipoComboBox, "Debe de seleccionar un tipo de usuario");
                TipoComboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo celular no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo usuario no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MyErrorProvider.SetError(ContraseñaTextBox, "El campo contraseña no puuede estar vacio");
                ContraseñaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();

            Usuario usuario = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (usuario != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();

            bool paso = false;

            if (!Validar())
                return;

            Usuario usuario = LlenaClase();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(usuario);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            MyErrorProvider.Clear();

            int id;
            int.TryParse(Convert.ToString(IDnumericUpDown.Value), out id);

            Usuario usuario = repositorio.Buscar(id);

            Limpiar();

            if (usuario != null)
                repositorio.Eliminar(id);
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede guardar un usuario que no existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            MyErrorProvider.Clear();

            int id;
            int.TryParse(Convert.ToString(IDnumericUpDown.Value), out id);

            Usuario usuario = repositorio.Buscar(id);

            Limpiar();

            if (usuario != null)
                LlenaCampo(usuario);
            else
                MessageBox.Show("No se encuentra este usuario");
        }
    }
}
