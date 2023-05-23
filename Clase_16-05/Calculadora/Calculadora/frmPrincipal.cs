using System.Linq.Expressions;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        int num1, num2;
        ushort op;
        string msg = "No se puede dividir entre 0";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (resultado.Text == msg) resultado.Text = "0";
            if (resultado.Text != "0") resultado.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "1";
            else resultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "2";
            else resultado.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "3";
            else resultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "4";
            else resultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "5";
            else resultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "6";
            else resultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "7";
            else resultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "8";
            else resultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" || resultado.Text == msg) resultado.Text = "9";
            else resultado.Text += "9";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            resultado.Text = "";
            op = 1;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            resultado.Text = "";
            op = 2;
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            resultado.Text = "";
            op = 3;
        }

        private void division_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(resultado.Text);
            resultado.Text = "";
            op = 4;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(resultado.Text);

            switch (op)
            {
                case 1:
                    resultado.Text = (num1 + num2).ToString();
                    break;
                case 2:
                    resultado.Text = (num1 - num2).ToString();
                    break;
                case 3:
                    resultado.Text = (num1 * num2).ToString();
                    break;
                case 4:
                    if (num2 == 0) resultado.Text = "No se puede dividir entre 0";
                    else resultado.Text = (num1 / num2).ToString();
                    break;
                default:
                    break;
            }

            num1 = num2 = 0;
            op =  0;
        }
    }
}