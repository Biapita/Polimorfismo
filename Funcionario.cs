namespace Polimorfismo
{
    public class Funcionario
    {
        public string nome { get; set; }
        public int Salario { get; set; }

        public virtual double calcularBonusAnual()
        {
            return Salario * 0.1;
        }
    }
}