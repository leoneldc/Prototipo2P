using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo2P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VISTA.Pedidos pedidos = new VISTA.Pedidos();
            pedidos.MdiParent = this;
            pedidos.Show();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VISTA.Productos productos = new VISTA.Productos();
            productos.MdiParent = this;
            productos.Show();
        }
    }
}
