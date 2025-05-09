
using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class EntrenadorTests
    {
        [Fact]


        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            //Arrange
            var usuario = new Usuario("Juan", 27, "Resistencia");
            var entrenador = new Entrenador("Carlos", "Fuerza");

            //Act
            entrenador.AsginarUsuario(usuario);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());

        }
    }
}
