using Sistema_de_POS.Entidades;
using SistemaPOS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_POS.UI;

namespace Sistema_de_POS.UI.Registros
{
    public partial class rCierreCaja : Form
    {
        public rCierreCaja()
        {
            InitializeComponent();
        }

        private void rCierreCaja_Load(object sender, EventArgs e)
        {
            //UsuarioTextBox.Text = rLogin.UsuarioActual.Nombre;

            RepositorioBase<POS> repos = new RepositorioBase<POS>();
            POS pos = new POS();

            EfectivoDGV.Rows.Add(9);
            EfectivoDGV.Rows[0].Cells[0].Value = 2000;
            EfectivoDGV.Rows[1].Cells[0].Value = 1000;
            EfectivoDGV.Rows[2].Cells[0].Value = 500;
            EfectivoDGV.Rows[3].Cells[0].Value = 100;
            EfectivoDGV.Rows[4].Cells[0].Value = 50;
            EfectivoDGV.Rows[5].Cells[0].Value = 25;
            EfectivoDGV.Rows[6].Cells[0].Value = 10;
            EfectivoDGV.Rows[7].Cells[0].Value = 5;
            EfectivoDGV.Rows[8].Cells[0].Value = 1;


            //pos = repos.Buscar(1);

            var Lista = repos.GetList(p => true);
            decimal totalefectivo = 0  ;
            decimal totalcredito = 0;
            decimal totalgeneral =0;
            
            //foreach (var item in Lista)
            //{
            //    if(item.TipoPago=="Tarjeta credito")
            //    {
            //        if (item.NombreUsuario == UsuarioTextBox.Text) //Para saber si es el usuario actual
            //        {

            //            totalcredito += item.Total;
            //        }
            //    }
            //    else
            //    {
            //        if (item.NombreUsuario == UsuarioTextBox.Text) //Para saber si es el usuario actual
            //        {

            //            totalefectivo += item.Total;
            //        }
            //    }
    
            //}

            totalgeneral = totalefectivo + totalcredito;

            DSETextBox.Text = Convert.ToString(totalefectivo);
            DSTTextBox.Text = Convert.ToString(totalcredito);
            DSTGTextBox.Text = Convert.ToString(totalgeneral);
        }

