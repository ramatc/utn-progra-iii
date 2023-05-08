namespace Sala_De_Ensayo
{
    public class CReserva
    {
        private ulong numero_reserva;
        private string inicio_reserva;
        private ushort duracion;
        private static float costo_por_hora;
        private static float descuento;
        private string banda;

        // Ejercicio 5
        public CReserva(string inicio, ushort duracion, string Band)
        {
            this.inicio_reserva = inicio;
            this.duracion = duracion;
            this.banda = Band;
        }

        // Ejercicios 2 y 6
        public ulong Numres
        {
            get { return this.numero_reserva; }
            set { this.numero_reserva = value; }
        }

        // Ejercicio 3
        public static float Cost
        {
            set { CReserva.costo_por_hora = value; }
        }

        // Ejercicio 4
        public static float Desc
        {
            set { CReserva.descuento = value; }
        }

        // Ejercicio 10
        public string Band
        {
            get { return this.banda; }
            set { this.banda = value; }
        }

        // Ejercicio 7
        public float DarMontoTotal()
        {
            if (this.duracion >= 6)
            {
                return (this.duracion * CReserva.costo_por_hora) * (1 - (CReserva.descuento / 100));
            }
            return (float)this.duracion * CReserva.costo_por_hora;
        }

        // Ejercicio 8
        public float DarMontoTotal(float cotizacion)
        {
            if (this.duracion >= 6)
            {
                return ((this.duracion * CReserva.costo_por_hora) * (1 - (CReserva.descuento / 100))) / cotizacion;
            }
            return ((float)this.duracion * CReserva.costo_por_hora) / cotizacion;
        }

        // Ejercicio 9
        public string DarDatos()
        {
            string datos = "Numero de reserva: " + this.numero_reserva.ToString();
            datos += "\nInicio de reserva: " + this.inicio_reserva;
            datos += "\nDuracion: " + this.duracion.ToString();
            datos += "\nCosto por hora: " + CReserva.costo_por_hora.ToString() + "$";
            datos += "\nDescuento: " + CReserva.descuento.ToString() + "%";
            datos += "\nBanda: " + this.banda;
            datos += "\nTotal: " + this.DarMontoTotal().ToString() + "$";
            return (datos);
        }

        // Ejercicio 11
        public static CReserva MayorMonto(CReserva reserva1, CReserva reserva2)
        {
            if (reserva1.DarMontoTotal() > reserva2.DarMontoTotal())
            {
                return reserva1;
            }
            else
            {
                return reserva2;
            }

        }
    }
}