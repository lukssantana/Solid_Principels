using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(
            IEmailServices emailServices, 
            IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Client cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}