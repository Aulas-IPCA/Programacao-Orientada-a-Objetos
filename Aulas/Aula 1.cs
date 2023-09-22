public class Calculadora
{
    public int Adicao(int a, int b)
    {
        return a + b;
    }

    public int Subtracao(int a, int b)
    {
        return a - b;
    }

    public int Multiplicacao(int a, int b)
    {
        return a * b;
    }

    public int Divisao(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
    }
}