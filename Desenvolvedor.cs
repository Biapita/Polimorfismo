namespace Polimorfismo
{
    public class Desenvolvedor : Funcionario
    {
        public override double calcularBonusAnual()
        {
            return Salario * 0.12;
        }
    }
}