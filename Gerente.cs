namespace Polimorfismo
{
    public class Gerente : Funcionario
    {
        public override double calcularBonusAnual()
        {
            return Salario * 0.15 + 1000;
        }
    }
}