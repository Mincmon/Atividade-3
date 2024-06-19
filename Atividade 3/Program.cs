using System;

namespace Atividade_3
{
    class Projeto
    {
        static void Main(string[] args){


            /*Console.WriteLine("Qual seu número?");
            int numF = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas você trabalha?");
            int horasT = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você recebe por hora?");
            int valorH = int.Parse(Console.ReadLine());
            int salario = horasT * valorH;
            Console.WriteLine("N° do funcionário: " + numF + "\n Salário: " + salario);

            Console.WriteLine("Código da primeira peça");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("N° de peças");
            int quant1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Código da segunda peça");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("N° de peças");
            int quant2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário");
            int valor2 = int.Parse(Console.ReadLine());

            int preco1 = quant1 * valor1;
            int preco2 = quant2 * valor2;
            int total = preco1 + preco2;

            Console.WriteLine("Total a pagar: " + total);

            Console.WriteLine("Valor A");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor B");
            int valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor C");
            int valorC = int.Parse(Console.ReadLine());

            float aTri = valorA * valorC / 2;
            double aCir = 3.14159 * valorC * valorC;
            float aTrap = (valorC + valorB) / 2 * valorC;
            float aQuad = valorB * valorB;
            float aRet = valorA * valorB;

            Console.WriteLine("Triângulo: " + aTri);
            Console.WriteLine("Círculo: " + aCir);
            Console.WriteLine("Trapésio: " + aTrap);
            Console.WriteLine("Quadrado: " + aQuad);
            Console.WriteLine("Retângulo: " + aRet);

            Console.WriteLine("login:");
            string login = Console.ReadLine();
            Console.WriteLine("senha:");
            string senha = Console.ReadLine();

            if(login == "admin" && senha == "1234"){
                Console.WriteLine("Pode acessar");
            } else {
                Console.WriteLine("Login ou senha incorreto");
            };

            Console.WriteLine("Blusas em estoque:");
            int estoque = int.Parse(Console.ReadLine());

            if(estoque > 40) {
                Console.WriteLine("ESTOQUE OK");
            } else if(estoque > 20 && estoque <= 40) {
                Console.WriteLine("ATENÇÃO AO ESTOQUE");
            } else {
                Console.WriteLine("ESTOQUE CRÍTICO");
            };

            Console.WriteLine("Insira sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu salário:");
            int salario = int.Parse(Console.ReadLine());

            if(idade >= 18 && salario > 2000) {
                Console.WriteLine("PODE VIAJAR");
            } else{
                Console.WriteLine("NÃO PODE VIAJAR");    
            };

            Console.WriteLine("Digite o número do seu voto");
            int voto = int.Parse(Console.ReadLine());

            if ( voto >= 1 && voto <= 2) {
                Console.WriteLine("DESENHO E PINTURA");
            }else if (voto >= 3 && voto <= 4) {
                Console.WriteLine("DISCURSO E DEBATE");
            } else{
                Console.WriteLine("DANÇA");
            };*/

            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero > 100) {
                Console.WriteLine("Número especial");
            } else {
                Console.WriteLine("Fora do intervalo");
            };
        }
    }
}
