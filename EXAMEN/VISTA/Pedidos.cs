using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VISTA
{
    public partial class Pedidos : Form
    {
        CONTROLADOR.Controaldor cn = new CONTROLADOR.Controaldor();
        string tabla = "tbl_pedidos";
        string campos = "(fechaPedido,estadoPedido)";

        public Pedidos()
        {
            InitializeComponent();
            actualizTabla();
        }


        private void label1_Click(object sender, EventArgs e)
        {

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
                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                string datos = "'" + fechaActual + "', " + estado + "";
                cn.insert(datos, campos, tabla);
                actualizTabla();
            }
        }


        private void actualizTabla()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dataGridView1.DataSource = dt;
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string condicion = "codigoPedido=" + textBox1.Text;
            string estado = "0";
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    estado = "1";
                }
                string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
                string datos = "fechaPedido='" + fechaActual + "', estadoPedido=" + estado + "";
                cn.update(datos, condicion, tabla);
                actualizTabla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                string condicion = "codigoPedido=" + textBox1.Text;
                cn.delete(condicion, tabla);
                actualizTabla();
            }
        }

        private void limpiar()
        {
            textBox1.Text = "";
            radioButton3.Checked = true;
            radioButton3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
