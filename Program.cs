using System;
using SOLID.SRP.Solucao;
using SOLID.OCP.Violacao;
using SOLID.LSP.Solucao;
using SOLID.ISP.Violacao;
using SOLID.DIP.Solucao;
using SOLID.DIP.Solucao.Interfaces;

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
        
            #region OCP
            DebitoConta d = new DebitoConta();
            d.Debitar(1000,"12345-5",TipoConta.Corrente);
            #endregion

            #region LSP
            Quadrado q = new Quadrado(5,5);
            Retangulo r = new Retangulo(10,5);
            Console.WriteLine(q.Area + " & " + r.Area);
            #endregion

            #region ISP
            CadastroProduto p = new CadastroProduto();
            p.EnviarEmail();
            #endregion

            #region DSP
            
            #endregion
        }
    }
}
