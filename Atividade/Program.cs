using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
           float valor_pag;
           Console.WriteLine("Informe o nome: ");
           string var_nome = Console.ReadLine();
           Console.WriteLine("Informar o endereço:");
           string var_endereco = Console.ReadLine();
           Console.WriteLine("Pessoa Física (f) ou Jurídica (j)?");
           string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                // Pessoa Física
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informe o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar valor da compra: ");
                valor_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(valor_pag);
                Console.WriteLine("-------- PESSOA FÍSICA --------");
                
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor da compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .: " + pf.total.ToString("C"));
            }
            else if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informe o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar valor da compra: ");
                valor_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(valor_pag);
                Console.WriteLine("-------- PESSOA JURÍDICA --------");

                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);
                Console.WriteLine("Valor da compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .: " + pj.total.ToString("C"));
            }
        }
    }
}