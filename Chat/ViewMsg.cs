namespace Vanilla
{
    public partial class ViewMsg : Form, IViewMsg
    {
        ControllerMsg controller;
        public ViewMsg()
        {
            InitializeComponent();
        }
        public void SetController(ControllerMsg controller)
        {
            this.controller = controller;
        }

        private void Enviar(object sender, EventArgs e)
        {
            controller.EnviarMsg();
        }

        private void EscolheUser(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                controller.SeleiconaContato(dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
              
            }
        }

        public RichTextBox Allmsg
        {
            get
            {
                return richAllMsg;
            }
            set
            {
                richAllMsg = value;
            }
        }
        public TextBox UserText
        {
            get
            {
                return textInf;
            }
            set
            {
                textInf = value;
            }
        }
        public DataGridView GridUser
        {
            get
            {
                return dataGridUsers;
            }
            set
            {
                dataGridUsers = value;
            }
        }
        public Label Destinatario
        {
            get
            {
                return lDestinatario;
            }
            set
            {
                lDestinatario = value;
            }
        }
        public Button Env
        {
            get { return bEnv; }
            set { bEnv = value; }
        }

    }
}
