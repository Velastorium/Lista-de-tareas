using System;
using System.Collections.Generic;

public class ListaDeTareas
{
    private List<Tarea> tareas = new List<Tarea>();

    public void AgregarTarea(string descripcion, DateTime? fechaLimite = null)
    {
        tareas.Add(new Tarea(descripcion, fechaLimite));
        Console.WriteLine("Tarea agregada.");
    }

    public void ListarTareas()
    {
        Console.WriteLine("Listado de tareas:");
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }

    public void MarcarTareaComoCompletada(int indice)
    {
        if (indice >= 0 && indice < tareas.Count)
        {
            tareas[indice].Completada = true;
            Console.WriteLine("Tarea completada.");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }

    public void EliminarTarea(int indice)
    {
        if (indice >= 0 && indice < tareas.Count)
        {
            tareas.RemoveAt(indice);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }
}
