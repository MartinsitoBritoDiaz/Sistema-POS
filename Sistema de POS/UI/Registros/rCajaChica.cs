using Sistema_de_POS.Entidades;
using SistemaPOS.BLL;
using SistemaPOS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_POS.UI.Registros
{
    public partial class rCajaChica : Form
    {
        public rCajaChica()
        {
            InitializeComponent();
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaReposicionButton_Click(object sender, EventArgs e)
        {
            EgresoPanel.Visible = false;
            ReposicionPanel.Visible = true;
        }

        private void RegistrarGastoButton_Click(object sender, EventArgs e)
        {
            ReposicionPanel.Visible = false;
            EgresoPanel.Visible = true;
            EgresoPanel.Location = new Point(12, 113);
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoRButton_Click(object sender, EventArgs e)
        {
            FechaRDateTimePicker.Value = DateTime.Now;
            MontoRTextBox.Text = "0.00";
            DescripcionRTextBox.Text = string.Empty;
            ComprobanteRTextBox.Text = string.Empty;
        }


        public bool ValidarR()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(MontoRTextBox.Text))
            {
                MyErrorProvider.SetError(MontoRTextBox, "Debe agregar un monto");
                MontoRTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ComprobanteRTextBox.Text))
            {
                MyErrorProvider.SetError(ComprobanteRTextBox, "Debe agregar un comprobante");
                ComprobanteRTextBox.Focus();
                paso = false;
            }

            return paso;

        }
        public bool ValidarE()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(MontoETextBox.Text))
            {
                MyErrorProvider.SetError(MontoETextBox, "Debe agregar un monto");
                MontoETextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ComprobanteETextBox.Text))
            {
                MyErrorProvider.SetError(ComprobanteETextBox, "Debe agregar un comprobante");
                ComprobanteETextBox.Focus();
                paso = false;
            }

            return paso;

        }

        private void Limpiar()
        {
            FechaEDateTimePicker.Value = DateTime.Now;
            FechaRDateTimePicker.Value = DateTime.Now;
            MontoETextBox.Text = string.Empty;
            MontoRTextBox.Text = string.Empty;
            RealizadoPorTextBox.Text = string.Empty;
            DescripcionETextBox.Text = string.Empty;
            DescripcionRTextBox.Text = string.Empty;
            ComprobanteETextBox.Text = string.Empty;
            ComprobanteRTextBox.Text = string.Empty;

        }

        private CajaChica LlenarClase()
        {
            CajaChica cajaChica = new CajaChica();

            cajaChica.Fecha = FechaRDateTimePicker.Value.Date;
            cajaChica.Monto = Convert.ToSingle(MontoRTextBox.Text);
            cajaChica.Descripcion = DescripcionRTextBox.Text;
            cajaChica.Comprobante = Convert.ToInt32(ComprobanteRTextBox.Text);

            
            using (Contexto context = new Contexto())
            {

                var result = (from item in context.ReposicionFondos

                              orderby item.Id descending

                              select item).First();
                result.SaldoActual += Convert.ToInt32(MontoRTextBox.Text);

                cajaChica.SaldoActual += result.SaldoActual;
            }

            return cajaChica;
        }

        private void GuardarRbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            CajaChica cajaChica = new CajaChica();
            RepositorioBase<CajaChica> repositorio = new RepositorioBase<CajaChica>();

            if (!ValidarR())
                return;

            cajaChica = LlenarClase();
            //SaldoActualLabel.Text = Convert.ToString(cajaChica.SaldoActual);
            paso = repositorio.Guardar(cajaChica);

            if (paso)
            {
                SaldoActualLabel.Text = Convert.ToString(cajaChica.SaldoActual);
                Limpiar();
                MessageBox.Show("Guardado");

            }
            else
            {
                MessageBox.Show("No fue posible guardar");
            }
        }

        

        private void SalirRbutton_Click_1(object sender, EventArgs e)
        {
            ReposicionPanel.Visible = false;
        }

        private void NuevoEButton_Click(object sender, EventArgs e)
        {
            FechaRDateTimePicker.Value = DateTime.Now;
            RealizadoPorTextBox.Text = string.Empty;
            MontoRTextBox.Text = "0.00";
            DescripcionRTextBox.Text = string.Empty;
            ComprobanteRTextBox.Text = string.Empty;
        }

        private EgresoFondos LlenarClaseEgreso()
        {
            EgresoFondos egresoFondos = new EgresoFondos();
            // CajaChica cajaChica = new CajaChica();//

            egresoFondos.Fecha = FechaEDateTimePicker.Value.Date;
            egresoFondos.Monto = Convert.ToSingle(MontoETextBox.Text);
            egresoFondos.Descripcion = DescripcionETextBox.Text;
            egresoFondos.Comprobante = Convert.ToInt32(ComprobanteETextBox.Text);
            egresoFondos.RealizadoPor = RealizadoPorTextBox.Text;

            using (Contexto context = new Contexto())
            {

                var result = (from item in context.ReposicionFondos

                              orderby item.Id descending

                              select item).First();

                RepositorioBase<CajaChica> repositorio = new RepositorioBase<CajaChica>();
                bool paso;

                result.SaldoActual -= Convert.ToInt32(MontoETextBox.Text);
                paso = repositorio.Modificar(result);

                egresoFondos.SaldoActual = result.SaldoActual;
            }
            // cajaChica.SaldoActual -=  Convert.ToInt32(MontoETextBox.Text);//



            return egresoFondos;
        }

        

        private void SalirEButton_Click(object sender, EventArgs e)
        {
            EgresoPanel.Visible = false;
        }

        private void GuardarEbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            EgresoFondos egresoFondos = new EgresoFondos();
            RepositorioBase<EgresoFondos> repositorio = new RepositorioBase<EgresoFondos>();

            if (!ValidarE())
                return;

            egresoFondos = LlenarClaseEgreso();
            //paso = repositorio.Guardar(egresoFondos);



            if (egresoFondos.Monto > Convert.ToSingle(SaldoActualLabel.Text))
            {
                MyErrorProvider.SetError(MontoETextBox, "El monto del egreso supera el saldo disponible");
                MontoETextBox.Focus();
            }
            else
            {
                paso = repositorio.Guardar(egresoFondos);
            }

            if (paso)
            {
                SaldoActualLabel.Text = Convert.ToString(egresoFondos.SaldoActual);
                Limpiar();
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No fue posible guardar");
            }
        }

        private void rCajaChica_Load(object sender, EventArgs e)
        {
            using (Contexto context = new Contexto())
            {

                var result = (from item in context.ReposicionFondos

                              orderby item.Id descending

                              select item).First();

                SaldoActualLabel.Text = Convert.ToString(result.SaldoActual);
            }
        }
    }
}
