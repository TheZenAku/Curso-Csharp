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

            #region metodo parse
            //string txtNumero = "1985";

            //int numero = int.Parse(txtNumero); // Converte string para int

            //byte num1 = byte.Parse("100"); // Converte string para byte

            //double num2 = double.Parse("10.5"); // Converte string para double

            //float num3 = float.Parse("10.5"); // Converte string para float

            ////Console.Write("Digite o primeiro número: ");
            ////int numero1 = int.Parse(Console.ReadLine());

            ////Console.Write("Digite o segundo número: ");
            ////int numero2 = int.Parse(Console.ReadLine());

            ////int soma = numero1 + numero2;


            //Console.WriteLine(num2);
            //Console.ReadKey();
            #endregion

            #region classe convert
            //string text = Convert.ToString(2500);

            //double num1 = Convert.ToDouble(false);

            //int num2 = Convert.ToInt32('C');

            //Console.WriteLine(num2);
            //Console.ReadKey();
            #endregion
        }
    }
}
