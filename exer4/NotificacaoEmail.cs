using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.exer4
{
    internal class NotificacaoEmail : Inotificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviado Notificação por E-mail...");
        }

        public void Enviar(string Anexo)
        {
            Console.WriteLine("Enviando E-mail com anexo");
        }
    }
}
