using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasio.Test
{
    public class AsignadorRutinasTests
    {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarUsuarioCorrectamente()
        {
            //Arrange

            var usuario = new Usuario("Carlos", 25, "Fuerza");
            var rutina = new Rutina("FabianRutine", 20);
            var asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarRutinaAUsuario(usuario, rutina);

            //Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]

        public void AsignarUsuarioAEntrenador_DebeIncluirUsuario()
        {
            //Arrange

            var usuario = new Usuario("Carlos", 25, "Fuerza");
            var entrenador = new Entrenador("Carlos", "Fuerza");
            var asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
