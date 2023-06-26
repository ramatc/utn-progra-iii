namespace Gestion_De_Socios
{
    abstract class CSocio: IComparable
    {
        private string dni;
        private string apellido;
        private string nombre;

        public CSocio(string dni, string ape, string nom)
        {
            this.dni = dni;
            this.apellido = ape;
            this.nombre = nom;
        }

        public CSocio() : this("XX.XXX.XXX", "NN", "NN") { }

        public string DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public virtual string DarDatos()
        {
            string datos = "DNI: " + this.dni;
            datos += " - Apellido, Nombre: " + this.apellido + ", " + this.nombre;
            return datos;
        }

        public int CompareTo(object obj)
        {
            if (obj is CSocio)
            {
                return this.apellido.CompareTo(((CSocio)obj).apellido);
            }
            return int.MaxValue;
        }
    }
}
