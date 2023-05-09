namespace Agencia_De_Turismo
{
    public class CPaquete
    {
        private static float impuesto;
        private ushort num_paquete;
        private string detalle = "";
        private float costo;

        public CPaquete(ushort numero, string descripcion)
        {
            this.num_paquete = numero;
            this.detalle = descripcion;
        }

        public static void SetImpuesto(float porcentaje)
        {
            CPaquete.impuesto = porcentaje;
        }

        public void SetCosto(float monto)
        {
            this.costo = monto;
        }

        public float GetCosto()
        {
            return this.costo;
        }

        public float DarPrecio()
        {
            return this.costo * (1F + CPaquete.impuesto / 100);
        }

        public float DarPrecio(ushort cuotas)
        {
            float penalizacion = 0;
            for (ushort i = 1; i < cuotas; i++)
            {
                penalizacion += 10;
            }

            return this.DarPrecio() * (1F + penalizacion / 100);
        }

        public string DarDatos()
        {
            string datos = "Numero de paquete: " + this.num_paquete.ToString();
            datos += "\nDetalle del paquete: " + this.detalle;
            datos += "\nCosto: " + this.costo.ToString();
            datos += "\nImpuesto: " + CPaquete.impuesto.ToString() + "%";
            datos += "\nPrecio a abonar: $" + this.DarPrecio().ToString();
            return datos;
        }

        public float Costo
        {
            get { return this.costo; }
            set { this.costo = value; }
        }

        public bool EsMasBaratoQue(CPaquete otroPaquete)
        {
            return this.DarPrecio() < otroPaquete.DarPrecio();
        }
    }
}