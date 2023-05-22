namespace Ensayo_Form
{
    public partial class frmPrincipal : Form
    {
        float total = 0;
        ulong num_reserva;
        string varInicio = "", varBanda = "";
        ushort duracion_reserva, cont = 0;
        CEnsayo res1 = null, maymon = new CEnsayo("", 0, "");

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEnsayo.Cost = float.Parse(costo.Text);
            CEnsayo.Desc = float.Parse(descuento.Text);

            costo.Text = CEnsayo.Cost.ToString();
            descuento.Text = CEnsayo.Desc.ToString();

            costo.ReadOnly = true;
            descuento.ReadOnly = true;

            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num_reserva = ulong.Parse(numReserva.Text);

            if (num_reserva == 0)
            {
                mayor.Text = maymon.DarDatos();
                montoTotal.Text = "El total recaudado es de $" + total + " dolares (a 450 pesos) o $" + total * 450 + " pesos";

                button2.Visible = false;
                label9.Visible = false;
                costoFinal.Visible = false;
                numReserva.Visible = false;
                inicio.Visible = false;
                duracion.Visible = false;
                banda.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                mayor.Visible = true;
                montoTotal.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                if (cont == 0)
                {
                    mayor.Text = "No se ingresaron reservas validas";
                    montoTotal.Text = "0";
                }
            }
            else
            {
                cont++;

                varInicio = inicio.Text;
                duracion_reserva = ushort.Parse(duracion.Text);
                varBanda = banda.Text;

                res1 = new CEnsayo(varInicio, duracion_reserva, varBanda);
                res1.Numres = num_reserva;

                costoFinal.Text = ("Costo: $" + res1.DarMontoTotal());
                total += res1.DarMontoTotal(450);

                if (CEnsayo.MayorMonto(res1, maymon) == res1) maymon = res1;

                num_reserva = ulong.Parse(numReserva.Text);

                numReserva.Text = "0";
                inicio.Text = "0";
                duracion.Text = "0";
                banda.Text = "";
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            costo.Text = "0";
            descuento.Text = "0";
            numReserva.Text = "0";
            inicio.Text = "0";
            duracion.Text = "0";
        }
    }
}