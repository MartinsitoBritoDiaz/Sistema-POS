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
    public partial class rCierreCaja : Form
    {
        public rCierreCaja()
        {
            InitializeComponent();
        }

        private void rCierreCaja_Load(object sender, EventArgs e)
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

        int billete = 0;
        int cantidad = 0;
        int subtotal = 0;
        int total = 0;
        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ((DataGridViewRow)(dataGridView1.Rows[e.RowIndex]));



            if (dataGridView1.Columns[e.ColumnIndex].Name == "ColumnaCantidad")
            {
                billete = int.Parse(row.Cells[0].Value.ToString());
                cantidad = int.Parse(row.Cells[1].Value.ToString());
                subtotal = billete * cantidad;
                total += subtotal;
                row.Cells[2].Value = subtotal;
            }

            TotalEfectivoTextBox.Text = Convert.ToString(total);
        }
    }
}
