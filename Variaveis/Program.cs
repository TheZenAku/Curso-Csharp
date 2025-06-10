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
            // integral assinado
            sbyte a = 10; // -128 a 127
            short b = 20; // -32.768 a 32.767
            int c = 30; // -2.147.483.648 a 2.147.483.647
            long d = 40; // -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            // integral nao assinado
            byte e = 50; // 0 a 255
            ushort f = 60; // 0 a 65.535
            uint g = 70; // 0 a 4.294.967.295
            ulong h = 80; // 0 a 18.446.744.073.709.551.615

            sbyte numero = 100; // -128 a 127
            numero = 50; // o valor de numero agora é 50
            numero = a; // Atribuindo o valor de 'a' a 'numero'

            Console.WriteLine(numero);
            Console.ReadKey(); // Mantem o console aberto para ver o resultado

        }
    }
}
