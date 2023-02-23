
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.Tests;

public class ISRCalculatorService
{
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_0_01_AndUpperLimitOf_7735()
    {
       
        Decimal isrExpected = 115.199808m;
        var inputirs = new InputISR { salarioBruto = 6000};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(isrExpected, result.ISR);
    }
    
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_7735_AndUpperLimitOf_65651_07()
    {
        //arrange
        var cuotaFija = 148.51m;
        var sobreExcedente =  6.40m / 100m;
        var salario = 13500m;
        var montoInferior = 7735.01m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_65651_08_AndUpperLimitOf_115375_90()
    {
        //arrange
        var cuotaFija = 3855.14m;
        var sobreExcedente =  10.88m / 100m;
        var salario = 69000m;
        var montoInferior = 65651.08m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_115375_91_AndUpperLimitOf_134119_41()
    {
        //arrange
        var cuotaFija = 9265.20m;
        var sobreExcedente =  16.00m / 100m;
        var salario = 134000m;
        var montoInferior = 115375.91m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_134119_42_AndUpperLimitOf_160577_65()
    {
        //arrange
        var cuotaFija = 12264.16m;
        var sobreExcedente =  17.92m / 100m;
        var salario = 154000m;
        var montoInferior = 134119.42m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_160577_66_AndUpperLimitOf_323862_00()
    {
        //arrange
        var cuotaFija = 17005.47m;
        var sobreExcedente = 21.36m / 100m;
        var salario = 174000m;
        var montoInferior = 160577.66m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_323862_01_AndUpperLimitOf_510451_00()
    {
        //arrange
        var cuotaFija = 51883.01m;
        var sobreExcedente = 23.52m / 100m;
        var salario = 374000m;
        var montoInferior = 323862.01m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_510451_01_AndUpperLimitOf_974535_03()
    {
        //arrange
        var cuotaFija = 95768.74m;
        var sobreExcedente = 30.00m / 100m;
        var salario = 574000m;
        var montoInferior = 510451.01m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_974535_04_AndUpperLimitOf_1299380_04()
    {
        //arrange
        var cuotaFija = 234993.95m;
        var sobreExcedente = 32.00m / 100m;
        var salario = 574000m;
        var montoInferior = 974535.04m;
        var expectedResult = (salario - montoInferior) * sobreExcedente + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_1299380_05_AndUpperLimitOf_3898140_12()
    {
        //arrange
        var cuotaFija = 338944.34m;
        var sobreExcedente = 34.00m / 100m;
        var salario = 1740000m;
        var montoInferior = 1299380.05m;
        var Base = salario - montoInferior;
        var resultado = Base * sobreExcedente;
        var expectedResult = resultado + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResult));
    }
    
    [Fact]
    public void ProcessIrs_WhenSalaryIsBetweenTheLowerLimitOf_3898140_13_AndUpperLimitOf_infinite()
    {
        //arrange
        Decimal cuotaFija = 1222522.76m;
        Decimal salario = 4030000m;
        Decimal montoInferior = 3898140.13m;
        Decimal Base = salario - montoInferior;
        Decimal resultado = Base * (35.00m / 100m);
        Decimal expectedResul = resultado + cuotaFija;
        
        var inputirs = new InputISR { salarioBruto = salario};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(inputirs);
        
        //assert
        Assert.Equal(Math.Round(result.ISR), Math.Round(expectedResul));
    }
}