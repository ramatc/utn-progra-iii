namespace Formulario_Basico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "") txtNum1.Text = "0";
            if (txtNum2.Text == "") txtNum2.Text = "0";

            int suma = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
            salidaFinal.Text = "La suma entre " + txtNum1.Text + " y " + txtNum2.Text + " es: " + suma;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "") txtNum1.Text = "0";
            if (txtNum2.Text == "") txtNum2.Text = "0";

            int resta = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
            salidaFinal.Text = "La resta entre " + txtNum1.Text + " y " + txtNum2.Text + " es: " + resta;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "") txtNum1.Text = "0";
            if (txtNum2.Text == "") txtNum2.Text = "0";

            int multiplicacion = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
            salidaFinal.Text = "La multiplicación entre " + txtNum1.Text + " y " + txtNum2.Text + " es: " + multiplicacion;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "") txtNum1.Text = "0";
            if (txtNum2.Text == "") txtNum2.Text = "0";

            if (txtNum2.Text == "0") salidaFinal.Text = "No se puede dividir entre 0";
            else
            {
                int division = int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);
                salidaFinal.Text = "La división entre " + txtNum1.Text + " y " + txtNum2.Text + " es: " + division;
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "") txtNum1.Text = "0";
            if (txtNum2.Text == "") txtNum2.Text = "0";

            float promedio = (int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)) / 2;
            salidaFinal.Text = "El promedio de " + txtNum1.Text + " y " + txtNum2.Text + " es: " + promedio;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
        }
    }
}