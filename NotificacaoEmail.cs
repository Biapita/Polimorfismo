namespace Polimorfismo
{
    internal class NotificacaoEmail : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por Email...");
        }
        public void Enviar(string anexo)
        {
            Console.WriteLine($"Enviando email com anexo: {anexo}");
        }
    }
}