﻿using System;
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
            RegistroFacturacion registro = new RegistroFacturacion();
            registro.Show();
        }

        private void FacturacionButton_Click(object sender, EventArgs e)
        {
            ConsultaFactura registro = new ConsultaFactura();
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
            rVentas registro = new rVentas();
            registro.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            rCliente registro = new rCliente();
            registro.Show();
        }
    }
}