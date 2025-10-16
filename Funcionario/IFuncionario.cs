public interface IFuncionario
{
    string Nome { get; }
    double Salario { get; }

    void ReajustarSalario(double percentual);
}
 