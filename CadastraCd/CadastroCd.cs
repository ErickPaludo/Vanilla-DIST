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
    public partial class CadastroCd : Form
    {
        private Database db = new Database();
        static private List<LogisticaCD> cdList = new List<LogisticaCD>();
        public CadastroCd()
        {
            InitializeComponent();
        }
        private void GerarCd(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (minemp.Text == string.Empty)
            {
                minemp.Text = "0";
            }
            db.GravarCd(Convert.ToInt32(prediobox.Text), Convert.ToInt32(laandares.Text), Convert.ToInt32(minemp.Text));
            Cursor = Cursors.Default;
        }
        public void AtualizaTabelaRuas(int totalruas)
        {
            if (totalruas != 0)
            {
                for (int i = 1; i <= 7; i++)
                {
                    dataGridruas.Rows.Add("HAAAA");

                }
            }
        }
        public void AtualizaTabelaRua()
        {
            Cursor = Cursors.WaitCursor;
            db.RetornoCd(true, 0);
            Cursor = Cursors.Default;
        }

        /*    private void SelecionaRua(object sender, DataGridViewCellEventArgs e)
            {
                if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dataGridimpar.Rows.Clear();
                    dataGridpar.Rows.Clear();
                    int rua = Convert.ToInt32(dataGridruas.Rows[e.RowIndex].Cells[0].Value);
                    db.Filtro("vnl_la_cd", "id_rua", rua, 4);
                    foreach(LogisticaCD obj in cdList)
                    {
                        if(obj.Id_predio % 2 == 0)
                        {
                            dataGridpar.Rows.Add($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}");
                        }
                        else
                        {
                            dataGridimpar.Rows.Add($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}");
                        }
                    }
                    cdList.Clear();
                }
            }*/
        public void GravaListEndereco(int rua, int predio, int andar)
        {
            cdList.Add(new LogisticaCD(rua, predio, andar));
        }

        private void Atualizar(object sender, EventArgs e)
        {
            AtualizaTabelaRua();
        }
    }
}
