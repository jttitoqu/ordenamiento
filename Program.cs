List<int> listaEnteros = new List<int> {5, 7, 2, 4, 9, 1};

MostrarNumeroMayorYMenor(listaEnteros);
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

static void MostrarNumeroMayorYMenor(List<int> lista)
{
    int menor = lista[0];
    int mayor = lista[0];
    if(lista == null || lista.Count == 0)
    {
        throw new ArgumentException("La lista está vacía");
    }


    for (int i = 1; i < lista.Count; i++)
    {    
        if (lista[i] > mayor)//5 7 2 ,9 3
        {
            mayor = lista[i];
        }
    }

    for (int i = 1; i < lista.Count; i++)
    {    
        if (lista[i] < menor)//5 7 2 ,9 3
        {
            menor = lista[i];
        }
    }
    Console.WriteLine($"El numero menor es {menor} y el numero mayor es {mayor}");
}