namespace ConsoleApp
{
    class Program
    {
        private static void CalcularMediaAlunos()
        {
            Console.WriteLine("Digite o nome do Aluno");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            List<int> notas = new List<int>();
            Console.WriteLine("digite as" + notas + "notas do aluno");
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero" + 1);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno" + nome + "é:" + media);
            Console.WriteLine("Suas notas são");
            foreach(int nota in notas) 
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
              
        }
        private static void Menu()
        {
            while (true)
            {
                string mensagem = "Olá usuario, bem vindo ao programa,\n\n Ultilizando programação funcional \n" +
                    "\n\n\n  Digite uma das opções abaixo:" +
                    "\n     0 - Sair do programa" +
                    "\n     1 - Para ler arquivos" +
                    "\n     2 - Para saexecutar a tabuada" +
                    "\n     3 - Calcular média de alunos";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("=======Opção Ler Arquivos=======");
                    LerArquivo(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("=======Opção Tabuada=======");
                    Console.WriteLine("digite o numero da tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                }
                else if (valor == CALCULAR_MEDIA)
                {
                    Console.WriteLine("=======Opção Ler Calcular Média=======");
                    CalcularMediaAlunos();
                }
                else
                {
                    Console.WriteLine("Opção invalida");
                }
            }
        }
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULAR_MEDIA = 3;
        static void Main(string[] args)
        {
            Menu();
        }
    }
}