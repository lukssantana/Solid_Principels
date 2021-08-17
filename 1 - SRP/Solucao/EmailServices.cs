namespace SOLID.SRP.Solucao
{
    public static class EmailServices
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public static void Enviar(string de, string para, string assunto, string mensagem)
        {
            //funcao de enviarEmail
        }
    }
}