namespace PruebasControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            miControlCURP.LimpiarCampos();
        }

        private void miControlCURP_CurpGenerada(object sender, string e)
        {
            lblCurpGenerada.Text = e;
        }
    }
}
