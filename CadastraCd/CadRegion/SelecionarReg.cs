using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vanilla.CadastraCd.CadRegion;

namespace Vanilla
{
    public partial class SelecionarReg : Form
    {
        static private List<RegArmazenagem> reg = new List<RegArmazenagem>();
        Database db = new Database();
        public SelecionarReg()
        {
            InitializeComponent();
        }

        private void dataGridViewReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //Está sendo enviada a inscrição estadual para busca de dados (vai ser alterado para cnpj)
            {
                int cod = Convert.ToInt16(dataGridViewReg.Rows[e.RowIndex].Cells[0].Value);
                CadastroCd.id_reg = cod;
                this.Close();
            }
        }

        public void AtualizaReg()
        {
            RegArmazenagem region = new RegArmazenagem();
            reg.Clear();
            dataGridViewReg.Rows.Clear();
            region.RetornoReg(1);
            foreach (RegArmazenagem obj in reg)
            {
                dataGridViewReg.Rows.Add(obj.Id, obj.Name, obj.Status);
            }
        }
        public void GravarListaReg(int id, string name, string status)
        {
            reg.Add(new RegArmazenagem(id, name, status));
        }
        private void AtualizaTable(object sender, EventArgs e)
        {
            AtualizaReg();
        }
    }
}
