using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Servicios
{
    public class AsignadorRutinas
    {
        //Metodos
        public void AsignarRutinaAUsuario(Usuario usuario, Rutina rutina)
        { 
            usuario.AsignarRutina(rutina);
        }

        public void AsignarUsuarioAEntrenador(Usuario usuario, Entrenador entrenador)
        {
            entrenador.AsginarUsuario(usuario);
        }
    }
}
