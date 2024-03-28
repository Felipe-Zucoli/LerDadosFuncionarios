// See https://aka.ms/new-console-template for more information



using LerDadosFuncionarios;

class LerDados
{
    static void Main(string[] args)
    {
        Dados dados = new Dados();  

        Console.WriteLine("Informe o nome do funcionário: ");
        dados.name = Console.ReadLine();

        Console.WriteLine("Informe o salário do funcionário: ");
        dados.salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o imposto abatido: ");
        dados.imposto = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o bônus do funcionário: ");
        dados.bonus = double.Parse(Console.ReadLine());

        Console.WriteLine(dados);
    }
}
