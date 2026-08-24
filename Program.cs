List<int> listaEnteros = new List<int> {4,8,1,9};

MostrarNumeroMayorYMenor(listaEnteros);
CalcularPromedio(listaEnteros);
OrdernarAscendente(listaEnteros);
OrdernarDescendente(listaEnteros);
BuscarNumero(listaEnteros,1);

static void CalcularPromedio(List<int> lista)

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
    
    Console.WriteLine($"El promedio es: {acumulador/lista.Count}");
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
        if (lista[i] > mayor)
        {
            mayor = lista[i];
        }
    }

    for (int i = 1; i < lista.Count; i++)
    {    
        if (lista[i] < menor)
        {
            menor = lista[i];
        }
    }
    Console.WriteLine($"El numero menor es {menor} y el numero mayor es {mayor}");
}

static void OrdernarAscendente(List<int> lista)
{
    int temp;
    for (int i = 0; i < lista.Count - 1; i++)
    {
        for (int j = 0; j < lista.Count - 1 - i; j++)
        {
            if(lista[j] > lista[j + 1])
            {
                temp = lista[j + 1];
                lista[j + 1] = lista[j];
                lista[j] = temp;
            }
        }
    }

    Console.WriteLine($"Orden Ascendente:" + string.Join(",",lista));
    
}

static void OrdernarDescendente(List<int> lista)
{
    int temp;
    for (int i = 0; i < lista.Count - 1; i++)
    {
        for (int j = 0; j < lista.Count - 1 - i; j++)
        {
            if(lista[j] < lista[j + 1])
            {
                temp = lista[j + 1];
                lista[j + 1] = lista[j];
                lista[j] = temp;
            }
        }
    }

    Console.WriteLine($"Orden Ascendente:" + string.Join(",",lista));
    
}

static void BuscarNumero(List<int> lista, int numero)
{
    bool existe = false;
    for (int i = 0; i < lista.Count - 1; i++)
    {
        if (numero == lista[i])
        {
            existe = true;
            break;
        }
        
    }

    Console.WriteLine(existe ? "El numero si existe en la lista" : "El numero no existe en la lista");

}
