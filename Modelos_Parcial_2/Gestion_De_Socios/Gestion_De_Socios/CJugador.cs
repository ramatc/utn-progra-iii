namespace Gestion_De_Socios
{
    internal class CJugador: CSocio
    {
        private EPosicion posicion;

        public CJugador(string dni, string ape, string nom, EPosicion pos) : base(dni, ape, nom){
            this.posicion = pos;
        }

        public EPosicion GetPosicion()
        {
            return this.posicion;
        }

        public void SetPosicion(EPosicion posicion)
        {
            this.posicion = posicion;
        }

        public override string DarDatos()
        {
            return base.DarDatos() + " - Posición: " + this.posicion;
        }
    }
}
