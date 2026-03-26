using System;
using System.Security.Cryptography.X509Certificates;
namespace desafio1;

   public class Pacientes()
{
  public string? nomePaciente;
  public string? idadePacientestring;


  public int idadePaciente;
  public int nivelDor;
  List<string>listaVermelha =new List<string>();
  List<string>listaAmarela =new List<string>();
   List<string>listaVerde =new List<string>();
   List<string>listaPaciente =new List<string>();

  //Metodos sao acoes que pertence a minha classe
  public void adicionarPaciente()
    {
        Console.Write("Digite o nome do paciente: ");
        nomePaciente = Console.ReadLine()?? ""; 
        Console.Write("Digite a idade do paciente: ");
        idadePacientestring = Console.ReadLine();

        if (int.TryParse(idadePacientestring, out idadePaciente))


        {
          Console.WriteLine("digite o nivel de dor.");
          if(int.TryParse(Console.ReadLine(), out nivelDor))
            {
               ClassificarPrioridade(nomePaciente, idadePaciente, nivelDor);

            }
            else
            {
                Console.WriteLine("dor nao indentificada.digite um numero.");
            } 
        }
        else
        {
            Console.WriteLine("A idade nao e um numero.");
        }

    }

    public void ClassificarPrioridade(string nomePaciente, int idadePaciente, int nivelDor)
    {
        if (nivelDor>=9 || idadePaciente >= 80)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Prioridade Alta - Pulseira Vermelha");
                    listaVermelha.Add(nomePaciente);
                    Console.ResetColor();
                    
                } 
                else if (nivelDor >= 5)
                {
                    
                 Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Prioridade Media - Pulseira Amarela");
                    listaVermelha.Add(nomePaciente);
                    Console.ResetColor();



                }
                else
                {
                
                   Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Prioridade Baixa - Pulseira Verde");
                    listaVermelha.Add(nomePaciente);
                    Console.ResetColor();
                         
                    
                }
    }

     public void ListarPaciente()
    {
      int contadorAmarelo = 0;
      int contadorVerde = 0;
      listaPaciente = new List<string>();
      

        foreach(var nome in listaVermelha)
        {
            
            listaAmarela.Add(nome);
        }
        while( contadorAmarelo < listaAmarela.Count() || contadorVerde  <listaVerde.Count()){
            int i = 0;
            while(contadorAmarelo < listaAmarela.Count()&& i<2)
            {
                
                listaAmarela.Add(listaAmarela[contadorAmarelo]);
                contadorAmarelo ++;
                i++;

            }
        listaPaciente.Add(listaVerde[contadorVerde]);
        contadorVerde ++;
        }
        
    }
    
    public void ChamarProximo()
    {
       ListarPaciente();
       Console.WriteLine("sr.(A){listaPacientes}[0]}Dirigir-ao Consultório");
       ExcruirPaciente(); 
    }
    public void ExcruirPaciente()
    {
        if (listaVermelha.Contains(listaPaciente[0]))
        {
            listaVermelha.RemoveAt(0);
        }
        else if (listaAmarela.Contains(listaPaciente[0]))
        {
            listaAmarela.RemoveAt(0);
        }
        else
        {
            listaVerde.RemoveAt(0);
        }
    }

           public void VerificarListaAtendimento()
    {
        
        ListarPaciente();
        int i=1;
        foreach (var nome in listaPaciente)
        {
            Console.WriteLine($"(i) - {nome}");
            i++;
        }
    }


}
