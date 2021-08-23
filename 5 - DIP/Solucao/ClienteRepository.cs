using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Client cliente)
        {
            //persiste em qualquer drive de DB   
        }
    }
}