using System;
using System.Collections.Generic;

public class Ingrediente
{
    public string Nombre { get; }
    public int Cantidad { get; }

    public Ingrediente(string nombre, int cantidad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
    }

    public void ImprimirIngrediente()
    {
        Console.WriteLine($"Ingrediente: {Nombre}, Cantidad: {Cantidad} ml/gr");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Implementación de una pila
        Stack<Ingrediente> pilaIngredientes = new Stack<Ingrediente>();

        Console.WriteLine("Agregando ingredientes a la pila:");
        pilaIngredientes.Push(new Ingrediente("Azúcar", 200));
        pilaIngredientes.Push(new Ingrediente("Harina", 300));
        pilaIngredientes.Push(new Ingrediente("Huevos", 4));

        foreach (var ingrediente in pilaIngredientes)
        {
            ingrediente.ImprimirIngrediente();
        }

        Console.WriteLine("Despachando 1 ingrediente de la pila:");
        if (pilaIngredientes.Count > 0)
        {
            Ingrediente ingredienteSacado = pilaIngredientes.Pop();
            ingredienteSacado.ImprimirIngrediente();
        }

        Console.WriteLine("Ingredientes restantes en la pila:");
        foreach (var ingrediente in pilaIngredientes)
        {
            ingrediente.ImprimirIngrediente();
        }

        Console.WriteLine();

        // Implementación de una cola
        Queue<Ingrediente> colaIngredientes = new Queue<Ingrediente>();

        Console.WriteLine("Agregando ingredientes a la cola:");
        colaIngredientes.Enqueue(new Ingrediente("Leche", 500));
        colaIngredientes.Enqueue(new Ingrediente("Mantequilla", 150));
        colaIngredientes.Enqueue(new Ingrediente("Sal", 10));

        foreach (var ingrediente in colaIngredientes)
        {
            ingrediente.ImprimirIngrediente();
        }

        Console.WriteLine("Despachando 1 ingrediente de la cola:");
        if (colaIngredientes.Count > 0)
        {
            Ingrediente primerIngrediente = colaIngredientes.Dequeue();
            primerIngrediente.ImprimirIngrediente();
        }

        Console.WriteLine("Ingredientes restantes en la cola:");
        foreach (var ingrediente in colaIngredientes)
        {
            ingrediente.ImprimirIngrediente();
        }
    }
}
