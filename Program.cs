using System;
using System.ComponentModel;

class Program
{
    static void Main()    
    {
         
        List<string> pacientes =new List<string>();
                
        Console.WriteLine("=== Sistema de Entrada Hospitalar ===\n");
        

        // Entrada de dados
        Console.Write("Digite o nome do paciente: ");
        string nome = Console.ReadLine();
        Console.WriteLine("digite a lista de paciente:");
        string paciente = Console.ReadLine(); 

        Console.Write("Digite a idade do paciente: ");
        int idade = int.Parse(Console.ReadLine());

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