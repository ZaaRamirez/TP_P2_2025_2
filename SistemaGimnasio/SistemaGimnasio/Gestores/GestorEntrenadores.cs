﻿using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Gestores
{
    public class GestorEntrenadores
    {
        private List<Entrenador> entrenadores;

        public GestorEntrenadores()
        {
            entrenadores = new List<Entrenador>();
        }

        public Entrenador BuscarEntrenador(string nombre)
        {
            return entrenadores.FirstOrDefault(e => e.Nombre ==nombre);
        }

        public void RegistrarEntrenador(string nombre, string especialidad)
        {
            entrenadores.Add(new Entrenador(nombre,especialidad));
        }

    }
}
