using System;
class Calculadora : ICalculadoraBase, ICalculadoraAvancada
{
    public double Cosseno(double angulo)
    {
         return Math.Cos(angulo);
    }

    public double Divisao(double a , double b)
    {
        return a / b;
    }

    public double Mutiplicacao(double a , double b)
    {
        return a * b;
    }

    public double Seno(double angulo)
    {
        
        return Math.Sin(angulo);
    }

    public double Soma(double a , double b)
    {
        return a + b;
    }

    public double Subtracao(double a , double b)
    {
        return a - b;
    }

    public double Tangente(double angulo)
    {
         return Math.Tan(angulo);
    }
}