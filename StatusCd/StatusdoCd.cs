namespace Vanilla.StatusCd
{
    public partial class StatusdoCd : Form
    {
        Classstatuscd status = new Classstatuscd();
        static decimal[] values = new decimal[6];
        public StatusdoCd()
        {
            InitializeComponent();
        }
        public void AlterarValores(decimal total, decimal pulmaot, decimal pulmaol, decimal pickingt, decimal pickingl)
        {
            if (total != 0)
            {
                values[0] = total;
                values[1] = pulmaot - pulmaol;
                values[2] = pickingt - pickingl;
                values[3] = ((values[1] + values[2]) / total);
                values[4] = pulmaot;
                values[5] = pickingt;
            }
            else
            {
                values[0] = 0;
                values[1] = 0;
                values[2] = 0;
                values[3] = 0;
                values[4] = 0;
                values[5] = 0;
            }
        }
        public void Mostrar()
        {
            status.RetornaStatus();
            Ltotal.Text = values[0].ToString();
            Lquantp.Text = $"{values[1]}/{values[4]}";
            Lquantpk.Text = $"{values[2]}/{values[5]}";
            Lporcent.Text = $"{(values[3] * 100).ToString("f1")}%";
        }
    }

}
