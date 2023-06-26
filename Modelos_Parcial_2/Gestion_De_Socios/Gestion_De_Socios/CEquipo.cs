using System.Collections;
namespace Gestion_De_Socios
{
    internal class CEquipo
    {
        private string codigo;
        private string nombre;
        private List<CJugador> jugadores = new List<CJugador>();
        private CEntrenador entrenador = null;
        
        public CEquipo(string cod, string nom) { 
            this.codigo = cod;
            this.nombre = nom;
            jugadores = new List<CJugador>();
        }

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public CEntrenador Entrenador
        {
            get { return this.entrenador; }
            set { this.entrenador = value; }
        }

        public List<CJugador> Jugadores
        {
            get { return this.jugadores; }
        }

        public void AgregarJugador(CJugador jugador)
        {
            this.jugadores.Add(jugador);
        }

        public bool AgregarEntrenador(string dni, string apellido, string nombre, string tel)
        {
            if(this.entrenador == null)
            {
                this.entrenador = new CEntrenador(dni, apellido, nombre, tel);
                return true;
            }

            return false;
        }

        public bool RemoverJugador(string dni)
        {
            foreach(CJugador jugador in this.jugadores)
            {
                if(jugador.DNI == dni)
                {
                    this.jugadores.Remove(jugador);
                    return true;
                }
            }

            return false;
        }

        public bool RemoverSocio(object obj)
        {
            if(obj is CJugador)
            {
                RemoverJugador(((CJugador)obj).DNI); return true;
            }

            if(obj is CEntrenador)
            {
                this.entrenador = null; return true;
            }

            return false;
        }

        public string DarDatos()
        {
            return "[COD]: " + this.codigo + "\n[NOMBRE]: " + this.nombre + "\n[DT]: " + entrenador.DarDatos(); ;
        }

        public void DarEquipo(string codigo)
        {
            if (codigo == this.codigo)
            {
                if (jugadores != null)
                {
                    jugadores.Sort();
                    foreach (CJugador jugador in jugadores)
                    {
                        Console.WriteLine(jugador.DarDatos());
                    }
                }
                else Console.WriteLine("No hay ningún jugador asignado a ese equipo");
            }
            else Console.WriteLine("No existe ningún equipo con ese código");
        }
    }
}
