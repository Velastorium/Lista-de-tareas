public class Tarea
{
    public string Descripcion { get; set; }
    public DateTime? FechaLimite { get; set; }
    public bool Completada { get; set; }

    public Tarea(string descripcion, DateTime? fechaLimite = null)
    {
        Descripcion = descripcion;
        FechaLimite = fechaLimite;
        Completada = false;
    }

    public override string ToString()
    {
        return $"[ {(Completada ? "X" : " ")} ] {Descripcion} {(FechaLimite.HasValue ? $"(Fecha límite: {FechaLimite.Value.ToShortDateString()})" : "")}";
    }
}
