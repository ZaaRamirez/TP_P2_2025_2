using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;
using System.Xml;

Console.WriteLine("====SISTEMA DE GESTION DE GIMNASIO 'PROGRAM POWER'");

//Crear Usuario
Console.WriteLine("Ingresa el nombre del usuario: ");
string nombreUsuario = Console.ReadLine()??"";

Console.WriteLine("Ingresa la edad del usuario: ");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (e.g. Fuerza, Resistencia, etc.)");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear Entrenador

Console.WriteLine("Ingresa el nombre del entrenador: ");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrendor (e.g. Fuerza, Resistencia, etc.)");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//Crear Rutina

Console.WriteLine("Ingresa el nombre de la rutina: ");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duracion de la rutina en minutos");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Aregar ejercicios a la rutina
Console.WriteLine("¿Cuantos ejercicios tiene la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= numEjercicios; i ++)
{
    //Crear ejercicio
    Console.WriteLine($"Ejercicio {i}");
    Console.WriteLine("Nombre del ejercicio: ");
    string nombreEjercicio = Console.ReadLine() ?? "";
    Console.WriteLine("Numero de repeticiones de ejercicio: ");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Numero de series de ejercicio: ");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Tiempo de descanso en minutos de ejercicio: ");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);

    //Asignar ejercicio a rutina

    rutina.AgregarEjercicio(ejercicio);
}

//Asignar rutina y entrenador al usuario

AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostrar resumen

Console.WriteLine("====Resumen de asignacion por 'PROGRAM POWER'");
Console.WriteLine($"Usuario: {usuario.Nombre}\n{usuario.Objetivo}");
Console.WriteLine($"Rutina asignada:{usuario.RutinaAsignada.Nombre}");
Console.WriteLine("Ejercicios a realizar:");

foreach (var e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre}|Series: {e.Series} | Repeticiones: {e.Repeticiones} | Tiempo de descanso: {e.Descanso}");
}

Console.WriteLine($"Entrenador asignado: {entrenador.Nombre} con especialidad: {entrenador.Especialidad}");

