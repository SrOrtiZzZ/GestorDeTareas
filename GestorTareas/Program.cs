class Program
{
    static void Main(string[] args)
    {
        GestorDeTareass gestor = new GestorDeTareass(5);

        int opcion;

        do
        {
            Console.WriteLine("\n==== GESTOR DE TAREAS ====");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.WriteLine("5. Marcar tarea como completa");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre de la tarea: ");
                    string nombre = Console.ReadLine();
                    gestor.AgregarTarea(nombre);
                    break;

                case 2:
                    gestor.ListarTareas();
                    break;

                case 3:
                    Console.Write("Número de la tarea a eliminar: ");
                    int num = int.Parse(Console.ReadLine());
                    gestor.EliminarTarea(num);
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                case 5:
                    Console.Write("Número de la tarea a marcar como completa: ");
                    int numCompleta = int.Parse(Console.ReadLine());
                    gestor.MarcarTareaCompleta(numCompleta);
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

        } while (opcion != 4);
    }
}
