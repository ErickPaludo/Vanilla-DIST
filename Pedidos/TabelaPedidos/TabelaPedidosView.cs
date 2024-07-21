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
                if (e.ColumnIndex != 0)
                {
                    controller.AtualizaLinhaPedidos(Convert.ToInt32(dataGridPedidos.Rows[e.RowIndex].Cells[1].Value));
                }
            }
        }

        private void SelecionaStatus(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void SelecionaSituacao(object sender, EventArgs e)
        {
            // Verifica se a alteração ocorreu na coluna 0 e se a linha é válida
            if (dataGridPedidos.IsCurrentCellDirty)
            {
                // Confirma a edição para que o evento CellValueChanged seja acionado
                dataGridPedidos.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // Aqui você pode realizar as ações imediatas após a seleção do ComboBox
                int rowIndex = dataGridPedidos.CurrentCell.RowIndex;
                int columnIndex = dataGridPedidos.CurrentCell.ColumnIndex;

                if (columnIndex == 0 && rowIndex >= 0)
                {
                    DataGridViewComboBoxCell comboBoxCell = dataGridPedidos.Rows[rowIndex].Cells[columnIndex] as DataGridViewComboBoxCell;

                    if (comboBoxCell != null && comboBoxCell.Value != null)
                    {
                      controller.AlterarSituacao(Convert.ToInt32(dataGridPedidos.Rows[rowIndex].Cells[1].Value.ToString()),comboBoxCell.Value.ToString());

                        // Se precisar atualizar algo baseado na seleção, você pode fazer aqui
                        // Exemplo: controller.AtualizaLinhaPedidos(selectedValue);
                    }
                }
            }
        }

    }
}
