namespace Ensayo_Form
{
    public class CEnsayo
    {
        private ulong numero_reserva;
        private string inicio_reserva;
        private ushort duracion;
        private static float costo_por_hora;
        private static float descuento;
        private string banda;

        public CEnsayo(string inicio, ushort duracion, string Band)
        {
            this.inicio_reserva = inicio;
            this.duracion = duracion;
            this.banda = Band;
        }

        public ulong Numres
        {
            get { return this.numero_reserva; }
            set { this.numero_reserva = value; }
        }

        public static float Cost
        {
            get { return CEnsayo.costo_por_hora; }
            set { CEnsayo.costo_por_hora = value; }
        }

        public static float Desc
        {
            get { return CEnsayo.descuento; }
            set { CEnsayo.descuento = value; }
        }

        public string Band
        {
            get { return this.banda; }
            set { this.banda = value; }
        }

        public float DarMontoTotal()
        {
            if (this.duracion >= 6) return (this.duracion * CEnsayo.costo_por_hora) * (1 - (CEnsayo.descuento / 100));
            return (float)this.duracion * CEnsayo.costo_por_hora;
        }

        public float DarMontoTotal(float cotizacion)
        {
            if (this.duracion >= 6) return ((this.duracion * CEnsayo.costo_por_hora) * (1 - (CEnsayo.descuento / 100))) / cotizacion;
            return ((float)this.duracion * CEnsayo.costo_por_hora) / cotizacion;
        }

        public string DarDatos()
        {
            string datos = "Numero de reserva: " + this.numero_reserva.ToString();
            datos += "\nInicio de reserva: " + this.inicio_reserva;
            datos += "\nDuracion: " + this.duracion.ToString();
            datos += "\nCosto por hora: $" + CEnsayo.costo_por_hora.ToString();
            datos += "\nDescuento: " + CEnsayo.descuento.ToString() + "%";
            datos += "\nBanda: " + this.banda;
            datos += "\nTotal: $" + this.DarMontoTotal().ToString();
            return (datos);
        }
        
        public static CEnsayo MayorMonto(CEnsayo reserva1, CEnsayo reserva2)
        {
            if (reserva1.DarMontoTotal() > reserva2.DarMontoTotal()) return reserva1;
            else return reserva2;
        }
    }
}