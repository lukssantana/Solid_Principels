using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    public class EmailServices : IEmailServices
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            //sendEmail
        }
    }
}
