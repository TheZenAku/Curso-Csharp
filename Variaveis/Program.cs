using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis e Tipos de Dados integrais
            // integral assinado
            //sbyte a = 10; // -128 a 127
            //short b = 20; // -32.768 a 32.767
            //int c = 30; // -2.147.483.648 a 2.147.483.647
            //long d = 40; // -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //// integral nao assinado
            //byte e = 50; // 0 a 255
            //ushort f = 60; // 0 a 65.535
            //uint g = 70; // 0 a 4.294.967.295
            //ulong h = 80; // 0 a 18.446.744.073.709.551.615

            //sbyte numero = 100; // -128 a 127
            //numero = 50; // o valor de numero agora é 50
            //numero = a; // Atribuindo o valor de 'a' a 'numero'

            //Console.WriteLine(numero);
            //Console.ReadKey(); // Mantem o console aberto para ver o resultado
            #endregion

            #region Variaveis e Tipos de Dados reais
            //float real1 = 100.75f; // 32 bits, -3.402823E+38 a 3.402823E+38
            //double real2 = 500.574; // 64 bits, -1.79769313486232E+308 a 1.79769313486232E+308
            //decimal real3 = 1000.1234567890123456789012345678901234567890m; // 128 bits, -7.9228E+28 a 7.9228E+28 com 28-29 digitos de precisão

            //double valor;
            //valor = 500.768; // Atribuindo um valor do tipo double

            //Console.WriteLine(valor);
            //Console.ReadKey();
            #endregion

            #region Variáveis e tipos de dados char
            //char letra = '\u0061'; // Tipo char, armazena um único caractere unicode (neste caso, 'a')
            //char numero = '8'; // Tipo char, armazena um único caractere numérico (neste caso, '8')
            //char escape = '\\'; // Caractere de escape, neste caso, uma barra invertida

            //Console.WriteLine(letra);
            //Console.WriteLine(escape);
            //Console.ReadKey();
            #endregion

            #region Variável Boolean
            //bool verificar = false; // Tipo booleano, armazena verdadeiro ou falso
            //verificar = true;

            //Console.WriteLine(verificar);
            //Console.ReadKey();
            #endregion

            #region Variável String
            string texto = @"Olá, Mundo!\nTeste2"; // Tipo string, armazena uma sequência de caracteres
            string mensagem = null;
            mensagem = texto;

            Console.WriteLine(texto);
            Console.WriteLine(mensagem);
            Console.ReadKey();

            #endregion
        }
    }
}
