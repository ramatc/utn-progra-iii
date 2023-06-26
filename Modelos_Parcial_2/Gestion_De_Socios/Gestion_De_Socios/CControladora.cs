namespace Gestion_De_Socios
{
    public class CControladora
    {
        public static void Main()
        {
            //CCatálogo listadoVuelos = new CCatálogo();
            char opcion;
            do
            {
                char.TryParse(CInterfaz.DarOpcion().ToUpper(), out opcion);
                switch (opcion)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case 'S':
                        break;
                    default:
                        CInterfaz.MostrarInfo("Opción inválida");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}

