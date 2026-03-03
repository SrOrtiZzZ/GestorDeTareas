public class GestorDeTareass
{
    private Tareaa[] tareas;
    private int contador;
    //4 LLEVA LA CUENTA DE LAS TAREAS
    public GestorDeTareass(int capacidad)
    {
        tareas = new Tareaa[capacidad];
        contador = 0;
    }
    //6 A 10 CONSTRUCTOR
    public void AgregarTarea(string nombre)
    {
        if (contador >= tareas.Length)
        {
            Console.WriteLine("No hay espacio para más tareas.");
            return;
        }

        tareas[contador] = new Tareaa(nombre);
        contador++;

        Console.WriteLine("Tarea agregada.");
    }
    //12 A 24 AGREGA TAREA, COMPROBANDO SI HAY ESPACIO Y SUMA CONTADOR AL CREAR UNA NUEVA
    public void ListarTareas()
    {
        if (contador == 0)
        {
            Console.WriteLine("No hay tareas.");
            return;
        }

        Console.WriteLine("--- TAREAS ---");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }
    //28 A 40 LISTAR TAREAS. SI CONT = 0, NO HAY TAREAS Y PARA
    //SINO, RECORRE TODO EL ARRAY Y LAS DEVUELVE
    public void EliminarTarea(int numero)
    {
        if (numero < 1 || numero > contador)
        {
            Console.WriteLine("Número inválido.");
            return;
        }
        int indice = numero - 1;

        for (int i = indice; i < contador - 1; i++)
        {
            tareas[i] = tareas[i + 1];
        }
        tareas[contador - 1] = null;
        contador--;
        Console.WriteLine("Tarea eliminada.");
    }// 43 A 60 ELIMINAR TAREA. CHEKEA QUE EL NUM SEA VALIDO
    //EN CASO DE NO SER, PARA. SINO,BORRA Y RESTA EN CONTADOR.
    public void MarcarTareaCompleta(int numero)
    {
        if (numero < 1 || numero > contador)
        {
            Console.WriteLine("Número inválido.");
            return;
        }
        tareas[numero - 1].MarcarCompleta();
        Console.WriteLine("Tarea marcada como completa.");
    }
    //63 A 80 MARCAR TAREA COMPLETA. CHEKEA NUM VALIDO
    //SI NO, PARA. SINO, MARCA LA TAREA COMO COMPLETA
}
