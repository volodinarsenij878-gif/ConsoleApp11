using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sbyte:   {sizeof(sbyte)} байт");
            Console.WriteLine($"short:   {sizeof(short)} байт");
            Console.WriteLine($"int:     {sizeof(int)} байт");
            Console.WriteLine($"long:    {sizeof(long)} байт");
            Console.WriteLine($"float:   {sizeof(float)} байт");
            Console.WriteLine($"double:  {sizeof(double)} байт");

            // Marshal.SizeOf работает для decimal во всех версиях .NET
            int decimalSize = Marshal.SizeOf<decimal>();
            Console.WriteLine($"decimal: {decimalSize} байт");

            Console.WriteLine($"char:    {sizeof(char)} байт");

            // Для bool используем константу, так как Marshal.SizeOf тоже не даст точный размер в байтах для примитивов в некоторых контекстах
            Console.WriteLine($"bool: 1 байт");
        }
    }
}