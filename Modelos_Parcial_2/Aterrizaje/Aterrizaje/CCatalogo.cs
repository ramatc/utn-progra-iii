using Aterrizar;
using System.Collections;

namespace Aterrizaje
{
    public class CCatalogo
    {
        private ArrayList listado;
        public CCatalogo()
        {
            this.listado = new ArrayList(0);
        }
        public void SetImpuesto(float monto)
        {
            CAereo.SetImpuesto(monto);
        }
        public float GetImpuesto()
        {
            return CAereo.GetImpuesto();
        }
        public bool Registrar(string cod, string ori, string des, float prec, string tipo)
        {
            foreach (CAereo viaje in this.listado)
            {
                if (viaje.GetCodigo() == cod) return false;
            }

            this.listado.Add(new CAereo(cod, ori, des, prec, tipo));
            return true;
        }

        public bool Remover(string cod)
        {
            foreach (CAereo viaje in this.listado)
            {
                if (viaje.GetCodigo() == cod)
                {
                    this.listado.Remove(viaje);
                    return true;
                }
            }

            return false;
        }
        public string Mostrar(string cod)
        {
            foreach (CAereo aux in this.listado)
            {
                if (aux.GetCodigo() == cod)
                {
                    return aux.DarDatos();
                }
            }
            return "Vuelo inexistente";
        }
        public void Ordenar()
        {
            this.listado.Sort();
        }
        public string Mostrar()
        {
            string datos = "";
            foreach (CAereo aux in this.listado)
            {
                datos += aux.DarDatos() + "\n";
            }
            return datos;
        }
        public void Remover()
        {
            listado.Clear();
        }
    }
}
