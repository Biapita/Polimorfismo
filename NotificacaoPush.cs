
namespace Polimorfismo
{
    internal class NotificacaoPush : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação push para o app...");
        }
    }
}
