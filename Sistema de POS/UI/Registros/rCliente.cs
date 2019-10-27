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
    public partial class rCliente : Form
    {
        public rCliente()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void RCliente_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void BarraTituloPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BarraTituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RCliente_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox2.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Cliente cliente)
        {
            IDnumericUpDown.Value = cliente.ClienteId;
            NombreTextBox.Text = cliente.Nombre;
            CedulaMaskedTextBox.Text = cliente.Cedula;
            TelefonoMaskedTextBox2.Text = cliente.Telefono;
            CelularMaskedTextBox.Text = cliente.Celular;
            DireccionTextBox.Text = cliente.Direccion;
            FechaDateTimePicker.Value = cliente.Fecha;
        }

        private Cliente LlenaClase()
        {
            Cliente cliente = new Cliente();
            cliente.ClienteId = Convert.ToInt32(IDnumericUpDown.Value);
            cliente.Nombre = NombreTextBox.Text;
            cliente.Cedula = CedulaMaskedTextBox.Text;
            cliente.Telefono = TelefonoMaskedTextBox2.Text;
            cliente.Celular = CelularMaskedTextBox.Text;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.Fecha = FechaDateTimePicker.Value;

            return cliente;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();

            Cliente cliente = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (cliente != null);
        } 

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo cedula no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox2.Text))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox2, "El campo telefono no puede estar vacio");
                TelefonoMaskedTextBox2.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo celular no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo direccion no puede estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        //Todo: Terminar el registro de cliente y Terminar de mover el registro de facturacion.
    }
}
