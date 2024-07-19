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
    public partial class TabelaPedidosView : Form, ITabelaPedidos
    {
        ControllerTabelaPedidos controller;
        public DataGridView Tabela_pedidos { get { return dataGridPedidos; } set { dataGridPedidos = value; } }
        public DataGridView Tabela_linha_pedidos { get { return dataGridLinhaPedido; } set { dataGridLinhaPedido = value; } }
        public TabelaPedidosView()
        {
            InitializeComponent();
        }
        public void SetController(ControllerTabelaPedidos controller)
        {
            this.controller = controller;
        }



        private void Atualiza(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) // Verifica se a tecla pressionada é a tecla F5
            {
                controller.AtualizaPedidos();
            }
        }

        private void SelecionaPedido(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               int t = (Convert.ToInt32(dataGridPedidos.Rows[e.RowIndex].Cells[0].Value));
                controller.AtualizaLinhaPedidos(Convert.ToInt32(dataGridPedidos.Rows[e.RowIndex].Cells[0].Value));
            }
        }
    }
}
