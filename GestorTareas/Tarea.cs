public class Tareaa
{
    public string Nombre { get; set; }
    public bool Completada { get; set; }
    // LA LINEA 3 Y 4 FACILITAN ENCAPSULACION Y SON PROPIEDADES AUTOMATICAS
    public Tareaa(string nombre)
    {
        Nombre = nombre;
        Completada = false;
    }
    //6 A 10 CONSTRUCTOR, OBLIGA A QUE TODA TAREA TENGA
    // UN NOMBRE AL CREARSE
    public void MarcarCompleta()
    {
        Completada = true;
    }
    //13 A 16 ENCAPSULA Y PERMITE CAMBIAR EL ESTADO DE LA TAREA
    public override string ToString()
    {
        string estado = Completada ? "Completada" : "Pendiente";
        return $"{Nombre} [{estado}]";
    }
    //18 A 22 TOSTRING PARA DAR ESTRUCTURA A LA TAREA
}
