using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Productos : Form
    {
        CONTROLADOR.Controaldor cn = new CONTROLADOR.Controaldor();
        string tabla = "tbl_productos";
        string campos = "(nombreProducto,marcaProducto,precioProducto,existenciasProducto,estadoProducto)";
        public Productos()
        {
            InitializeComponent();
            actualizTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado = "0";
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    estado = "1";
                }
                string datos = "'" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', " + estado + "";
                cn.insert(  datos, campos, tabla);
                actualizTabla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string condicion = "codigoProducto="+textBox1.Text;
            string estado = "0";
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    estado = "1";
                }
                string datos = "nombreProducto='" + textBox2.Text + "', marcaProducto='" + textBox3.Text + "', precioProducto='" + textBox4.Text + "', existenciasProducto='" + textBox5.Text + "', estadoProducto=" + estado + "";
                cn.update(datos, condicion, tabla);
                actualizTabla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                string condicion = "codigoProducto=" + textBox1.Text;
                cn.delete(condicion, tabla);
                actualizTabla();
            }
        }

        private void actualizTabla()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dataGridView1.DataSource = dt;
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            radioButton3.Checked = true;
            radioButton3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
