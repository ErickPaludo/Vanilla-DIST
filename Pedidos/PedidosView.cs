using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanilla
{
    public partial class PedidosView : Form, Ipedido
    {
        PedidosController controller;
        public PedidosView()
        {
            InitializeComponent();
        }
        public void SetController(PedidosController controller)
        {
            this.controller = controller;
        }

        private void SelecionaItem(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                controller.SelecionaItem(Convert.ToInt32(dataGridItens.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void RetiraItem(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                controller.SelecionaItem(Convert.ToInt32(dataGridItensSelect.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        public Label NameClient { get { return lclient; } set { lclient = value; } }
        public Label NameTransportadora { get { return ltransp; } set { ltransp = value; } }
        public DataGridView TabelaClient { get { return dataGridClient; } set { dataGridClient = value; } }
        public DataGridView TabelaTransportadora { get { return dataGridTrans; } set { dataGridTrans = value; } }
        public DataGridView TabelaItensDisponivel { get { return dataGridItens; } set { dataGridItens = value; } }
        public DataGridView TabelaItensSelecionados { get { return dataGridItensSelect; } set { dataGridItensSelect = value; } }
    }
}
