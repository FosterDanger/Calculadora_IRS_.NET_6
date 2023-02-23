using TecNM.Practica3.Core.Services.Interfaces;
using TecNM.Practica3.Core.Entities;
namespace TecNM.Practica3.Core.Services;

public class IsrService: IIsrService
{
    public OutputISR ProcessIsr(InputISR inputISR){
        var outputIsr = new OutputISR();
        var salario = inputISR.salarioBruto;
        Decimal Base = 0m;
        Decimal resultado=0m;
        Decimal[,] matriz = new Decimal[11, 4] { 
        { 0.01m, 7735.00m, 0.00m, 1.92m}, 
        { 7735.01m, 65651.07m, 148.51m, 6.40m }, 
        { 65651.08m, 115375.90m, 3855.14m, 10.88m },
        {115375.91m,134119.41m,9265.20m,16.00m},
        {134119.42m, 160577.65m,12264.16m,17.92m},
        {160577.66m,323862.00m,17005.47m,21.36m},
        {323862.01m,510451.00m,51883.01m,23.52m},
        {510451.01m,974535.03m,95768.74m,30.00m},
        {974535.04m,1299380.04m,234993.95m,32.00m},
        {1299380.05m,3898140.12m,338944.34m,34.00m},
        {3898140.13m,0m,1222522.76m,35.00m}};

        for (int i = 0; i < 11; i++)
        {
            if(salario >= matriz[i,0] && salario <= matriz[i,1]){
                 Base = salario - matriz[i,0]; 
                resultado = Base * (matriz[i,3]/100m);
                outputIsr.ISR = resultado + matriz[i,2]; 
                break;
            }
             else if(salario >= 3898140.13m)
             {
                Base = salario - matriz[10,0]; 
                resultado = Base * (matriz[10,3]/100m);
                outputIsr.ISR = resultado + matriz[10,2]; 
                
                break;
             }
                
        }
       

        return outputIsr;
    }
}