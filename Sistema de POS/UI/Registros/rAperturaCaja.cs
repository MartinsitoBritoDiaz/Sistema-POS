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

namespace Sistema_de_POS.UI.Registros
{
    public partial class rAperturaCaja : Form
    {
        public rAperturaCaja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            }


        int billete = 0;
        int cantidad = 0;
        int subtotal = 0;
        int total = 0;
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridViewRow row = ((DataGridViewRow)(dataGridView1.Rows[e.RowIndex]));

            
        
            if(dataGridView1.Columns[e.ColumnIndex].Name == "ColumnaCantidad")
            {
                billete = int.Parse(row.Cells[0].Value.ToString());
                cantidad = int.Parse(row.Cells[1].Value.ToString());
                subtotal = billete * cantidad;
                total += subtotal;
                row.Cells[2].Value = subtotal;
            }

            TotalEfectivoTextBox.Text = Convert.ToString(total);
        }

        private void rAperturaCaja_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(9);
            dataGridView1.Rows[0].Cells[0].Value = 2000;
            dataGridView1.Rows[1].Cells[0].Value = 1000;
            dataGridView1.Rows[2].Cells[0].Value = 500;
            dataGridView1.Rows[3].Cells[0].Value = 100;
            dataGridView1.Rows[4].Cells[0].Value = 50;
            dataGridView1.Rows[5].Cells[0].Value = 25;
            dataGridView1.Rows[6].Cells[0].Value = 10;
            dataGridView1.Rows[7].Cells[0].Value = 5;
            dataGridView1.Rows[8].Cells[0].Value = 1;
            
        }

        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            UsuarioTextBox.Text = string.Empty;
            CajaTextBox.Text = string.Empty;
            TotalEfectivoTextBox.Text = string.Empty;
            ComentarioTextBox.Text = string.Empty;
            
        }

        public Apertura LlenarClase()
        {
            Apertura apertura = new Apertura();

            apertura.AperturaId = Convert.ToInt32(IDNumericUpDown.Value);
            apertura.Caja = Convert.ToInt32(CajaTextBox.Text);
            apertura.Fecha = FechaDateTimePicker.Value;
            apertura.Usuario = UsuarioTextBox.Text;
            apertura.TotalEfectivo = Convert.ToDouble(TotalEfectivoTextBox.Text);
            apertura.Comentario = ComentarioTextBox.Text;

            return apertura;
        }
       
        public void LlenarCampo(Apertura apertura)
        {
            IDNumericUpDown.Value = apertura.AperturaId;
            CajaTextBox.Text = Convert.ToString(apertura.Caja);
            FechaDateTimePicker.Value = apertura.Fecha;
            UsuarioTextBox.Text = apertura.Usuario;
            TotalEfectivoTextBox.Text = Convert.ToString(apertura.TotalEfectivo);
            ComentarioTextBox.Text = apertura.Comentario;
        }

        public bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(CajaTextBox.Text))
            {
                MyErrorProvider.SetError(CajaTextBox, "El campo caja no puede estar vacio");
                CajaTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(CajaTextBox, "El campo usuario no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Apertura> repo = new RepositorioBase<Apertura>();
            Apertura apertura = repo.Buscar((int)IDNumericUpDown.Value);
            return apertura != null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Apertura> repo = new RepositorioBase<Apertura>();
            Apertura apertura = new Apertura();

            if (!Validar())
                return;

            apertura = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = repo.Guardar(apertura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado para modificar");
                    return;
                }
                paso = repo.Modificar(apertura);
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
            RepositorioBase<Apertura> repo = new RepositorioBase<Apertura>();
            Apertura apertura = repo.Buscar(id);

            Limpiar();

            if(apertura == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                LlenarCampo(apertura);
            }
        }
    }
}
