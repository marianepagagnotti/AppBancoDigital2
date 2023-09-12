using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public DateTime Data { get; set; }
        public int conta_remetente { get; set; }
        public int conta_destinatario { get; set; }
    }
}
