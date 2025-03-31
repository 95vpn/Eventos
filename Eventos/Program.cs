using Eventos;

int opcion = 0;

do
{
    Console.WriteLine("1. Eventos con delegados");
    Console.WriteLine("2. Evento con EvenHandler");
    Console.WriteLine("3. Eventos con delegados y expresion lambda");
    Console.WriteLine("4. Eventos con EventHandler y expresiones Lambda");
    Console.WriteLine("10. Salir");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            clsRepositorioDelegado repo = new clsRepositorioDelegado();
            repo.ReportaAvance  += MuestraAvance;
            repo.ObtenTodos();
            break;
        case 2:
            clsRepositorioEventHandler repo2 = new clsRepositorioEventHandler();
            repo2.ReportaAvance += MuestraAvance2;
            repo2.ObtenTodos();
            break;
        case 3:
            clsRepositorioDelegado repo3 = new clsRepositorioDelegado();
            repo3.ReportaAvance += (int i) => { Console.Write(i.ToString() + " "); };
            repo3.ObtenTodos();
            break;
        case 4:
            clsRepositorioEventHandler repo4 = new clsRepositorioEventHandler();
            repo4.ReportaAvance += (object? sender, Argumentos e) => { Console.Write(e.Valor.ToString() + " "); };
            repo4.ObtenTodos();
            break;
        default:
            break;
    }
} while (opcion != 10);

void MuestraAvance2(object? sender, Argumentos e)
{
    Console.Write(e.Valor.ToString() + " ");
}

void MuestraAvance(int valor)
{
    Console.WriteLine(valor.ToString() + "");
}