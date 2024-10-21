namespace ControleDeAtendimento
{
    public class MenuUsuario
    {
        Utils utils = new Utils();
        public void ExibirMenu()
        {
            Console.WriteLine("=== Sistema de Controle de Atendimento ===");
            Console.WriteLine("Qual Será o seu atendimento?");

        }

        public void MenuEscolha(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção 1 selecionada: Adicionar Senha");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
