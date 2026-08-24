List<int> listaEnteros = new List<int> {5, 7, 2, 4};

Console.WriteLine("El promedio es:" + CalcularPromedio(listaEnteros));

static double CalcularPromedio(List<int> lista)
{
    if(lista == null || lista.Count == 0)
    {
        throw new ArgumentException("La lista está vacía");
    }

    double acumulador = 0;

    foreach(int numero in lista)
    {
        acumulador = acumulador + numero;
    }
    
    return acumulador/lista.Count;
}