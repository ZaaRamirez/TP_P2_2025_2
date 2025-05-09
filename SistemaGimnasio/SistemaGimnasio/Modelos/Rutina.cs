
namespace SistemaGimnasio.Modelos
{
    public class Rutina
    {
        //Propiedades (Se requiere al instanciar el objeto Rutina)
        public string Nombre { get; set; }
        public int Duracion { get; set; }

        //Variable de clase (se construye en el flujo del programa)
        private List<Ejercicio> ejercicios;

        //Constructor

        public Rutina(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
            ejercicios = new List<Ejercicio>();
        }

        public void AgregarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Add(ejercicio);
        }

        public List<Ejercicio> ObtenerEjercicios()
        {
            return ejercicios;
        }

        public void BorrarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Remove(ejercicio);
        }
    }
}
