class Program
{
    static void Main(string[] args)
    {
        ListaDeTareas listaDeTareas = new ListaDeTareas();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenú de tareas:");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como completa");
            Console.WriteLine("4. Eliminar tarea");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        Console.Write("Descripción de la tarea: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("Fecha límite (opcional, Ingresarla con el siguiente formato: YYYY-MM-DD): ");
                        string fechaInput = Console.ReadLine();
                        DateTime? fechaLimite = null;
                        if (!string.IsNullOrEmpty(fechaInput))
                        {
                            fechaLimite = DateTime.Parse(fechaInput);
                        }
                        listaDeTareas.AgregarTarea(descripcion, fechaLimite);
                        break;

                    case "2":
                        listaDeTareas.ListarTareas();
                        break;

                    case "3":
                        Console.Write("Número de la tarea que vamos a marcar como completada: ");
                        int indiceCompletar = int.Parse(Console.ReadLine()) - 1;
                        listaDeTareas.MarcarTareaComoCompletada(indiceCompletar);
                        break;

                    case "4":
                        Console.Write("Número de la tarea que vamos a eliminar: ");
                        int indiceEliminar = int.Parse(Console.ReadLine()) - 1;
                        listaDeTareas.EliminarTarea(indiceEliminar);
                        break;

                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error en el formato que estamos recibiendo: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
