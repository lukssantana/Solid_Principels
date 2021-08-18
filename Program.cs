using System;
using SOLID.SRP.Solucao;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {     
            #region SRP 
            Cliente cliente = new Cliente {
                ClienteId = 1,
                Nome = "lucas",
                Email = "luks.santanna@gmail.com",
                CPF = "12345678900",
                DataCadastro = DateTime.Today   
            };
            
            string clienteService = ClienteService.AdicionarCliente(cliente);   
            Console.WriteLine(clienteService);
            #endregion 
        }
    }
}
