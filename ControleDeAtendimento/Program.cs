namespace ControleDeAtendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            string? opcao = null;

            do
            {
                Menu menu = new Menu();
                menu.ExibirMenu();
                opcao = Console.ReadLine();
                if (opcao != null)
                {
                    menu.MenuEscolha(opcao);
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            } while (opcao != "0");
        }
    }
}
