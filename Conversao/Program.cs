using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region conversao implicita
            //byte num1 = 100; // 0 a 255
            //ushort num2; // 0 a 65.535

            //float num3 = 10.5f; // 32 bits, -3.402823E+38 a 3.402823E+38
            //double num4 = num3; // 64 bits, -1.79769313486232E+308 a 1.79769313486232E+308

            //num3 = num1; // Conversão implícita de byte para float
            //num2 = num1; // Conversão implícita de byte para ushort

            //int numero = 'c'; // Conversão implícita de char para int (código ASCII)

            //Console.WriteLine(numero);
            //Console.ReadKey(); // Mantém o console aberto para ver o resultado
            #endregion


            #region conversao explicita
            //ushort num1 = 500;
            //byte num2 = (byte)num1; // Conversão explícita de ushort para byte (pode perder dados se num1 > 255)
            
            //float num3 = 2500.75f; // valor quebrado
            //int num4 = (int)num3; // Conversão explícita de float para int (perde a parte decimal)

            //char letra = (char)97;

            //Console.WriteLine(letra); // Exibe 100
            //Console.ReadKey(); // Mantém o console aberto para ver o resultado
            #endregion
        }
    }
}
