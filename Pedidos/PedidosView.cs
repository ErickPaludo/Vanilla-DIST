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

        }

        private void SelecionaCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                controller.SelecionaCliente(Convert.ToInt32(dataGridClient.Rows[e.RowIndex].Cells[0].Value), (dataGridClient.Rows[e.RowIndex].Cells[1].Value).ToString());
            }
        }
        private void SelecionaTansportadora(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                controller.SelecionaTransportadora(Convert.ToInt32(dataGridTrans.Rows[e.RowIndex].Cells[0].Value), (dataGridTrans.Rows[e.RowIndex].Cells[1].Value).ToString());
            }
        }

        private void CriarPedido(object sender, EventArgs e)
        {
            controller.CadastraPedido();
        }

        private void RetirarItem(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                {
                    controller.SelecionaItem(Convert.ToInt32(dataGridItensSelect.Rows[e.RowIndex].Cells[0].Value));
                }
            }
        }

        private void AlterarQtd(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    try
                    {

                        controller.AlteraQtd(Convert.ToInt32(dataGridItensSelect.Rows[e.RowIndex].Cells[0].Value), Convert.ToInt32(dataGridItensSelect.Rows[e.RowIndex].Cells[2].Value));
                    }
                    catch
                    {
                        MessageBox.Show("O valor inserido não é um número!");
                        dataGridItensSelect.Rows[e.RowIndex].Cells[2].Value = 0.ToString();
                    }
                }
            }
        }

        private void Mover(object sender, EventArgs e)
        {
            if (this.Left < 255) this.Left = 273;
        }

        public Label NameClient { get { return lclient; } set { lclient = value; } }
        public Label NameTransportadora { get { return ltransp; } set { ltransp = value; } }
        public DataGridView TabelaClient { get { return dataGridClient; } set { dataGridClient = value; } }
        public DataGridView TabelaTransportadora { get { return dataGridTrans; } set { dataGridTrans = value; } }
        public DataGridView TabelaItensDisponivel { get { return dataGridItens; } set { dataGridItens = value; } }
        public DataGridView TabelaItensSelecionados { get { return dataGridItensSelect; } set { dataGridItensSelect = value; } }
    }
}
