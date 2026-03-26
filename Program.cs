using System;
 namespace desafio1;
 
    
 


class Program
{
    static void Main()    
    {
         
        List<string> paciente =new List<string>();
        int opcao;
        List<string> nome=new List<string>();
        List<int> idade=new List<int>();
        
                
        Console.WriteLine("=== Sistema de Entrada Hospitalar ===\n");
        
        Console.WriteLine("-----------Menu----------");
        Console.WriteLine("1 - Adicionar Paciente \n 2 - vVer Fila Atual \n 3 - Chamar Proximo \n 4 - Sair");
        string? opcaostring = Console.ReadLine();
        if (int.TryParse(opcaostring, out opcao))
         {
            switch (opcao)
            {
                
            case 1:

               Console.WriteLine("digite o nome do Paciente:");
               break;

            }  



        }



        

        // Entrada de dados
       
        Console.WriteLine("digite a lista de paciente:");
        string pacientes = Console.ReadLine(); 

      

        Console.Write("Digite o nível de dor (0 a 10): ");
        int nivelDor = int.Parse(Console.ReadLine());

        string prioridade;

        // Definir prioridade e cor
        if (nivelDor >= 8)
        {
            prioridade = "ALTA PRIORIDADE";
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (nivelDor >= 5)
        {
            prioridade = "MÉDIA PRIORIDADE";
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            prioridade = "BAIXA PRIORIDADE";
            Console.ForegroundColor = ConsoleColor.Green;
        }

        // Saída
        Console.WriteLine("\n=== Dados do Paciente ===");
        Console.ResetColor();
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"lista de paciente :{paciente}");

        // Cor para nível de dor
        if (nivelDor >= 8)
            Console.ForegroundColor = ConsoleColor.Red;
        else if (nivelDor >= 5)
            Console.ForegroundColor = ConsoleColor.Yellow;
        else
            Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"Nível de dor: {nivelDor}");

        // Cor para prioridade
        if (prioridade == "ALTA PRIORIDADE")
            Console.ForegroundColor = ConsoleColor.Red;
        else if (prioridade == "MÉDIA PRIORIDADE")
            Console.ForegroundColor = ConsoleColor.Yellow;
        else
            Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"Classificação: {prioridade}");

        Console.ResetColor();
    }
}