namespace Gestion_De_Socios
{
    internal class CEntrenador: CSocio
    {
        private string telefono;

        public CEntrenador(string dni, string ape, string nom, string tel) : base(dni, ape, nom)
        {
            this.telefono = tel;
        }

        public string GetTefelono()
        {
            return this.telefono;
        }

        public void SetTelefono(string tel)
        {
            this.telefono = tel;
        }

        public override string DarDatos()
        {
            return base.DarDatos() + " - Contacto: " + this.telefono;
        }
    }
}
