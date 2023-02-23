using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.App;
 
 public static class Program
 {
    public static void Main(string[] args){
        
        Decimal salario = 0;

        System.Console.WriteLine("Please enter your gross salary: ");
        if (Single.TryParse(System.Console.ReadLine(), out float salarioConvertido))
        {
            salario = (Decimal)salarioConvertido;
            // El valor se convirtió correctamente, ahora se puede utilizar la variable "salario"
        }
        else
        {
            // La conversión falló, manejar el error adecuadamente
            System.Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        
        var inputIrs  = new InputISR{salarioBruto = salario};

        var service = new IsrService();
        var manager = new IsrManager(service);

         OutputISR outputISR = manager.GetOutputISR(inputIrs);

        System.Console.WriteLine($"Su IRS(Impuesto sobre la renta) es: {outputISR.ISR}");
          
     } 
 }
