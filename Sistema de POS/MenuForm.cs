using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sistema_de_POS.UI.Registros;
using Sistema_de_POS.UI.Consultas;

namespace Sistema_de_POS
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            
            InitializeComponent();
        }

        private void SlideButton_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 188)
            {
                MenuVertical.Width = 50;
            }
            else
            {
                MenuVertical.Width = 188;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestaurarButton.Visible = true;
            MaximizarButton.Visible = false;
        }

        private void RestaurarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestaurarButton.Visible = false;
            MaximizarButton.Visible = true;
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTituloPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void VentasButton_Click(object sender, EventArgs e)
        {
         
        }

        private void FacturacionButton_Click(object sender, EventArgs e)
        {
            ConsultaPOS registro = new ConsultaPOS();
            registro.Show();
        }

        private void AbrirFormInPanel(Object formhijo)
        {
            if (this.ContenedorPanel.Controls.Count > 0)
                this.ContenedorPanel.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = Dock = DockStyle.Fill;
            this.ContenedorPanel.Controls.Add(fh);
            this.ContenedorPanel.Tag = fh;
            fh.Show();
        }
        private void CajaChicaButton_Click(object sender, EventArgs e)
        {
            rFacturacion registro = new rFacturacion();
            registro.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            rCliente registro = new rCliente();
            registro.Show();
        }

        private void ContenedorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form formulario = new RPosForm();
            formulario.Show();
        }

        private void CajaChicaButton_Click_1(object sender, EventArgs e)
        {
            rCajaChica rcajaChica = new rCajaChica();
            rcajaChica.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rAperturaCaja rAperturaCaja = new rAperturaCaja();
            rAperturaCaja.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            rCierreCaja registro = new rCierreCaja();
            registro.Show();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrosButton_Click(object sender, EventArgs e)
        {
            if (RegistrosPanel.Height == 250)
            {
                RegistrosPanel.Height = 0;
                ConsultasButton.Location = new Point(0, 135);
                ConsultasPanel.Location = new Point(0, 170);
            }
            else
            {
                ConsultasButton.Location = new Point(0, 385);
                ConsultasPanel.Location = new Point(0, 418);
                RegistrosPanel.Height = 250;
            }
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultasButton_Click(object sender, EventArgs e)
        {
            if (RegistrosPanel.Height == 250)
            {
                if (ConsultasPanel.Height == 72)
                {
                    ConsultasPanel.Location = new Point(0, 418);
                    ConsultasPanel.Height = 0;
                }
                else
                {
                    ConsultasPanel.Location = new Point(0, 418);
                    ConsultasPanel.Height = 72;
                }
            }
            else
            {
                if (ConsultasPanel.Height == 72)
                {
                    ConsultasPanel.Location = new Point(0, 170);
                    ConsultasPanel.Height = 0;
                }
                else
                {
                    ConsultasPanel.Location = new Point(0, 170);
                    ConsultasPanel.Height = 72;
                }
            }

            
        }

        private void UsuarioButton_Click(object sender, EventArgs e)
        {
            rUsuario registroUsuario = new rUsuario();
            registroUsuario.Show();
        }
    }
}
