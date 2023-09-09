using System;
using System.Collections.Generic;
namespace Full_GRASP_And_SOLID.Library
{

    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
    // Para implementar este cambio se utiliza el principio SRP y el Expert.
    // SRP: La clase tiene como única responsabilidad imprimir la receta
    // Expert: La clase tiene la suficiente información (el objeto Recipe recibido) para realizar todo lo que tiene que hacer.
}