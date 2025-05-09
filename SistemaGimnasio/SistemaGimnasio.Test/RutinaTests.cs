using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class RutinaTests
    {
        [Fact]

        public void AgregarEjercicio_DebeAgregarALista()
        {
            //Arrenge

            var rutina = new Rutina("FabianRutine",20);
            var ejercicio1 = new Ejercicio("Sentadilla hungara",15,3,2);
            var ejercicio2 = new Ejercicio("Curl de biceps", 10, 4, 1);

            //Act

            rutina.AgregarEjercicio(ejercicio1);
            rutina.AgregarEjercicio(ejercicio2);

            //Assert

            Assert.NotEmpty(rutina.ObtenerEjercicios());
        }
    }
}
