namespace SOLID.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Valida Conta
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}