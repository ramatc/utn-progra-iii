namespace Aterrizaje
{
    public class CAereo: CViaje
    {
        private static float impuesto;
        private string tipoDeVuelo;
        public static void SetImpuesto(float impuesto)
        {
            CAereo.impuesto = impuesto;
        }
        public static float GetImpuesto()
        {
            return CAereo.impuesto;
        }
        public CAereo(string cod, string ori, string des, float precio, string tipo) : base(cod, ori, des) { 
            this.PrecioViaje = precio;
            this.tipoDeVuelo = tipo;
        }

        public override string DarDatos()
        {
            return base.DarDatos() + " - Impuesto: $" + CAereo.impuesto.ToString() + "\n Tipo de vuelo: " + this.tipoDeVuelo;
        }
    }
}
