namespace Facultad
{
    public class CAlumno
    {
        private static float Cuota;

        private ulong legajo;
        private string apellidos;
        private string nombres;
        private float beca;

        public static void SetCuota(float cuo)
        {
            CAlumno.Cuota = cuo;
        }
        public static float GetCuota(float cuo)
        {
            return CAlumno.Cuota;
        }

        public CAlumno()
        {
            this.legajo = 99999999UL;
            this.apellidos = "N";
            this.nombres = "N";
            this.beca = 0.0F;
        }
        public CAlumno(ulong legajo, string apellidos, string nombres, float beca)
        {
            this.legajo = legajo;
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.beca = beca;
        }
        public CAlumno(ulong leg)
        {
            this.legajo = leg;
        }

        //Setters
        public void SetLegajo(ulong leg)
        {
            this.legajo = leg;
        }
        public void SetApellidos(string ape)
        {
            this.apellidos = ape;
        }
        public void SetNombres(string nom)
        {
            this.nombres = nom;
        }
        public void SetBeca(float beca)
        {
            this.beca = beca;
        }

        //Getters
        public ulong GetLegajo()
        {
            return this.legajo;
        }
        public string GetApellidos()
        {
            return this.apellidos;
        }
        public string GetNombres()
        {
            return this.nombres;
        }
        public float GetBeca() 
        { 
            return this.beca;
        }

        //Funcionales
        public float DarCuotaAlumno()
        {
            float cuo = CAlumno.Cuota;
            float monto = cuo * (1 - (this.beca / 100.0F));
            return monto;
        }
        
        public string DarDatos()
        {
            string datos = "Alumno de legajo: " + this.legajo.ToString();
            datos += " -Nombre completo: " + this.apellidos + ", " + this.nombres;
            datos += " -Cuota general: $" + CAlumno.Cuota.ToString();
            datos += " -Beca: " + this.beca.ToString() + "%";
            datos += " -Monto a pagar final: $" + this.DarCuotaAlumno().ToString();
            return datos;
        }
    }
}