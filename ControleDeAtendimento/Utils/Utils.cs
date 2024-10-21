namespace ControleDeAtendimento
{
    using System;
    using System.Text;
    public class Utils
    {
        public void WriteEmptyLine(int valor)
        {
            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine();
            }
        }

        public void MultiplyString(string text, int qtd)
        {
            StringBuilder NewString = new StringBuilder();
            for (int i = 0; i < qtd; i++)
            {
                 NewString.Append(text);
            }
            Console.WriteLine(NewString.ToString());
        }
    }
}
