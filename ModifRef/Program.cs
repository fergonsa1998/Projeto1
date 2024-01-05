using System;

namespace ModifRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
// O REF vai funcionar
// -- quando se utiliza o ref na declaração da sua variavel 'a' -- (ex .riple(ref a);
// -- exige que a variavel seja iniciada