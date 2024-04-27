using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_SRP
{
    public class CorreoElectronico
    {
        private String destinatario;
        private String asunto;
        private String cuerpo;

        public CorreoElectronico(String destinatario, String asunto, String cuerpo)
        {
            this.destinatario = destinatario;
            this.asunto = asunto;
            this.cuerpo = cuerpo;
        }

        public void enviarCorreoElectronico(Persona remitente)
        {
            // Código para enviar el correo electrónico
        }
    }
}
