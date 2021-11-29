namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(labelLado.Text == "")
            {
                errorProvider1.SetError(labelLado, "Debe Ingresar el lado");
                labelLado.Focus();
                return;
            }
            errorProvider1.SetError(labelLado, "");

            double LADO;
            if(!double.TryParse(labelLado.Text, out LADO))
            {
                errorProvider1.SetError(labelLado, "Debe Ingresar Numeros");
                labelLado.Focus();
                return;
            }
            //xd
            errorProvider1.SetError(labelLado, "");

            float lado = float.Parse(labelLado.Text);
            float area = lado * lado;
            labelArea.Text = area.ToString("n2");
        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            labelArea.Clear();
            labelLado.Clear();
            labelLado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar la APP", "Hasta Pronto");
            this.Close();
        }
    }
}