namespace SOLID.SRP.Solucao
{
    public static class ClienteService
    {
        public static string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}