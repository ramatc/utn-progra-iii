using System;
namespace Aterrizaje
{
    public class CViaje:IComparable
    {
        //Variables miembro de instancia
        private string codigo;
        private string origen;
        private string destino;
        private float precio;
        //Metodos miembro de instancia
        //Constructor
        public CViaje(string cod, string ori, string des)
        {
            this.codigo = cod;
            this.origen = ori;
            this.destino = des;
        }
        //Getters
        public string GetCodigo()
        {
            return this.codigo;
        }
        public string GetOrigen()
        {
            return this.origen;
        }
        public string GetDestino() { 
            return this.destino;
        }
        //Propiedad
        public float PrecioViaje
        {
            set { this.precio = value; }
            get { return this.precio; }
        }
        //Metodos funcionales de instancia
        public float DarPrecio(byte cuota)
        {
            float recargo = 0.0f;

            if(cuota == 1){
                recargo = 0.0F;
            } else if(cuota == 3) {
                recargo = 10.0F;
            }
            else if(cuota == 6) {
                recargo = 20.0F;
            }
            else if(cuota == 12) {
                recargo = 40.0F;
            } else {
                Exception miExcepcion = new Exception(String.Format("Cantidad de cuotas inválida ({0}) - Deben ser 1,3,6 o 12.", cuota));
                throw miExcepcion;
            }

            return this.precio * (1F + recargo / 100);
        }
        public virtual string DarDatos()
        {
            return "[" + this.codigo + "] - " + this.origen + " => " + this.destino + " - $: " + this.precio.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj is CViaje)
            {
                if (this.origen == ((CViaje)obj).GetOrigen() && this.destino == ((CViaje)obj).GetDestino()) return 0;
                else if (this.origen == ((CViaje)obj).GetOrigen()) return 1;
                else if (this.destino == ((CViaje)obj).GetDestino()) return 2;
                else return 3;
            }
            else
            {
                throw new Exception("Sólo se puede comparar instancias de CViaje");
            }
        }
    }
}
