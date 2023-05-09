namespace Agencia_De_Turismo
{
    public class CEjecutora
    {
        public static void Main()
        {
            ushort num_paquete;
            CPaquete paquete_aux, mas_barato = null;

            Console.Write("Ingrese el porcentaje de impuesto a aplicar sobre los paquetes: ");
            CPaquete.SetImpuesto(Convert.ToSingle(Console.ReadLine()));

            Console.Write("\nIngrese número de paquete (0 para terminar): ");
            while (!ushort.TryParse(Console.ReadLine(), out num_paquete))
            {
                Console.Write("Ingresé un número de reserva valido: ");
            }

            if (num_paquete == 0)
            {
                Console.WriteLine("No se ingresaron paquetes turísticos válidos.");
            }
            else
            {
                while (num_paquete != 0)
                {
                    Console.Write("Ingresé el detalle del paquete: ");
                    paquete_aux = new CPaquete(num_paquete, Console.ReadLine());

                    Console.Write("Ingresé el costo del paquete: ");
                    paquete_aux.SetCosto(Convert.ToSingle(Console.ReadLine()));

                    if (mas_barato == null || paquete_aux.EsMasBaratoQue(mas_barato))
                    {
                        mas_barato = paquete_aux;
                    }

                    Console.Clear();
                    Console.Write("\nIngrese número de paquete (0 para terminar): ");
                    num_paquete = ushort.Parse(Console.ReadLine());
                }
            }

            if (mas_barato != null)
            {
                Console.WriteLine("Paquete turístico más barato: \n{0}", mas_barato.DarDatos());
                Console.WriteLine("Precio del paquete turístico más barato (En 1 pago - cuota): ${0}", mas_barato.DarPrecio().ToString());
                Console.WriteLine("Precio del paquete turístico más barato (En 12 pagos - cuotas): ${0}", mas_barato.DarPrecio(12).ToString());
            }

            Console.Write("Pulse ENTER.");
            Console.ReadLine();
        }
    }
}