        int billete = 0;
        int cantidad = 0;
        int subtotal = 0;
        int total = 0;
        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridViewRow)(EfectivoDGV.Rows[e.RowIndex]));



            if (EfectivoDGV.Columns[e.ColumnIndex].Name == "ColumnaCantidad")
            {
                string tscantidad;
                try
                {
                    tscantidad = (row.Cells[1].Value.ToString());
                }
                catch (Exception)
                {
                    tscantidad = "0";
                }

                if (row.Cells[1].Value == null)
                {
                    row.Cells[1].Value = 0;
                }

                billete = int.Parse(row.Cells[0].Value.ToString());
                cantidad = int.Parse(row.Cells[1].Value.ToString());

                subtotal = billete * cantidad;
                total += subtotal;
                row.Cells[2].Value = subtotal;
            }

            TotalEfectivoTextBox.Text = Convert.ToString(total);
        }

        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            //UsuarioTextBox.Text = string.Empty;
           //CajaNumericUpDown.Text = string.Empty;
            TotalEfectivoTextBox.Text = string.Empty;
            ComentarioTextBox.Text = string.Empty;
            EfectivoDGV.DataSource = null;
        }
        public Cierre LlenarClase()
        {
            Cierre cierre = new Cierre();

            cierre.CierreId = Convert.ToInt32(IDNumericUpDown.Value);
            //cierre.Caja = Convert.ToInt32(CajaNumericUpDown.Text);
            cierre.Fecha = FechaDateTimePicker.Value;
            cierre.TotalEfectivo = Convert.ToDouble(TotalEfectivoTextBox.Text);
            cierre.Comentario = ComentarioTextBox.Text;

            return cierre;
        }
        public void LlenarCampo(Cierre cierre)
        {
            IDNumericUpDown.Value = cierre.CierreId;
            //CajaNumericUpDown.Text = Convert.ToString(cierre.Caja);
            FechaDateTimePicker.Value = cierre.Fecha;
            TotalEfectivoTextBox.Text = Convert.ToString(cierre.TotalEfectivo);
            ComentarioTextBox.Text = cierre.Comentario;
        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            /*if (CajaNumericUpDown.Value==0)
            {
                MyErrorProvider.SetError(CajaNumericUpDown, "El campo caja no puede estar ser 0");
                CajaNumericUpDown.Focus();
                paso = false;
            }*/

           
            if (Convert.ToDouble(TotalGeneralTextBox.Text) != Convert.ToDouble(DSTGTextBox.Text))
            {
                MyErrorProvider.SetError(Guardarbutton, "La caja no cuadra");
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Cierre> repo = new RepositorioBase<Cierre>();
            Cierre cierre = repo.Buscar((int)IDNumericUpDown.Value);
            return cierre != null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            RepositorioBase<Cierre> repo = new RepositorioBase<Cierre>();
            Cierre cierre = new Cierre();

            RepositorioBase<Apertura> repos = new RepositorioBase<Apertura>();
            Apertura apertura = new Apertura();

            if (!Validar())
                return;

            cierre = LlenarClase();

            if (IDNumericUpDown.Value == 0)
            {
                paso = repo.Guardar(cierre);
                /*apertura = repos.Buscar(Convert.ToInt32(CajaNumericUpDown.Value));
                apertura.Cerrada = true; //Para Marcarla Cerrada
                repos.Guardar(apertura);*/
            }      
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado para modificar");
                    return;
                }
                paso = repo.Modificar(cierre);
            }

            if (paso)
            {
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No fue posible guardar");
            }
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);
            RepositorioBase<Cierre> repo = new RepositorioBase<Cierre>();
            Cierre cierre = repo.Buscar(id);

            Limpiar();

            if (cierre == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                LlenarCampo(cierre);
            }
        }

        private void TotalEfectivoTextBox_TextChanged(object sender, EventArgs e)
        {
            RepositorioBase<POS> repo = new RepositorioBase<POS>();
            RepositorioBase<Apertura> repo2 = new RepositorioBase<Apertura>();
            //RepositorioBase<Cierre> repo3 = new RepositorioBase<Cierre>();

            var Lista = repo.GetList(p => true);
            var Lista2 = repo2.GetList(l => true);
            //var Lista3 = repo3.GetList(c => true);

            foreach (var item in Lista)
            {
                foreach (var item2 in Lista2)
                {
                    //foreach (var item3 in Lista3)
                    //{
                       // if(item2.Caja == item3.Caja)
                        //{
                            DSETextBox.Text = Convert.ToString(item.Total);
                            DSTTextBox.Text = "0";
                            DSTGTextBox.Text = Convert.ToString((double)item.Total + item2.TotalEfectivo);
                        //}
                        
                    //}

                }
            }

            decimal ttg = total + totalcredito;
            TotalGeneralTextBox.Text = Convert.ToString(ttg);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void ComentarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DSETextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DSTGTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EfectivoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreditoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        decimal totalcredito = 0;
        decimal monto = 0;
        private void CreditoDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridViewRow)(CreditoDGV.Rows[e.RowIndex]));



            if (CreditoDGV.Columns[e.ColumnIndex].Name == "ColumnaMonto")
            {
                string tscantidad;
                try
                {
                    tscantidad = (row.Cells[1].Value.ToString());
                }
                catch (Exception)
                {
                    tscantidad = "0";
                }

                if (row.Cells[1].Value == null)
                {
                    row.Cells[1].Value = 0;
                }

                
                monto = int.Parse(row.Cells[1].Value.ToString());

                
                totalcredito += monto;
                
            }

            TotalTarjetaCreditoTextBox.Text = Convert.ToString(totalcredito);
            
        }

        private void TotalTarjetaCreditoTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal ttg = total + totalcredito;
            TotalGeneralTextBox.Text = Convert.ToString(ttg);
        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
