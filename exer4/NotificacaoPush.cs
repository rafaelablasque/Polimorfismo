using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.exer4
{
    internal class Notificacao : Inotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviado Notificação por Push para o app...");
        }
    }
}
