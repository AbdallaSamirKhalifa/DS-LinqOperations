using System;
using static BitArrays.Program;
using static System.Console;
using System.Collections;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Collections.Generic;
internal class Program2
{
    static void Main(string[] args)
    {

        BitArray bits1 = new BitArray(new bool[] { true, false, true, false });
        BitArray bits2 = new BitArray(new bool[] { true, true, true, false });
        
        WriteLine($"Bits1: {BitArrayToString(bits1)}");
        WriteLine($"Bits2: {BitArrayToString(bits2)}");
        WriteLine($"Bitwise operator:");

        //Bitwise And
        BitArray resultAnd= new BitArray(bits1);
        resultAnd.And(bits2);
        WriteLine($"\nBitwise And result:");
        WriteLine(BitArrayToString(bits1));
        WriteLine(BitArrayToString(bits2));
        WriteLine("-----------");
        WriteLine(BitArrayToString(resultAnd));

        //Bitwise Or operation

        BitArray resultOr = new BitArray(bits1);
        resultOr.Or(bits2);
        WriteLine($"\nBitwise OR result:");
        WriteLine(BitArrayToString(bits1));
        WriteLine(BitArrayToString(bits2));
        WriteLine("-----------");
        WriteLine(BitArrayToString(resultOr));


        //Bitwise Not operation

        BitArray resultNot = new BitArray(bits1);
        resultNot.Not();
        WriteLine($"\nBitwise Not result:");
        WriteLine(BitArrayToString(bits1));
        WriteLine("-----------");
        WriteLine(BitArrayToString(resultNot));


        //Bitwise Xor operation

        BitArray resultXor = new BitArray(bits1);
        resultXor.Xor(bits2);
        WriteLine($"\nBitwise Xor result:");
        WriteLine(BitArrayToString(bits1));
        WriteLine(BitArrayToString(bits2));
        WriteLine("-----------");
        WriteLine(BitArrayToString(resultXor));

        /*
         * Explaning Xor:
         * returns true if the two bits are different, otherwise returns false
         */




        ReadKey();
    }
}

