namespace ControleDeAtendimento
{
    public class Menu
    {
        Utils utils = new Utils();
        public void ExibirMenu()
        {
            Console.WriteLine("=== Sistema de Controle de Atendimento ===");
            Console.WriteLine("1. Adicionar Senha");
            Console.WriteLine("2. Chamar Próxima Senha");
            Console.WriteLine("0. Sair");
            Console.WriteLine("Escolha uma opção:");
        }

        public void MenuEscolha(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção 1 selecionada: Adicionar Senha");
                    break;
                case "2":
                    Console.WriteLine("Opção 2 selecionada: Chamar Próxima Senha");
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
