namespace Polimorfismo
{
    internal class NotificacaoSMS : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando por SMS...");
        }
    }
}